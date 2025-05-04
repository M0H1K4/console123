using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console123
{
    internal class Animal
    {
        string animalName;
        int animalAmount;

        public void CreateAnimal(string _animalName, int _animalAmount)
        {
            this.animalName = _animalName; 
            this.animalAmount = _animalAmount;
        }

        public void GetAnimalInfo()
        {
            Console.WriteLine($"animal name is {this.animalName}, animal count is {this.animalAmount}");
        }
    }
}
