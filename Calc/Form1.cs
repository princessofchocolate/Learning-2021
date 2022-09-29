using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string previousOperand = "";
        bool isOperatorPressed = false;
        string waitingOperation = "";
        private void ProcessTheKey(string key) {
            if (textBox1.Text == "Error")
                textBox1.Text = "0";
            if (key == "." && textBox1.Text.Contains(".")) return;
            if (isOperatorPressed) {
                isOperatorPressed = false;
                textBox1.Text = key;
                return;
            }
            if (textBox1.Text == "0" && key == "0") {
                return;
            }

            if (textBox1.Text == "0") {
                if (key == ".") {
                    textBox1.Text = textBox1.Text + key;
                } else {
                    textBox1.Text = key;
                }
            } else {
                textBox1.Text = textBox1.Text + key;
            }
        }
        private void button1_Click(object sender, EventArgs e) {
            ProcessTheKey("1");
        }

        private void button2_Click(object sender, EventArgs e) {
            ProcessTheKey("2");

        }

        private void button3_Click(object sender, EventArgs e) {
            ProcessTheKey("3");
        }

        private void button5_Click(object sender, EventArgs e) {
            ProcessTheKey("4");
        }

        private void button6_Click(object sender, EventArgs e) {
            ProcessTheKey("5");
        }

        private void button7_Click(object sender, EventArgs e) {
            ProcessTheKey("6");
        }

        private void button9_Click(object sender, EventArgs e) {
            ProcessTheKey("7");
        }

        private void button10_Click(object sender, EventArgs e) {
            ProcessTheKey("8");
        }

        private void button11_Click(object sender, EventArgs e) {
            ProcessTheKey("9");
        }

        private void button13_Click(object sender, EventArgs e) {
            ProcessTheKey("0");
        }

        private void button15_Click(object sender, EventArgs e) {
            ProcessTheKey(".");
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            previousOperand = textBox1.Text;
            isOperatorPressed = true;
            waitingOperation = "+";
        }

        private void button17_Click(object sender, EventArgs e) {
            if (waitingOperation == "") return;
            decimal op1 = Convert.ToDecimal(previousOperand);
            decimal op2 = Convert.ToDecimal(textBox1.Text);
            decimal result = 0;
            if (waitingOperation == "+") {
                result = op1 + op2;

            } else if (waitingOperation == "-") {
                result = op1 - op2;
            } else if (waitingOperation == "/") {
                try {
                    result = op1 / op2;
                }catch (DivideByZeroException ex) {
                    previousOperand = "";
                    isOperatorPressed = false;
                    waitingOperation = "";
                    textBox1.Text = "Error";
                    return;
                }
            } else if (waitingOperation == "*") {
                result = op1 * op2;
            }
            textBox1.Text = Convert.ToString(result);
        }

        private void button8_Click(object sender, EventArgs e) {
            previousOperand = textBox1.Text;
            isOperatorPressed = true;
            waitingOperation = "-";
        }

        private void buttonDivide_Click(object sender, EventArgs e) {
            previousOperand = textBox1.Text;
            isOperatorPressed = true;
            waitingOperation = "/";
        }

        private void buttonMultiply_Click(object sender, EventArgs e) {
            previousOperand = textBox1.Text;
            isOperatorPressed = true;
            waitingOperation = "*";
        }

        private void button14_Click(object sender, EventArgs e) {
            previousOperand = "";
            isOperatorPressed = false;
            waitingOperation = "";
            textBox1.Text = "0";
        }
    }
}
