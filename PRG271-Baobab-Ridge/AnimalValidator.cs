using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Baobab_Ridge
{
    internal static class AnimalValidator //Thhis class will handle all validation regarding the Animal class and its properties
    //used static as we will not be instantianting this class - its used as a utility class. This means we dont need to create an object of this class to use its methods - we can call them directly using the class name. We will never need to instante it, so we just leave it as static
    {
        public static bool ValidateAnimalIdFormat( string idInput, out string animalId, out string errorMessage) // "out" is for us to return the cleaned up ID. Works with below line
        {
            //trim spaces and convert to uppercase
            animalId = idInput.Trim().ToUpper(); //assign animal id (which is sent back) to the idInput we recieved
            //***POTENTIAL BUG: Trimming a null will cause an error. However im not sure if this will occur with textbox input. We will need to test this. If it does occur, we can use a null conditional operator to check for null before trimming. This is a potential bug that may need to be fixed in the future. For now, we will leave it as is and test it later. Will need to be appliaed in below mwthods too

            //check if the animalId is null or empty. First check
            if (string.IsNullOrWhiteSpace(animalId))
            {
                errorMessage = "Animal ID cannot be empty.";
                return false;
            }

            //Check if its 7 characters long
            if(animalId.Length != 7)
            {
                errorMessage = "Animal ID must be 7 characters long.";
                return false;
            }

            //Check if it starts with 'WR-'
            if (!animalId.StartsWith("WR-"))
            {
                errorMessage = "Animal ID must start with 'WR-'.";
                return false;
            }

            //check if the last 3 characters are digits - first need a substring of the last 3 characters

            string numberPart = animalId.Substring(3);

            if(!numberPart.All(char.IsDigit)) //check if all characters in the numberPart are digits
            {
                errorMessage = "Animal ID must end with 4 digits.";
                return false;
            }
            errorMessage = string.Empty; //if all checks pass, set errorMessage to empty
            return true; //if all checks pass, return true


        }

        public static bool ValidateAnimalName(string nameInput, out string animalName, out string errorMessage)
        {
            //trim spaces
            animalName = nameInput.Trim();

            //check is null or empty
            if (string.IsNullOrWhiteSpace(animalName))
            {
                errorMessage = "Animal name cannot be empty.";
                return false;
            }

            //check length
            if(animalName.Length > 30)
            {
                errorMessage = "Animal name cannot be longer than 30 characters.";
                return false;
            }

            //check for |
            if (animalName.Contains("|"))
            {
                errorMessage = "Animal name cannot contain the '|' character.";
                return false;
            }
            errorMessage = string.Empty; //if all checks pass, set errorMessage to empty
            return true;

        }

        public static bool ValidateAnimalSpecies(string speciesInput, out string animalSpecies, out string errorMessage)
        {
            animalSpecies = speciesInput.Trim();

            if (string.IsNullOrWhiteSpace(animalSpecies))
            {
                errorMessage = "Animal species cannot be empty.";
                return false;
            }

            if(animalSpecies.Contains("|"))
            {
                errorMessage = "Animal species cannot contain the '|' character.";
                return false;
            }

            if(animalSpecies.Length > 30)
            {
                errorMessage = "Animal species cannot be longer than 30 characters.";
                return false;
            }
            errorMessage = string.Empty; //if all checks pass, set errorMessage to empty
            return true;
        }

        public static bool ValidateAnimalAge(string ageInput, out int animalAge, out string errorMessage) //Recieving data will come in the form of a string as its a text box. We will need to convert.
        {
            if(!int.TryParse(ageInput, out animalAge))
            {
                errorMessage = "Animal age must be a valid integer.";
                return false;
            }

            if(animalAge < 0 || animalAge > 100)
            {
                errorMessage = "Animal age must be between 0 and 100.";
                return false;
            }
            errorMessage = string.Empty; //if all checks pass, set errorMessage to empty
            return true;

        }

        public static bool ValidateRecoveryScore(string scoreInput, out int recoveryScore, out string errorMessage)
        {
            if(!int.TryParse(scoreInput, out recoveryScore))
            {
                errorMessage = "Recovery score must be a valid integer.";
                return false;
            }

            if(recoveryScore < 0 || recoveryScore > 100)
            {
                errorMessage = "Recovery score must be between 0 and 100.";
                return false;
            }
            errorMessage = string.Empty; //if all checks pass, set errorMessage to empty
            return true;
        }

    }
}
