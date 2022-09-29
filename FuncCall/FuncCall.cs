using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncCall {
    public class FuncCall {
        int x = 0;

        public void Call() {
            Console.WriteLine("Call:" + x);
            Increment(x);
            Console.WriteLine("Call:" + x);

        }

        public void Increment(int x) {
            x++;

        }
    }
}
