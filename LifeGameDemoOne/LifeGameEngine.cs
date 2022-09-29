using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LifeGameDemoOne {
    /// <summary>
    /// Conway's Game Of Life
    /// Ref: https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life
    /// Rules:
    /// 1. Any live cell with two or three live neighbours survives.
    /// 2. Any dead cell with three live neighbours becomes a live cell.
    /// 3. All other live cells die in the next generation.
    ///    Similarly, all other dead cells stay dead.
    /// </summary>
    public class LifeGameEngine {
        private bool[,] cells = null;
        private bool[,] initialState = null;
        public bool[,] Cells {
            get { return cells; }
        }
        private bool[,] nextGeneration = null;
        private int rowNum, colNum;
        public int RowNum { get { return rowNum; } }
        public int ColNum { get { return colNum; } }

        public LifeGameEngine(bool[,] cells) {
            initByBoolArray(cells);

        }

        private void initByBoolArray(bool[,] cells) {
            //makes deep copy, but only because we have value-typed array.
            //copy by ref -- shallow copy
            //copy by val -- deep copy
            this.cells = cells.Clone() as bool[,];
            this.initialState = cells.Clone() as bool[,];

            rowNum = this.cells.GetLength(0);
            colNum = this.cells.GetLength(1);
            this.nextGeneration = new bool[rowNum, colNum];
        }

        public LifeGameEngine(string path) {
            if (!File.Exists(path)) {
                throw new FileNotFoundException();
            }
            string[] lines = File.ReadAllLines(path);

            int rNum = lines.Length;
            int cNum = 0;
            foreach(string line in lines) {
                if (cNum < line.Length) {
                    cNum = line.Length;
                }
            }
            bool[,] temp = new bool[rNum, cNum];
            for(int i = 0; i < lines.Length; i++) {
                string line = lines[i];
                for(int j = 0; j < line.Length; j++) {
                    bool v = false;
                    if(line[j] == 'X') {
                        v = true;
                    } else {
                        v = false;
                    }
                    temp[i, j] = v;

                    //similar to: temp[i, j] = (line[j] == 'X');
                }
            }
            initByBoolArray(temp);
        }

        public void CalculateNextGeneration() {
            for (int i = 0; i < rowNum; i++) {
                for (int j = 0; j < colNum; j++) {
                    nextGeneration[i, j] = false;
                }
            }
            for (int i = 0; i < rowNum; i++) {
                for (int j = 0; j < colNum; j++) {
                    int count = GetSurroundingPopulation(i, j);
                    if (cells[i, j] && (count == 2 || count == 3)) {
                        nextGeneration[i, j] = true;
                    } else if (!cells[i, j] && count == 3) {
                        nextGeneration[i, j] = true;
                    } else {
                        nextGeneration[i, j] = false;
                    }

                }
            }

            for (int i = 0; i < rowNum; i++) {
                for (int j = 0; j < colNum; j++) {
                    cells[i,j] = nextGeneration[i, j];
                }
            }
        }
        private int GetSurroundingPopulation(int i, int j) {
            ///
            ///[i-1,j-1]   [i-1,j]    [i-1,j+1]
            ///[i,j-1]     [i, j]     [i,j+1]
            ///[i+1,j-1]   [i+1, j]   [i+1,j+1]
            int count = 0;
            if (i - 1 != -1 && j - 1 != -1 && cells[i - 1, j - 1]) {
                count++;
            }//
            if (i - 1 != -1 && cells[i - 1, j]) {
                count++;

            }//
            if (i - 1 != -1 && j +1 != colNum && cells[i - 1, j + 1]) {
                count++;
            }//
            if ( j - 1 != -1 && cells[i, j - 1]) {
                count++;
            }//
            if (j + 1 != colNum && cells[i , j + 1]) {
                count++;
            }//
            if (i + 1 != rowNum && j - 1 != -1 && cells[i + 1, j - 1]) {
                count++;
            }//
            if (i + 1 != rowNum && cells[i + 1, j]) {
                count++;
            }
            if (i + 1 != rowNum && j + 1 != colNum && cells[i + 1, j + 1]) {
                count++;
            }
            return count;
        }
        

        private string ConvertInitToString() {
            string result = "";
            for (int i = 0; i < rowNum; i++) {
                for (int j = 0; j < colNum; j++) {
                    if (initialState[i, j] == true) {
                        result += "X";
                    } else {
                        result += "-";
                    }
                }
                result += Environment.NewLine;
            }
            return result;
        }

        public void SaveToFile(string path) {
            string result = ConvertInitToString();
            File.WriteAllText(path ,result);
        }

        
    }
}
