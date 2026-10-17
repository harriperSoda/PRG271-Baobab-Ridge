using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Baobab_Ridge
{
    public partial class Form1
    {
        //deletes the selected animal after the user confirms, removes it from animals.txt, refreshed the grid, and leaves edit mode if that animal was being edited
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an animal to delete");
                return;
            }

            Animal? selected = dgvAnimals.SelectedRows[0].DataBoundItem as Animal;
            if (selected == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete "  + selected.AnimalId + " - " + selected.Name +
                " This cannot be undone."
                 + "?", "Confirm Delete", MessageBoxButtons.YesNo);

            //no: nothing changes
            if (result == DialogResult.No)
            {
                return;
            }

            //remove records from animals.txt
            try
            {
                DataHandler.DeleteAnimal(AnimalsFilePath, selected.AnimalId);
            }

            catch (IOException)
            {
                MessageBox.Show("animals.txt cannot be written, it may be open in another program");
                return;
            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to change animals.txt");
                return;
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Could not delete animal: " + ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            //remove animal from animals list
            animals.Remove(selected);

            RefreshGrid();

            //if animal was being edited, clear the form and return to add mode
            if(editingAnimal !=null && editingAnimal.AnimalId == selected.AnimalId)
            {
                ExitEditMode();
            }


        



        }
    }
}
