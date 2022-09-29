using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive {
    public class Fibonacci {
        public int F(int n) {
            if (n == 0 || n == 1) {
                return n;
            }
            
            return F(n - 1) + F(n - 2);
        }
    }
}
