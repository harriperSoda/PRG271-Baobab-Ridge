using System.Security.Cryptography;

namespace PRG271_Baobab_Ridge
{
    public partial class Form1 : Form

    {
        //creating the list for data to be stored somwhere when it is fetched
        private List<Animal> animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
            LoadAnimals(); //call the method to load the animals from the file when the form is initialized
        }


        private void LoadAnimals() //method responsible for loading the file. Private so that i can only be called from inside Form1
        {
            animals.Clear(); //clears the list ensuring that there are no duplicates when loading the file again. This is important as we will be calling this method multiple times. 

            string filepath = Path.Combine(Application.StartupPath, "animals.txt"); //provideds the folder containing the running application and Path.Combine adds the file name. 

            if (!File.Exists(filepath)) //if the aninmals.txt files does not exist, create it and close it. 
            {
                File.Create(filepath).Close();

            }

            string[] lines = File.ReadAllLines(filepath); //reade every file row and stores it in an array

            //Process each line and create Animal objects


            //iterate through above array. First, if the line is empty we will skip it. 
            int skippedRowCount = 0;
            List<string> skippedRowMessages = new List<string>();
            int currentRowNumber = 1;

            foreach (string line in lines)
            {
                int rowNumber = currentRowNumber;

                void SkipCurrentRow(string reason)
                {
                    skippedRowCount++;
                    skippedRowMessages.Add($"Row {rowNumber}: {reason}");
                }

                if (string.IsNullOrWhiteSpace(line))
                {
                    SkipCurrentRow("Row is empty.");
                    currentRowNumber++;
                    continue;
                }

                string[] fields = line.Split('|'); //splits the line into an array of strings using the '|' character as a delimiter. We are taking the current line and dividing it into smaller parts that are stored in fields. 
                if (fields.Length != 7) //Need to validate we have a complete row of data.
                {
                    SkipCurrentRow($"Expected 7 fields, but found {fields.Length}.");
                    currentRowNumber++;
                    continue;
                }

                //validate animalID stored in fields
                bool isAnimalIdValid =
                    AnimalValidator.ValidateAnimalIdFormat(
                        fields[0],
                        out string animalId,
                        out string errorMessage);

                if (isAnimalIdValid == false)
                {
                    SkipCurrentRow(errorMessage);
                    currentRowNumber++;
                    continue;
                }

                //we now have a valid ID and move to validate the name.
                bool isAnimalNameValid =
                    AnimalValidator.ValidateAnimalName(
                        fields[1],
                        out string animalName,
                        out errorMessage);
                if (isAnimalNameValid == false)
                {
                    SkipCurrentRow(errorMessage);
                    currentRowNumber++;
                    continue;
                }

                //we now have a valid name and move to validate the species.
                bool isAnimalSpeciesValid =
                    AnimalValidator.ValidateAnimalSpecies(
                        fields[2],
                        out string animalSpecies,
                        out errorMessage);
                if (isAnimalSpeciesValid == false)
                {
                    SkipCurrentRow(errorMessage);
                    currentRowNumber++;
                    continue;
                }

                //we now have a valid species and move to validate the age.
                bool isAnimalAgeValid =
                    AnimalValidator.ValidateAnimalAge(
                        fields[3],
                        out int animalAge,
                        out errorMessage);
                if (isAnimalAgeValid == false)
                {
                    SkipCurrentRow(errorMessage);
                    currentRowNumber++;
                    continue;
                }

                //we now have a valid age and move to validate the recovery score.
                bool isRecoveryScoreValid =
                    AnimalValidator.ValidateRecoveryScore(
                        fields[4],
                        out int recoveryScore,
                        out errorMessage);
                if (isRecoveryScoreValid == false)
                {
                    SkipCurrentRow(errorMessage);
                    currentRowNumber++;
                    continue;
                }

                //create a new Animal object 
                Animal animal = new Animal(animalId, animalName, animalSpecies, animalAge, recoveryScore);

                //read stored classification
                string storedStatus = fields[5].Trim();
                string storedHousingUnit = fields[6].Trim();

                //compare stored classification with calculated classification
                if (animal.Status != storedStatus || animal.HousingUnit != storedHousingUnit)
                {
                    SkipCurrentRow("Stored classification does not match the recovery score.");
                    currentRowNumber++;
                    continue;
                }
                //add the animal to the list
                animals.Add(animal);
                currentRowNumber++;
            }

            // Bind valid animals to the DataGridView
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;

            // Only show a warning when rows were skipped
            if (skippedRowCount > 0)
            {
                string summaryMessage =
                    $"{animals.Count} animals were loaded successfully.\n" +
                    $"{skippedRowCount} rows were skipped.\n\n" +
                    string.Join(Environment.NewLine, skippedRowMessages);

                MessageBox.Show(
                    summaryMessage,
                    "Animal Loading",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }


        }

        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

    }
}
