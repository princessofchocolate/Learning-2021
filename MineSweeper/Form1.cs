using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper {
    public partial class Form1 : Form {
        readonly int GRID_WIDTH = 10;
        readonly int GRID_HEIGHT = 10;
        readonly int MINE_COUNT = 10;
        readonly int CELL_WIDTH = 30;
        readonly int CELL_HEIGHT = 30;
        readonly string MINE_TEXT = "M";

        private Button[,] buttons = null;
        public Form1() {
            InitializeComponent();
            buttons = new Button[GRID_WIDTH, GRID_HEIGHT];
            InitGrid();
        }

        private void InitGrid() {
            AddGridOfButtons();
            AssignMines();
        }
        
        public void AddButton(int i, int j) {
            Button newbutton = new Button();
            newbutton.Text = "";
            newbutton.Width = CELL_WIDTH;
            newbutton.Height = CELL_HEIGHT;
            newbutton.Top = i * CELL_WIDTH;
            newbutton.Left = j * CELL_HEIGHT;
            newbutton.Click += new System.EventHandler(this.CellClicked);
            this.Controls.Add(newbutton);
            buttons[i, j] = newbutton;
        }
        
        public void AddGridOfButtons() {
            for(int i = 0; i< GRID_WIDTH; i++) 
                for(int j = 0; j< GRID_HEIGHT; j++) 
                    AddButton(i,j);
        }
        Random random = new Random();

        private void AssignMines() {
            for (int i = 0; i < MINE_COUNT; i++) {
                
                bool foundEmpty = false;
                while (!foundEmpty) {
                    int x = random.Next(0, GRID_WIDTH);
                    int y = random.Next(0, GRID_HEIGHT);
                    if (buttons[x, y].Text == MINE_TEXT) {
                        continue;
                    } else {
                        buttons[x, y].Text = MINE_TEXT;
                        foundEmpty = true;
                    }
                }
            }
        }
        private void CellClicked(object sender, EventArgs e) {
            Button btn = (Button)sender;

            MessageBox.Show("hello world");
        }

        private void button1_Click(object sender, EventArgs e) {
            for (int i = 0; i < GRID_WIDTH; i++)
                for (int j = 0; j < GRID_HEIGHT; j++) {
                    buttons[i, j].Text = "";
                }
            AssignMines();
        }
    }
}
