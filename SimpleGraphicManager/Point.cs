using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphicManager {
    public class Point:GraphicalObject {
        public float x;
        public float y;

        public Point(float x, float y) {
            this.x = x;
            this.y = y;
        }

        public override void Print() {
            Console.WriteLine($"Point at ({x}, {y})");
        }
    }
}
