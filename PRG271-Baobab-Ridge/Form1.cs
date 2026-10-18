using System.Security.Cryptography;

namespace PRG271_Baobab_Ridge
{
    public partial class Form1 : Form

    {
        //Stores the valid animals records loaded from file. 
        private List<Animal> animals = new List<Animal>();

        //Initialises the form and loads the saved animal records.
        public Form1()
        {
            InitializeComponent();

            //call the method to load the animals from the file when the form is initialized
            LoadAnimals(); 
        }

        //Loads and validates animals records. Contains file and error handling
        private void LoadAnimals() 
        {
            animals.Clear(); //Clears prior loaded records to prevent duplicates when reloading. 

            string filepath = Path.Combine(Application.StartupPath, "animals.txt"); //Locate animals.txt in the applications running directory 


            //Declare the array here so the records remain available after the try block.
            string[] lines;

            try
            {
                //create an empty data file when the application runs for the first time. 
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Close();
                }
                //read every record for validations
                lines = File.ReadAllLines(filepath);
            }
            catch (UnauthorizedAccessException) 
            {
                MessageBox.Show(
                    "Permission was denied when accessing animals.txt. " +
                    "Check that the file and application folder are writable.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                RefreshGrid();
                return;
            }
            catch (IOException) 
            {
                MessageBox.Show(
                    "animals.txt could not be read " +
                    "It may be in use by another program", 
                    "File Access Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                RefreshGrid();
                return;
            }


            //Track invalid rows so they can be reported after loading finishes.
            int skippedRowCount = 0;
            List<string> skippedRowMessages = new List<string>();
            int currentRowNumber = 1;

            foreach (string line in lines)
            {
                int rowNumber = currentRowNumber;

                void SkipCurrentRow(string reason) //Record why a row was skipped for the final loading summary.
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

                //Validate every stored field before creating the Animal object.
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

                //read stored classification and verify it matches the recovery score
                string storedStatus = fields[5].Trim();
                string storedHousingUnit = fields[6].Trim();

               
                if (animal.Status != storedStatus || animal.HousingUnit != storedHousingUnit)
                {
                    SkipCurrentRow("Stored classification does not match the recovery score.");
                    currentRowNumber++;
                    continue;
                }
                
                animals.Add(animal);
                currentRowNumber++;
            }

            // Display the validated animals and provide readable column headings.
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;

            dgvAnimals.Columns["AnimalId"].HeaderText = "Animal ID";
            dgvAnimals.Columns["RecoveryScore"].HeaderText = "Recovery Score";
            dgvAnimals.Columns["HousingUnit"].HeaderText = "Housing Unit";

            //Leave the grid unselected until the user deliberately selects an animal.
            dgvAnimals.ClearSelection();

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

        // Ensure that no animal is selected automatically when the form opens.
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAnimals.ClearSelection();
            dgvAnimals.CurrentCell = null;
        }

        private void txtAnimalId_TextChanged(object sender, EventArgs e)
        {

        }
        // Calculates, displays, and saves a summary of the currently loaded animals.
        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            SummaryResult result = SummaryReportService.Calculate(animals);

            lblTotal.Text = result.Total.ToString();
            lblAvgAge.Text = SummaryReportService.FormatAverage(result.AverageAge);
            lblAvgScore.Text = SummaryReportService.FormatAverage(result.AverageRecoveryScore);
            lblCritical.Text = result.StatusCounts["Critical"].ToString();
            lblSerious.Text = result.StatusCounts["Serious"].ToString();
            lblStable.Text = result.StatusCounts["Stable"].ToString();
            lblRecovering.Text = result.StatusCounts["Recovering"].ToString();
            lblReleaseReady.Text = result.StatusCounts["Release-Ready"].ToString();

            string summaryPath =
                Path.Combine(Application.StartupPath, "summary.txt");

            try
            {
                SummaryReportService.SaveReport(
                    summaryPath,
                    SummaryReportService.BuildReportText(result, DateTime.Now));

                MessageBox.Show("Summary report saved to summary.txt.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "The program does not have permission to write summary.txt.");
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "summary.txt is in use by another program or could not be written. Close it and try again.");
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Something went wrong while saving the summary report.");
            }
        }

        private void grpSummaryArea_Enter(object sender, EventArgs e)
        {

        }

        
    }
}

