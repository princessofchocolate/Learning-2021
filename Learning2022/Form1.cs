using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning2022 {
    public partial class Form1 : Form {

        private Learning2022.Forms.BubbleSortForm bsfForm = new Forms.BubbleSortForm();
        public Form1() {
            InitializeComponent();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e) {
            bsfForm.ShowDialog();
        }
    }
}
