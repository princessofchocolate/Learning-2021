using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphicManager {
    public class GraphicalObject {

        public virtual void Print() {
            Console.WriteLine("You should've instantiate a meaningful object");
        }
    }
}
