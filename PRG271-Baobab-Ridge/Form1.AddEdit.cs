namespace PRG271_Baobab_Ridge
{
    public partial class Form1
    {
        private Animal? editingAnimal = null; //Tracks the animal currently being edited, or null if in Add Mode

        private string AnimalsFilePath => Path.Combine(Application.StartupPath, "animals.txt");// Gets the full path to animals.txt in the application's running directory.

        //Refreshed the animal grid and clears auto selected rows
        private void RefreshGrid()
        {
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;

            //Restore the prior user-friendly columns and headings. Without this it reverts back to AnimalID, instead of Animal ID
            dgvAnimals.Columns["AnimalId"].HeaderText = "Animal ID";
            dgvAnimals.Columns["RecoveryScore"].HeaderText = "Recovery Score";
            dgvAnimals.Columns["HousingUnit"].HeaderText = "Housing Unit";

            //requires the user to select a row
            dgvAnimals.ClearSelection();
            dgvAnimals.CurrentCell = null;
        }
        //Validates the entered details, saves a new animal, and refreshes the grid.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //read form input -> validate each field seperately with focus
            if (!AnimalValidator.ValidateAnimalIdFormat(txtAnimalId.Text, out string animalId, out string error))
            {
                MessageBox.Show(error, "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnimalId.Focus();
                return;
            }
            if (!AnimalValidator.ValidateAnimalName(txtName.Text, out string name, out error))
            {
                MessageBox.Show(error, "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (!AnimalValidator.ValidateAnimalSpecies(txtSpecies.Text, out string species, out error))
            {
                MessageBox.Show(error, "Invalid Species", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSpecies.Focus();
                return;
            }
            if (!AnimalValidator.ValidateAnimalAge(txtAge.Text, out int age, out error))
            {
                MessageBox.Show(error, "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }
            if (!AnimalValidator.ValidateRecoveryScore(txtRecoveryScore.Text, out int score, out error))
            {
                MessageBox.Show(error, "Invalid Recovery Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRecoveryScore.Focus();
                return;
            }

            //check duplicate ID (validator already uppercased it)
            if (animals.Any(a => a.AnimalId == animalId))
            {
                MessageBox.Show($"An animal with ID {animalId} already exists.",
                    "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnimalId.Focus();
                return;
            }

            //classify score -> create Animal (the constructor calls ClassifyRecovery itself)
            Animal animal = new Animal(animalId, name, species, age, score);

            //append exactly one new line to animals.txt
            try
            {
                AppendAnimalToFile(animal);
            }
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show(
                "You do not have permission to write to animals.txt.",
                "Access Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                return;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not save to animals.txt:\n" + ex.Message,
                    "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Add the successfully saved animal to the grid.
            animals.Add(animal);
            RefreshGrid();

            //Add message box to confirm addition
            MessageBox.Show(
                $"Animal added successfully \n\n" +
                $"Status: {animal.Status} \n" +
                $"Housing Unit: {animal.HousingUnit}");
            ClearForm();
        }
        //Appends one animal record while preserving correct line separation.
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
        // Converts an animal into the pipe-delimited format used by animals.txt.
        private static string FormatAnimalLine(Animal a)
        {
            return string.Join("|", a.AnimalId, a.Name, a.Species, a.Age, a.RecoveryScore, a.Status, a.HousingUnit);
        }
        //Clears the animal input fields and returns focus to Animal ID.
        private void ClearForm()
        {
            txtAnimalId.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtRecoveryScore.Clear();
            txtAnimalId.Focus();
        }
        //Opens the selected grid animal for editing.
        private void dgvAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; //ignore column header click

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

        //Loads the selected animal into the fields and enables edit controls.
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

            //the ID is locked, so only validate the editable fields seperately and add focus on invalid field
            if(!AnimalValidator.ValidateAnimalName(txtName.Text, out string name, out string error))
            {
                MessageBox.Show(error, "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (!AnimalValidator.ValidateAnimalSpecies(txtSpecies.Text, out string species, out error))
            {
                MessageBox.Show(error, "Invalid Species", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSpecies.Focus();
                return;
            }
            if (!AnimalValidator.ValidateAnimalAge(txtAge.Text, out int age, out error))
            {
                MessageBox.Show(error, "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }
            if (!AnimalValidator.ValidateRecoveryScore(txtRecoveryScore.Text, out int score, out error))
            {
                MessageBox.Show(error, "Invalid Recovery Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRecoveryScore.Focus();
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
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException || ex is InvalidOperationException)
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
            ExitEditMode(); 
        }

        // Replaces the matching animal record in animals.txt.
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
        //Cancels editing and returns the form to add mode.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitEditMode();
        }
        // Clears the selected animal and restores the default add mode.
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
