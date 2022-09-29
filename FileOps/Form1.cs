using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileOps {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btWriteFile_Click(object sender, EventArgs e) {
            StreamWriter fs = null;
            try {
                fs = new StreamWriter("abc.txt", append: true);
                fs.Write("hello world2" + Environment.NewLine);
                fs.Flush();
            } catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                if(fs != null) fs.Close();
            }
        }


        private void btReadFile_Click(object sender, EventArgs e) {
            ofgInputFile.InitialDirectory = Application.StartupPath;
            ofgInputFile.ShowDialog();
            
        }

        private void ofgInputFile_FileOk(object sender, CancelEventArgs e) {
            if (!File.Exists(ofgInputFile.FileName)) {
                MessageBox.Show("File not found");
                return;
            }
            foreach (string s in File.ReadLines(ofgInputFile.FileName)) {
                Console.WriteLine(s);
            }
        }
    }
}
