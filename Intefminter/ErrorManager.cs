using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intefminter {
    public class ErrorManager {

        public int divide(int a, int b) {
            try {
                return a / b;
            } catch (ArgumentOutOfRangeException ex2) {
                Console.WriteLine("Opps");
            } finally {

            }
            return 0;
        }
    }
}
