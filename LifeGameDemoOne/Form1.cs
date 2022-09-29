using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGameDemoOne {
    public partial class Form1 : Form {
        int buttonSize = 20;
        int rowNum = 5;
        int colNum = 5;
        LifeGameEngine life = null;
        Button[,] cellButtons = null;
        bool[,] cellValues = null;
        bool isTimerOn = false;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        

        
        Random rand = new Random();
        private int Generator() {
            return rand.Next(0, 2);
        }

        private Button AddNewButton(int x, int y) {
            Button newbutton = new Button();
            /*
            if (Generator() == 0) {
                newbutton.BackColor = Color.Black;
            } else {
                newbutton.BackColor = Color.White;
            }
            */
            newbutton.BackColor = Color.DarkGray;
            newbutton.Text = "";
            newbutton.FlatStyle = FlatStyle.Popup;
            newbutton.FlatAppearance.BorderSize = 0;
            newbutton.Enabled = true;
            newbutton.Location = new Point(x, y);

            newbutton.Size = new Size(buttonSize, buttonSize);
            newbutton.Click += new System.EventHandler(this.btnToggle);
            this.pnCells.Controls.Add(newbutton);
            return newbutton;

        }

        private void btnToggle(object sender, EventArgs e) {
            Button currentBtn = (Button)sender;
            if (currentBtn.BackColor == Color.Crimson) {
                currentBtn.BackColor = Color.DarkGray;
            } else {
                currentBtn.BackColor = Color.Crimson;
            }
            ConvertBtnArrayToBoolArray();
        }

        private void btnStart_Clicked(object sender, EventArgs e) {
            GenerateUniverse();
        }

        private void GenerateUniverse() {
            this.pnCells.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            pnCells.Controls.Clear();
            rowNum = (int)nudRowNum.Value;
            colNum = (int)nudColNum.Value;
            cellButtons = new Button[rowNum, colNum];
            for (int iRow = 0; iRow < rowNum; iRow++) {
                for (int iCol = 0; iCol < colNum; iCol++) {
                    Button newbutton = AddNewButton(
                        iCol * buttonSize,
                        iRow * buttonSize);
                    cellButtons[iRow, iCol] = newbutton;
                }
            }

            this.pnCells.Size = new Size(colNum * buttonSize,
                rowNum * buttonSize);
            //get new form height
            int tempY = pnCells.Location.Y + pnCells.Height + 30;

            //get new form width
            int tempX = Math.Max(pnMenu.Width + pnMenu.Location.X,
                pnCells.Width + pnCells.Location.X);
            this.Size = new Size(tempX + 30, tempY + 30);
            //multidimensional array GetLength(0), row nums, GetLength(1), column nums

            this.pnMenu.ResumeLayout(false);
            this.pnCells.ResumeLayout(false);
            this.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pnCells.PerformLayout();
            this.PerformLayout();
        }

        private void ConvertBtnArrayToBoolArray() {
            cellValues = new bool[rowNum, colNum];
            for(int i = 0; i < cellButtons.GetLength(0); i++) {
                for(int j = 0; j < cellButtons.GetLength(1); j++) {
                    cellValues[i, j] = (cellButtons[i, j].BackColor == Color.Crimson);
                }
            }
            /*
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < cellButtons.GetLength(0); i++) {
                for (int j = 0; j < cellButtons.GetLength(1); j++) {
                    Console.Write(cellValues[i, j] ? "X" : ".");
                }
                Console.WriteLine();
            }
            */
           
        }

        private void btnInitLife_Click(object sender, EventArgs e) {
            if (cellValues== null) {
                MessageBox.Show("YOU must first generate your universe!\n" +
                    "And you must set at least one cell as alive!");
                return;
            }
            life = new LifeGameEngine(cellValues);
        }
        
        private void btnCalcNextGen_Click(object sender, EventArgs e) {
            CalculateNextGeneration();
        }

        private void CalculateNextGeneration() {
            if (cellValues == null || life == null) {
                MessageBox.Show("You must first generate your universe!\n" +
                    "And you must set at least one cell as alive!");
                return;
            }

            life.CalculateNextGeneration();
            RenderButtonsFromLifeCells();
        }

        private void RenderButtonsFromLifeCells() {
            for (int i = 0; i < cellButtons.GetLength(0); i++) {
                for (int j = 0; j < cellButtons.GetLength(1); j++) {
                    if (life.Cells[i, j]) {
                        cellButtons[i, j].BackColor = Color.Crimson;
                    } else {
                        cellButtons[i, j].BackColor = Color.DarkGray;

                    }
                }
            }
        }

        private void tmNextGen_Tick(object sender, EventArgs e) {
            if (!isTimerOn) return;
            CalculateNextGeneration();
        }

        private void btnStartTimer_Click(object sender, EventArgs e) {
            if (!isTimerOn) {
                tmNextGen.Enabled = true;
                tmNextGen.Start();
                btnStartTimer.Text = "Stop Run";
                isTimerOn = true;
            } else {
                tmNextGen.Stop();
                tmNextGen.Enabled = false;
                btnStartTimer.Text = "Auto Run";
                isTimerOn = false;
            }
        }

        private void tbInterval_ValueChanged(object sender, EventArgs e) {
            tmNextGen.Interval = tbInterval.Value;
        }

        private void btSave_Click(object sender, EventArgs e) {
            sfgSave.ShowDialog();
        }

        private void sfgSave_FileOk(object sender, CancelEventArgs e) {
            string path = sfgSave.FileName;
            life.SaveToFile(path);
        }

        private void btLoad_Click(object sender, EventArgs e) {
            ofdLoad.ShowDialog();
        }

        private void ofdLoad_FileOk(object sender, CancelEventArgs e) {
            string path = ofdLoad.FileName;
            life = new LifeGameEngine(path);
            nudRowNum.Value = life.RowNum;
            nudColNum.Value = life.ColNum;
            GenerateUniverse();
            ConvertBtnArrayToBoolArray();
            RenderButtonsFromLifeCells();
        }

    }
}
