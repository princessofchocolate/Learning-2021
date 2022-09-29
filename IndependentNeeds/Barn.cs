using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentNeeds {
    public class Barn {
        Animal cat, chicken;
        int totalLegCount;
        public Barn(int catCount, int chickenCount) {
            cat = new Animal("Cat", 4, catCount);
            chicken = new Animal("Chicken", 2, chickenCount);
        }

        public void calculateAndPrint() {
            int cL = cat.calculateAndPrint();
            int chL = chicken.calculateAndPrint();
            totalLegCount = cL + chL;

        }

        private void print() {
            Console.WriteLine("Total Leg Count: {0}", totalLegCount);
        }
    }
}
