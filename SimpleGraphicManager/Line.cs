using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphicManager {
    public class Line:GraphicalObject {
        public float slope;
        public float intercept;

        public Line(float slope, float intercept) {
            this.slope = slope;
            this.intercept = intercept;
        }

        public Line(Point p1, Point p2) {
            //TODO:calculate slope and intercept for these two points
        }

        public override void Print() {
            Console.WriteLine($"Line y = ({slope})x + ({intercept})");
        }
        public bool CheckPoint(Point p) {
            if (p == null) return false;
            float localY = this.slope * p.x + this.intercept;
            if (p.y==localY) {
                return true;
            } else {
                return false;
            }
        }
    }
}
