using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentNeeds {
    class Program {

        
        static void Main(string[] args) {
            Program p = new Program();
            p.ExecuteFirstClass();
            //p.Test();
        }

        private void ExecuteFirstClass() {
            int[] exp = { 100, 200, 300 };
            int[] earn = { 500, 300, 100 };

            int chick = 70;
            int cats = 80;
            int[] speeds = { 120, 200, 240, 100 };

            FinancialStatus fsMinnos = new FinancialStatus(exp, earn);

            fsMinnos.calculateAndPrint();

            Barn barn = new Barn(cats, chick);
            barn.calculateAndPrint();

            Console.ReadLine();
        }

        public void Test() { }

    }
}
