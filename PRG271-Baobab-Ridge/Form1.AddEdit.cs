namespace PRG271_Baobab_Ridge
{
    public partial class Form1
    {
        private Animal? editingAnimal = null;

        private string AnimalsFilePath => Path.Combine(Application.StartupPath, "animals.txt");

        private void RefreshGrid()
        {
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //read form input -> validate
            if (!AnimalValidator.ValidateAnimalIdFormat(txtAnimalId.Text, out string animalId, out string error) ||
                !AnimalValidator.ValidateAnimalName(txtName.Text, out string name, out error) ||
                !AnimalValidator.ValidateAnimalSpecies(txtSpecies.Text, out string species, out error) ||
                !AnimalValidator.ValidateAnimalAge(txtAge.Text, out int age, out error) ||
                !AnimalValidator.ValidateRecoveryScore(txtRecoveryScore.Text, out int score, out error))
            {
                MessageBox.Show(error, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check duplicate ID (validator already uppercased it)
            if (animals.Any(a => a.AnimalId == animalId))
            {
                MessageBox.Show($"An animal with ID {animalId} already exists.",
                    "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //classify score -> create Animal (the constructor calls ClassifyRecovery itself)
            Animal animal = new Animal(animalId, name, species, age, score);

            //append exactly one new line to animals.txt
            try
            {
                AppendAnimalToFile(animal);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not save to animals.txt:\n" + ex.Message,
                    "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //refresh grid -> clear form
            animals.Add(animal);
            RefreshGrid();
            ClearForm();
        }

        private void AppendAnimalToFile(Animal animal)
        {
            string path = AnimalsFilePath;

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            string existing = File.ReadAllText(path);
            string prefix = (existing.Length > 0 && !existing.EndsWith('\n')) ? Environment.NewLine : "";

            File.AppendAllText(path, prefix + FormatAnimalLine(animal) + Environment.NewLine);
        }

        private static string FormatAnimalLine(Animal a)
        {
            return string.Join("|", a.AnimalId, a.Name, a.Species, a.Age, a.RecoveryScore, a.Status, a.HousingUnit);
        }

        private void ClearForm()
        {
            txtAnimalId.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtRecoveryScore.Clear();
            txtAnimalId.Focus();
        }

        private void dgvAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; //header click

            if (dgvAnimals.Rows[e.RowIndex].DataBoundItem is Animal selected)
            {
                EnterEditMode(selected);
            }
        }

        //load by ID search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!AnimalValidator.ValidateAnimalIdFormat(txtSearchId.Text, out string searchId, out string error))
            {
                MessageBox.Show(error, "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Animal? found = animals.FirstOrDefault(a => a.AnimalId == searchId);
            if (found == null)
            {
                MessageBox.Show($"No animal found with ID {searchId}.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EnterEditMode(found);
        }

        //enter Edit Mode
        private void EnterEditMode(Animal animal)
        {
            editingAnimal = animal;

            txtAnimalId.Text = animal.AnimalId;
            txtAnimalId.ReadOnly = true; //AnimalId has a private setter, so the ID can't change
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtRecoveryScore.Text = animal.RecoveryScore.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }

        //validate changes -> re-run classification -> rewrite file (only this record changes)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (editingAnimal == null) return;

            //the ID is locked, so only validate the editable fields
            if (!AnimalValidator.ValidateAnimalName(txtName.Text, out string name, out string error) ||
                !AnimalValidator.ValidateAnimalSpecies(txtSpecies.Text, out string species, out error) ||
                !AnimalValidator.ValidateAnimalAge(txtAge.Text, out int age, out error) ||
                !AnimalValidator.ValidateRecoveryScore(txtRecoveryScore.Text, out int score, out error))
            {
                MessageBox.Show(error, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //remember old values so we can roll back if the file write fails
            string oldName = editingAnimal.Name;
            string oldSpecies = editingAnimal.Species;
            int oldAge = editingAnimal.Age;
            int oldScore = editingAnimal.RecoveryScore;

            editingAnimal.Name = name;
            editingAnimal.Species = species;
            editingAnimal.Age = age;
            editingAnimal.RecoveryScore = score;
            editingAnimal.ClassifyRecovery(); //re-run classification (Status + HousingUnit)

            try
            {
                ReplaceAnimalLineInFile(editingAnimal);
            }
            catch (Exception ex) when (ex is IOException || ex is InvalidOperationException)
            {
                editingAnimal.Name = oldName;
                editingAnimal.Species = oldSpecies;
                editingAnimal.Age = oldAge;
                editingAnimal.RecoveryScore = oldScore;
                editingAnimal.ClassifyRecovery();

                MessageBox.Show("Could not update animals.txt:\n" + ex.Message,
                    "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RefreshGrid();
            ExitEditMode(); //back to Add Mode
        }

       
        private void ReplaceAnimalLineInFile(Animal animal)
        {
            string[] lines = File.ReadAllLines(AnimalsFilePath);
            bool replaced = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split('|');
                if (fields.Length > 0 && fields[0].Trim().ToUpper() == animal.AnimalId)
                {
                    lines[i] = FormatAnimalLine(animal);
                    replaced = true;
                    break;
                }
            }

            if (!replaced)
            {
                throw new InvalidOperationException($"Record {animal.AnimalId} was not found in animals.txt.");
            }

            File.WriteAllLines(AnimalsFilePath, lines);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitEditMode();
        }

        private void ExitEditMode()
        {
            editingAnimal = null;
            txtAnimalId.ReadOnly = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            txtSearchId.Clear();
            ClearForm();
        }
    }
}
