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
        public static bool ValidateAnimalIdFormat( string idInput, out string animalId) // "out" is for us to return the cleaned up ID. Works with below line
        {
            //trim spaces and convert to uppercase
            animalId = idInput.Trim().ToUpper(); //assign animal id (which is sent back) to the idInput we recieved

            //check if the animalId is null or empty. First check
            if (string.IsNullOrWhiteSpace(animalId))
            {
                return false;
            }

            //Check if its 7 characters long
            if(animalId.Length != 7)
            {
                return false;
            }

            //Check if it starts with 'WR-'
            if (!animalId.StartsWith("WR-"))
            {
                return false;
            }

            //check if the last 3 characters are digits - first need a substring of the last 3 characters

            string lastThreeChars = animalId.Substring(3);

            if(!int.TryParse(lastThreeChars, out _)) //atteempt to parse. We dont need the output
            {
                return false;
            }
            return true; //if all checks pass, return true


        }

        public static bool ValidateAnimalName(string nameInput, out string animalName)
        {
            //trim spaces
            animalName = nameInput.Trim();

            //check is null or empty
            if (string.IsNullOrWhiteSpace(animalName))
            {
                return false;
            }

            //check length
            if(animalName.Length > 30)
            {
                return false;
            }

            //check for |
            if (animalName.Contains("|"))
            {
                return false;
            }
            return true;

        }

        public static bool ValidateAnimalSpecies(string speciesInput, out string animalSpecies)
        {
            animalSpecies = speciesInput.Trim();

            if (string.IsNullOrWhiteSpace(animalSpecies))
            {
                return false;
            }

            if(animalSpecies.Contains("|"))
            {
                return false;
            }

            if(animalSpecies.Length > 30)
            {
                return false;
            }
            return true;
        }

        public static bool ValidateAnimalAge(string ageInput, out int animalAge) //Recieving data will come in the form of a string as its a text box. We will need to convert.
        {
            if(!int.TryParse(ageInput, out animalAge))
            {
                return false;
            }

            if(animalAge < 0 || animalAge > 100)
            {
                return false;
            }

            return true;

        }

        public static bool ValidateRecoveryScore(string scoreInput, out int recoveryScore)
        {
            if(!int.TryParse(scoreInput, out recoveryScore))
            {
                return false;
            }

            if(recoveryScore < 0 || recoveryScore > 100)
            {
                return false;
            }
            return true;
        }

    }
}
