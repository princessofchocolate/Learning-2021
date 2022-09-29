using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentNeeds {
    public class FinancialStatus {
        int[] exp;
        int[] earnings;
        int totalProfit;
        int totalExp = 0;
        int totalEarnings = 0;
        
        /// <summary>
        /// Initializes FinancialStatus Object
        /// </summary>
        /// <param name="exp">Array of Expendatures</param>
        /// <param name="earnings">Array of Earnings</param>
        public FinancialStatus(int[] exp, int[] earnings) {
            this.exp = exp;
            this.earnings = earnings;
        }

        /// <summary>
        /// 
        /// </summary>
        public FinancialStatus() {
            this.exp = new int[] { 100, 200, 300 };
            this.earnings = new int[] { 500, 300, 100 };
        }
        public void calculateAndPrint() {
            calculate();
            print();
        }

        private void calculate() {
            
            for(int i = 0; i < exp.Length; i++) {
                totalExp += exp[i];
            }

            
            for (int i = 0; i < earnings.Length; i++) {
                totalEarnings += earnings[i];
            }

            totalProfit = totalEarnings - totalExp;
        }

        private void print() {
            Console.WriteLine("Tot. Ear: {0}, Tot. Exp: {1}, Tot. Profit: {2}", totalEarnings, totalExp, totalProfit);
        }
    }
}
