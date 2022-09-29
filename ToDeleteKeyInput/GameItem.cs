using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDeleteKeyInput {
    public class GameItem:GameObject {
        public string Text { get; private set; }
        public Point Coordinate { get; set; }

        public int MoveCount { get; private set; }

        public int ScoreLineNum { get; set; }
        
        public GameItem(string text,Point coordinate) {
            this.Text = text;
            this.Coordinate = coordinate;
        }
        public GameItem(Point coordinate) {
            this.Text = "*";
            this.Coordinate = coordinate;
            this.ScoreLineNum = 50;
        }
        public void Render() {
            Console.SetCursorPosition(this.Coordinate.X, this.Coordinate.Y);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.CursorVisible = false;
            Console.Write(this.Text);
            Console.SetCursorPosition(1, this.ScoreLineNum);
            Console.WriteLine($"{this.MoveCount} Moves!");

        }
        public void MoveUp(GameManager gm) {
            IncrementMoveCount();
            if (this.Coordinate.Y > gm.Board.StartPoint.Y + 1) this.Coordinate.Y--;
            ProcessCollusion(gm);

        }

        public void MoveDown(GameManager gm) {
            IncrementMoveCount();
            if (this.Coordinate.Y < gm.Board.EndPoint.Y - 1) this.Coordinate.Y++;
            ProcessCollusion(gm);
        }

        public void MoveLeft(GameManager gm) {
            IncrementMoveCount();
            if (this.Coordinate.X > gm.Board.StartPoint.X + 1) this.Coordinate.X--;
            ProcessCollusion(gm);

        }
        public void MoveRight(GameManager gm) {
            IncrementMoveCount();
            if (this.Coordinate.X < gm.Board.EndPoint.X - 1) this.Coordinate.X++;
            ProcessCollusion(gm);
        }
        private void IncrementMoveCount() {
            this.MoveCount++;
        }
        public void ProcessCollusion(GameManager gm) {
            foreach(GameObject go in gm.GameObjects) {
                if(go != null && go is CollectableItem) {
                    CollectableItem ci = (CollectableItem)go;
                    if ((this.Coordinate.X == ci.Coordinate.X) &&
                        (this.Coordinate.Y == ci.Coordinate.Y)) {
                        gm.RemoveFromGame(ci);

                    }
                }
            }
        }
    }
}
