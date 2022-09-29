
namespace FileOps {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btWriteFile = new System.Windows.Forms.Button();
            this.btReadFile = new System.Windows.Forms.Button();
            this.ofgInputFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btWriteFile
            // 
            this.btWriteFile.Location = new System.Drawing.Point(12, 12);
            this.btWriteFile.Name = "btWriteFile";
            this.btWriteFile.Size = new System.Drawing.Size(75, 57);
            this.btWriteFile.TabIndex = 0;
            this.btWriteFile.Text = "Write File";
            this.btWriteFile.UseVisualStyleBackColor = true;
            this.btWriteFile.Click += new System.EventHandler(this.btWriteFile_Click);
            // 
            // btReadFile
            // 
            this.btReadFile.Location = new System.Drawing.Point(120, 12);
            this.btReadFile.Name = "btReadFile";
            this.btReadFile.Size = new System.Drawing.Size(75, 57);
            this.btReadFile.TabIndex = 1;
            this.btReadFile.Text = "Read File";
            this.btReadFile.UseVisualStyleBackColor = true;
            this.btReadFile.Click += new System.EventHandler(this.btReadFile_Click);
            // 
            // ofgInputFile
            // 
            this.ofgInputFile.FileName = "openFileDialog1";
            this.ofgInputFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofgInputFile_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReadFile);
            this.Controls.Add(this.btWriteFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btWriteFile;
        private System.Windows.Forms.Button btReadFile;
        private System.Windows.Forms.OpenFileDialog ofgInputFile;
    }
}

