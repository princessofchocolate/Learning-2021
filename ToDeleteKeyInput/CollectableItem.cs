using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDeleteKeyInput {
    public class CollectableItem:GameObject {
        public string Text { get; private set; }
        public Point Coordinate { get; set; }

        public CollectableItem(string text, Point coordinate) {
            this.Text = text;
            this.Coordinate = coordinate;
        }

        public CollectableItem(Point coordinate) {
            this.Text = "+";
            this.Coordinate = coordinate;
        }
        public void Render() {
            Console.SetCursorPosition(this.Coordinate.X, this.Coordinate.Y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorVisible = false;
            Console.Write(this.Text);
        }
    }
}
