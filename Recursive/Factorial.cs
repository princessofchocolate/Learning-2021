using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive {
    public class Factorial {

        public int F(int n) {
            if (n == 1) {
                return 1;
            }
            int result = n * F(n - 1);
            return result;
        }
    }
}
