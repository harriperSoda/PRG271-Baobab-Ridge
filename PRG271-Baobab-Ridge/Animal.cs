using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Baobab_Ridge
{
    internal class Animal
    {

        //declaring object propeties and using getters and setters for encapsulation
        //need to review how they are used in the code - would want to make AnimalId private***

        public string AnimalId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; }
        public string HousingUnit { get; set; }


        //Constructor
        public Animal(string animalID, string name, string species, int age, int recoveryScore, string status, string housingUnit)
        {
            this.AnimalId = animalID;
            this.Name = name;
            this.Species = species;
            this.Age = age;
            this.RecoveryScore = recoveryScore;
            this.Status = status;
            this.HousingUnit = housingUnit;
        }
    }
}
