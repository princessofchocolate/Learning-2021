using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intefminter {
    public class Program {
        static void Main(string[] args) {
            ErrorManager em = new ErrorManager();
            int r=0;
            try {
                r = em.divide(4, 0);
            } catch (NullReferenceException ex) {
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
