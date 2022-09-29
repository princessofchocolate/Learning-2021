using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDeleteKeyInput {
    public class GameManager {

        private bool shouldExit = false;
        private enum ValidInputs { W, A, S, D, Esc }

        private GameObject[] gameObjects = new GameObject[20];
        
        public GameObject[] GameObjects {

            get {
                return this.gameObjects;
            }
        }

        private GameBoard board = new GameBoard(new Point(1, 1), new Point(30, 30));
        
        public GameBoard Board {
            get {
                return this.board;
            }
        } 
        GameItem player = new GameItem(new Point(6,6));
        

        public GameManager() {
            player.ScoreLineNum = board.EndPoint.Y + 2;
            gameObjects[0] = board;
            gameObjects[1] = player;
            gameObjects[2] = new CollectableItem(new Point(9, 9));
            gameObjects[3] = new CollectableItem(new Point(9, 15));
            gameObjects[4] = new CollectableItem(new Point(16, 20));
            gameObjects[5] = new CollectableItem(new Point(3, 3));
            gameObjects[6] = new CollectableItem(new Point(25, 2));
        }
        public void Execute() {
            
            renderScreen();
            ConsoleKey ck = Console.ReadKey(true).Key;

            while (ck != ConsoleKey.Escape) {
                
                if (ck == ConsoleKey.W) {
                    processInput(ValidInputs.W);
                } else if (ck == ConsoleKey.A) {
                    processInput(ValidInputs.A);
                } else if (ck == ConsoleKey.S) {
                    processInput(ValidInputs.S);
                } else if (ck == ConsoleKey.D) {
                    processInput(ValidInputs.D);
                } else if (ck == ConsoleKey.Escape) {
                    break;
                }
                if (shouldExit) {
                    return;
                }

                ck = Console.ReadKey(true).Key;
            }
        }

        private void processInput(ValidInputs vi) {
            if (vi == ValidInputs.W) PressedW();
            else if (vi == ValidInputs.A) PressedA();
            else if (vi == ValidInputs.S) PressedS();
            else if (vi == ValidInputs.D) PressedD();

            renderScreen();
        }

        public void RemoveFromGame(CollectableItem ci) {
            for (int i = 0; i < gameObjects.Length; i++) {
                if (ci == gameObjects[i]) {
                    gameObjects[i] = null;
                }
            }

            int ciCount = 0;
            foreach(GameObject go in gameObjects) {
                if(go!= null && go is CollectableItem) {
                    ciCount++;
                }
            }
            if (ciCount == 0) {
                Console.Clear();
                Console.WriteLine($"*** YOU WON *** \n\n  with {player.MoveCount} moves.\n\n\n");
                Console.WriteLine("press enter to exit");
                Console.ReadLine();
                shouldExit = true;
            }
        }

        private void PressedW() {
            player.MoveUp(this);
        }

        private void PressedA() {
            player.MoveLeft(this);
        }

        private void PressedS() {
            player.MoveDown(this);
        }

        private void PressedD() {
            player.MoveRight(this);
        }
        private void renderScreen() {
            Console.Clear();
            
            foreach(GameObject go in gameObjects) {
                if (go == null) continue;
                go.Render();
            }
            
        }
             
        
    }
}
