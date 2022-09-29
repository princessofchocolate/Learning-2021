using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphicManager {
    class Program {
        static void Main(string[] args) {
            GraphicalObject[] graphicalObjects = new GraphicalObject[10];
            Point p1 = new Point(0.5f, 0.0f);
            Line l1 = new Line(2.0f, -1.0f);

            graphicalObjects[0] = p1;
            graphicalObjects[1] = l1;
            for(int i=0; i<graphicalObjects.Length; i++) {
                if (graphicalObjects[i] == null) continue;
                graphicalObjects[i].Print();
            }

            bool isInLine = l1.CheckPoint(p1);
            Console.WriteLine(isInLine);
            Console.ReadLine();
        }
    }
}
