using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        bool turn = true;
        int turnCount = 0;
        
        private void A1_Click(object sender, EventArgs e) {
            Button b = (Button) sender; 
            if (turn) {
                b.Text = "X";
            }else {
                b.Text = "O";
            }
            b.Enabled = false;
            turnCount++;
            CheckVictory();
            turn = !turn;
            
        }
        private void CheckVictory() {
            if (!A1.Enabled && (A1.Text == A2.Text) && (A2.Text == A3.Text)) {
                playerWon();
            }else if (!B1.Enabled && (B1.Text == B2.Text) && (B2.Text == B3.Text)) {
                playerWon();
            }else if (!C1.Enabled && (C1.Text == C2.Text) && (C2.Text == C3.Text)) {
                playerWon();
            }else if (!A1.Enabled && (A1.Text == B1.Text) && (B1.Text == C1.Text)) {
                playerWon();
            } else if (!A2.Enabled && (A2.Text == B2.Text) && (B2.Text == C2.Text)) {
                playerWon();
            } else if (!A3.Enabled && (A3.Text == B3.Text) && (B3.Text == C3.Text)) {
                playerWon();
            } else if (!A1.Enabled && (A1.Text == B2.Text) && (B2.Text == C3.Text)) {
                playerWon();
            } else if (!A3.Enabled && (A3.Text == B2.Text) && (B2.Text == C1.Text)) {
                playerWon();
            } else if(turnCount ==9){
                MessageBox.Show("It's a draw!");
                resetButtons();
            }

        }

        private void playerWon() {
            string player = null;
            if (turn) {
                player = "X";
            } else {
                player = "O";
            }
            MessageBox.Show(player + " wins!");
            resetButtons();
        }

        private void resetButtons() {
            turnCount = 0;
            turn = false;
            foreach (Control c in this.Controls) {
                if (c is Button) {
                    c.Enabled = true;
                    c.Text = "";
                }
            }
        }
    }
}
