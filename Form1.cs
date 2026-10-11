using System.Security.Cryptography;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // creates 'Generate Summary' button
            Button btnGenerateSummary = new Button();
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Text = "Generate Summary Report";
            btnGenerateSummary.Location = new Point(10, 560);
            btnGenerateSummary.Size = new Size(200, 35);
            btnGenerateSummary.Font = new Font("Arial", 10, FontStyle.Bold);
            btnGenerateSummary.Click += BtnGenerateSummary_Click;
            this.Controls.Add(btnGenerateSummary);

            // creates 'Summary Display Panel'
            Panel pnlSummary = new Panel();
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Location = new Point(220, 560);
            pnlSummary.Size = new Size(700, 70);
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.BackColor = Color.LightGray;
            this.Controls.Add(pnlSummary);

            // 'Summary Label'
            Label lblSummaryDisplay = new Label();
            lblSummaryDisplay.Name = "lblSummaryDisplay";
            lblSummaryDisplay.Location = new Point(5, 5);
            lblSummaryDisplay.Size = new Size(685, 60);
            lblSummaryDisplay.Font = new Font("Arial", 9);
            lblSummaryDisplay.AutoSize = false;
            pnlSummary.Controls.Add(lblSummaryDisplay);
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

       

    
         
        /// calculates summary statistics from the current animals list.
        /// returns a tuple containing total count, average age, average score, and status counts.
        
        private (int totalAnimals, double avgAge, double avgScore, int critical, int serious, int stable, int recovering, int releaseReady) CalculateSummary()
        {
            int totalAnimals = animals.Count;
            int critical = 0, serious = 0, stable = 0, recovering = 0, releaseReady = 0;
            double avgAge = 0, avgScore = 0;

            if (totalAnimals == 0)
            {
                return (0, 0, 0, 0, 0, 0, 0, 0);
            }

            // calculates the totals and status counts
            foreach (Animal animal in animals)
            {
                avgAge += animal.Age;
                avgScore += animal.RecoveryScore;

                // counts animals by status
                switch (animal.Status)
                {
                    case "Critical":
                        critical++;
                        break;
                    case "Serious":
                        serious++;
                        break;
                    case "Stable":
                        stable++;
                        break;
                    case "Recovering":
                        recovering++;
                        break;
                    case "Release-Ready":
                        releaseReady++;
                        break;
                }
            }

            // calculates averages
            avgAge = avgAge / totalAnimals;
            avgScore = avgScore / totalAnimals;

            return (totalAnimals, avgAge, avgScore, critical, serious, stable, recovering, releaseReady);
        }

        
        /// writes the summary report to summary.txt in the application startup folder.
        /// handles file I/O errors
        
        private void WriteSummaryToFile(int total, double avgAge, double avgScore, int critical, int serious, int stable, int recovering, int releaseReady)
        {
            try
            {
                string filepath = Path.Combine(Application.StartupPath, "summary.txt");
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                // builds summary content
                StringBuilder summaryContent = new StringBuilder();
                summaryContent.AppendLine("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
                summaryContent.AppendLine("ANIMAL SUMMARY REPORT");
                summaryContent.AppendLine($"Generated: {timestamp} ----------------------------------------");
                summaryContent.AppendLine($"Total animals:            {total}");

                // handles empty data cases
                if (total == 0)
                {
                    summaryContent.AppendLine("Average age (years):      N/A");
                    summaryContent.AppendLine("Average recovery score:   N/A");
                }
                else
                {
                    summaryContent.AppendLine($"Average age (years):      {avgAge:F2}");
                    summaryContent.AppendLine($"Average recovery score:   {avgScore:F2}");
                }

                summaryContent.AppendLine("----------------------------------------");
                summaryContent.AppendLine("Animals per status:");
                summaryContent.AppendLine($"Critical:                 {critical}");
                summaryContent.AppendLine($"Serious:                  {serious}");
                summaryContent.AppendLine($"Stable:                   {stable}");
                summaryContent.AppendLine($"Recovering:               {recovering}");
                summaryContent.AppendLine($"Release-Ready:            {releaseReady}");

                // writes to file
                File.WriteAllText(filepath, summaryContent.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show($"File error: {ex.Message}", "Error Writing Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Permission denied: Cannot write to summary.txt", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        /// handles the Generate Summary button click event.
        /// calculates summary data, displays it on the form, and writes to summary.txt.
        
        private void BtnGenerateSummary_Click(object sender, EventArgs e)
        {
            // calculates summary statistics
            var (total, avgAge, avgScore, critical, serious, stable, recovering, releaseReady) = CalculateSummary();

            // gets the label control
            Label? lblSummaryDisplay = this.Controls.Find("lblSummaryDisplay", true).FirstOrDefault() as Label;

            if (lblSummaryDisplay != null)
            {
                // format the display text
                string displayText = $"Total Animals: {total} | " +
                                     $"Avg Age: {(total == 0 ? "N/A" : avgAge.ToString("F2"))} years | " +
                                     $"Avg Score: {(total == 0 ? "N/A" : avgScore.ToString("F2"))} | " +
                                     $"Critical: {critical} | Serious: {serious} | Stable: {stable} | " +
                                     $"Recovering: {recovering} | Release-Ready: {releaseReady}";

                lblSummaryDisplay.Text = displayText;
            }

            // writes to file
            WriteSummaryToFile(total, avgAge, avgScore, critical, serious, stable, recovering, releaseReady);

            // shows confirmation
            MessageBox.Show("Summary report generated and saved to summary.txt", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
