using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAnimalShelter {
    class Program {
        static void Main(string[] args) {

            AnimalShelter shelter = new AnimalShelter();
            shelter.FillShelter();
            shelter.Print();

            Console.ReadLine();
        }
    }
}
