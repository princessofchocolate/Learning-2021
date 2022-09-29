using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCalculation {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int count = 0;

        private void CalculateMeans() {
            decimal r = input1.Value + input2.Value;
            decimal result = r / 2;
            ort1.Text = result.ToString();
            decimal r2 = input1.Value + input3.Value;
            decimal result2 = r2 / 2;
            ort3.Text = result2.ToString();
            decimal r3 = input2.Value + input3.Value;
            decimal result3 = r3 / 2;
            ort2.Text = result3.ToString();
            decimal r4 = input1.Value + input2.Value + input3.Value;
            decimal result4 = r4 / 3;
            ort4.Text = result4.ToString();
            decimal result5 = (result + result3) / 2;
            ort5.Text = result5.ToString();
            decimal result6 = (result3 + result3) / 2;
            ort6.Text = result6.ToString();
            decimal result7 = (result5 + result6) / 2;
            ort7.Text = result7.ToString();
            lbCount.Text = (++count).ToString();
        }
        private void input1_ValueChanged(object sender, EventArgs e) {
            CalculateMeans();
            
        }

        private void input2_ValueChanged(object sender, EventArgs e) {
            CalculateMeans();
            
        }

        private void input3_Scroll(object sender, EventArgs e) {
            CalculateMeans();
        }

        private void button1_Click(object sender, EventArgs e) {
            MoveControl mc = new MoveControl();
            mc.Show();
        }

        private void angle_Scroll(object sender, EventArgs e) {
            lbSin.Text = Math.Sin(angle.Value).ToString();
            lbCos.Text = Math.Cos(angle.Value).ToString();
            lbSq.Text = (Math.Sin(angle.Value) * Math.Sin(angle.Value) +
                            Math.Cos(angle.Value) * Math.Cos(angle.Value)).ToString();
        }
    }
}
