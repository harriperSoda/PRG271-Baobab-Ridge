using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Baobab_Ridge
{
    internal class DataHandler
    {

        public static void DeleteAnimal(string filePath, string animalId)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<string> newList = new List<string>();
            bool removed = false;

            foreach(string line in lines)
            {
                string[] items = line.Split('|');

                if (!removed && items.Length > 0 && string.Equals(items[0].Trim(), animalId.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    removed = true;
                    continue;
                }

                newList.Add(line);
            }

            if (!removed)
            {
                throw new InvalidOperationException($"Animal with ID{animalId} was not found");
            }

            File.WriteAllLines(filePath, newList);
        }


    }
}
