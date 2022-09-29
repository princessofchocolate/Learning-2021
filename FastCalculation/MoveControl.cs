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
    public partial class MoveControl : Form {
        public MoveControl() {
            InitializeComponent();
        }

        private void MoveControl_KeyPress(object sender, KeyPressEventArgs e) {
            Console.WriteLine("Mello");

            if (e.KeyChar == 's') {
                Console.WriteLine("Hello");
                lb1.Location = new Point(10, 200);
            }
        }
    }
}
