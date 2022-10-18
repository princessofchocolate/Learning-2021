using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning2022.Forms {
    public partial class BubbleSortForm : Form {

        private Classes.BubbleSort bubbleSort = null;
        public BubbleSortForm() {
            InitializeComponent();
        }

        private void BubbleSortForm_Load(object sender, EventArgs e) {
            int[] data = {9,8,7,6,5,4,3,2,1,0};
            bubbleSort = new Classes.BubbleSort(data);
            bubbleSort.Print();
            //bubbleSort.Modify(1,5);
            //bubbleSort.MultiModify();
            bubbleSort.Sort();
            bubbleSort.Print();

        }
    }
}
