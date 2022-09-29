using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDeleteKeyInput {
    public class GameBoard:GameObject {

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public string Text { get; set; }
        public GameBoard(string text, Point startPoint, Point endPoint) {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Text = text;
        }
        public GameBoard(Point startPoint, Point endPoint) {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Text = "#";
        }


        public void Render() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
            Console.SetCursorPosition(this.StartPoint.X, this.StartPoint.Y);
            for(int i = this.StartPoint.X; i <= this.EndPoint.X; i++) {
                Console.Write(this.Text);
                Console.SetCursorPosition(i, this.StartPoint.Y);
            }

            Console.SetCursorPosition(this.StartPoint.X, this.EndPoint.Y);
            for (int i = this.StartPoint.X; i <= this.EndPoint.X; i++) {
                Console.Write(this.Text);
                Console.SetCursorPosition(i, this.EndPoint.Y);
            }

            Console.SetCursorPosition(this.StartPoint.X, this.StartPoint.Y);
            for (int i = this.StartPoint.Y; i <= this.EndPoint.Y; i++) {
                Console.Write(this.Text);
                Console.SetCursorPosition(this.StartPoint.X, i);
            }

            Console.SetCursorPosition(this.EndPoint.X, this.StartPoint.Y);
            for (int i = this.StartPoint.Y; i <= this.EndPoint.Y; i++) {
                Console.Write(this.Text);
                Console.SetCursorPosition(this.EndPoint.X, i);
            }


            Console.Write(this.Text);
        }
    }
}
