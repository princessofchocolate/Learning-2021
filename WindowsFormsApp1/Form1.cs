using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {

        
        public Form1() {
            InitializeComponent();
        }
        string[] messages = { "Ouch!", "Enough!", "Stop!", 
            "Help", "For God's Sake!", "C'moooon...",
            "This's childish!", "Mummmmmyyyyy"};
        private void button1_Click(object sender, EventArgs e) {
            //string[] newArray = Array.Sort<string>(messages);

            Random random = new Random();
            int index = random.Next(0, messages.Length);
            int maxX = this.Width - button1.Width-10;
            int maxY = this.Height - button1.Height-10;
            int newX = random.Next(10, maxX);
            int newY = random.Next(10, maxY);
            button1.Text = messages[index];
            button1.Location = new Point(newX, newY);
        }

        private void button1_MouseEnter(object sender, EventArgs e) {

        }

        private void button1_TextChanged(object sender, EventArgs e) {

        }

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e) {
            button1.Text = cbCities.SelectedItem.ToString();
        }
    }
}
