
namespace FastCalculation {
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
            this.input1 = new System.Windows.Forms.NumericUpDown();
            this.input3 = new System.Windows.Forms.TrackBar();
            this.ort1 = new System.Windows.Forms.Label();
            this.ort2 = new System.Windows.Forms.Label();
            this.ort5 = new System.Windows.Forms.Label();
            this.ort4 = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.NumericUpDown();
            this.ort3 = new System.Windows.Forms.Label();
            this.ort6 = new System.Windows.Forms.Label();
            this.ort7 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.angle = new System.Windows.Forms.TrackBar();
            this.lbSin = new System.Windows.Forms.Label();
            this.lbCos = new System.Windows.Forms.Label();
            this.lbSq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(156, 22);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(120, 20);
            this.input1.TabIndex = 0;
            this.input1.ValueChanged += new System.EventHandler(this.input1_ValueChanged);
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(507, 11);
            this.input3.Maximum = 100;
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(184, 42);
            this.input3.TabIndex = 2;
            this.input3.Value = 1;
            this.input3.Scroll += new System.EventHandler(this.input3_Scroll);
            // 
            // ort1
            // 
            this.ort1.AutoSize = true;
            this.ort1.Location = new System.Drawing.Point(295, 111);
            this.ort1.Name = "ort1";
            this.ort1.Size = new System.Drawing.Size(35, 13);
            this.ort1.TabIndex = 3;
            this.ort1.Text = "label1";
            // 
            // ort2
            // 
            this.ort2.AutoSize = true;
            this.ort2.Location = new System.Drawing.Point(504, 111);
            this.ort2.Name = "ort2";
            this.ort2.Size = new System.Drawing.Size(35, 13);
            this.ort2.TabIndex = 4;
            this.ort2.Text = "label2";
            // 
            // ort5
            // 
            this.ort5.AutoSize = true;
            this.ort5.Location = new System.Drawing.Point(397, 170);
            this.ort5.Name = "ort5";
            this.ort5.Size = new System.Drawing.Size(35, 13);
            this.ort5.TabIndex = 5;
            this.ort5.Text = "label3";
            // 
            // ort4
            // 
            this.ort4.Location = new System.Drawing.Point(22, 22);
            this.ort4.Name = "ort4";
            this.ort4.Size = new System.Drawing.Size(116, 20);
            this.ort4.TabIndex = 6;
            this.ort4.Text = "label4";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(343, 22);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(120, 20);
            this.input2.TabIndex = 7;
            this.input2.ValueChanged += new System.EventHandler(this.input2_ValueChanged);
            // 
            // ort3
            // 
            this.ort3.AutoSize = true;
            this.ort3.Location = new System.Drawing.Point(697, 111);
            this.ort3.Name = "ort3";
            this.ort3.Size = new System.Drawing.Size(35, 13);
            this.ort3.TabIndex = 8;
            this.ort3.Text = "label5";
            // 
            // ort6
            // 
            this.ort6.AutoSize = true;
            this.ort6.Location = new System.Drawing.Point(599, 170);
            this.ort6.Name = "ort6";
            this.ort6.Size = new System.Drawing.Size(35, 13);
            this.ort6.TabIndex = 9;
            this.ort6.Text = "label6";
            // 
            // ort7
            // 
            this.ort7.AutoSize = true;
            this.ort7.Location = new System.Drawing.Point(504, 244);
            this.ort7.Name = "ort7";
            this.ort7.Size = new System.Drawing.Size(35, 13);
            this.ort7.TabIndex = 10;
            this.ort7.Text = "label7";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(25, 365);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(13, 13);
            this.lbCount.TabIndex = 11;
            this.lbCount.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(156, 310);
            this.angle.Maximum = 90;
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(104, 42);
            this.angle.TabIndex = 13;
            this.angle.Scroll += new System.EventHandler(this.angle_Scroll);
            // 
            // lbSin
            // 
            this.lbSin.AutoSize = true;
            this.lbSin.Location = new System.Drawing.Point(156, 365);
            this.lbSin.Name = "lbSin";
            this.lbSin.Size = new System.Drawing.Size(35, 13);
            this.lbSin.TabIndex = 14;
            this.lbSin.Text = "label1";
            // 
            // lbCos
            // 
            this.lbCos.AutoSize = true;
            this.lbCos.Location = new System.Drawing.Point(241, 365);
            this.lbCos.Name = "lbCos";
            this.lbCos.Size = new System.Drawing.Size(35, 13);
            this.lbCos.TabIndex = 15;
            this.lbCos.Text = "label2";
            // 
            // lbSq
            // 
            this.lbSq.AutoSize = true;
            this.lbSq.Location = new System.Drawing.Point(184, 399);
            this.lbSq.Name = "lbSq";
            this.lbSq.Size = new System.Drawing.Size(35, 13);
            this.lbSq.TabIndex = 16;
            this.lbSq.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSq);
            this.Controls.Add(this.lbCos);
            this.Controls.Add(this.lbSin);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.ort7);
            this.Controls.Add(this.ort6);
            this.Controls.Add(this.ort3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.ort4);
            this.Controls.Add(this.ort5);
            this.Controls.Add(this.ort2);
            this.Controls.Add(this.ort1);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown input1;
        private System.Windows.Forms.TrackBar input3;
        private System.Windows.Forms.Label ort1;
        private System.Windows.Forms.Label ort2;
        private System.Windows.Forms.Label ort5;
        private System.Windows.Forms.Label ort4;
        private System.Windows.Forms.NumericUpDown input2;
        private System.Windows.Forms.Label ort3;
        private System.Windows.Forms.Label ort6;
        private System.Windows.Forms.Label ort7;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar angle;
        private System.Windows.Forms.Label lbSin;
        private System.Windows.Forms.Label lbCos;
        private System.Windows.Forms.Label lbSq;
    }
}

