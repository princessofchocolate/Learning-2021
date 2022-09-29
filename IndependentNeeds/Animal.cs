using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentNeeds {
    public class Animal {
        int legCount;
        int animalCount;
        int totalLegCount;
        string name;

        public Animal(string name, int legCount, int animalCount) {
            this.name = name;
            this.legCount = legCount;
            this.animalCount = animalCount;
        }

        public int calculateAndPrint() {
            calculate();
            print();
            return totalLegCount;
        }

        private void calculate() {
            totalLegCount = legCount * animalCount;
        }

        private void print() {
            Console.WriteLine("{0} Leg Count: {1}", name, totalLegCount);
        }


    }
}
