
namespace LifeGameDemoOne {
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.tbInterval = new System.Windows.Forms.TrackBar();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnCalcNextGen = new System.Windows.Forms.Button();
            this.btnInitLife = new System.Windows.Forms.Button();
            this.lbColNum = new System.Windows.Forms.Label();
            this.lbRowNum = new System.Windows.Forms.Label();
            this.nudRowNum = new System.Windows.Forms.NumericUpDown();
            this.nudColNum = new System.Windows.Forms.NumericUpDown();
            this.pnCells = new System.Windows.Forms.Panel();
            this.tmNextGen = new System.Windows.Forms.Timer(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.sfgSave = new System.Windows.Forms.SaveFileDialog();
            this.btLoad = new System.Windows.Forms.Button();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.LightCyan;
            this.btnStart.Location = new System.Drawing.Point(245, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(221, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Generate Universe!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Clicked);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnMenu.Controls.Add(this.btLoad);
            this.pnMenu.Controls.Add(this.btSave);
            this.pnMenu.Controls.Add(this.tbInterval);
            this.pnMenu.Controls.Add(this.btnStartTimer);
            this.pnMenu.Controls.Add(this.btnCalcNextGen);
            this.pnMenu.Controls.Add(this.btnInitLife);
            this.pnMenu.Controls.Add(this.lbColNum);
            this.pnMenu.Controls.Add(this.lbRowNum);
            this.pnMenu.Controls.Add(this.nudRowNum);
            this.pnMenu.Controls.Add(this.nudColNum);
            this.pnMenu.Controls.Add(this.btnStart);
            this.pnMenu.Location = new System.Drawing.Point(12, 12);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(469, 220);
            this.pnMenu.TabIndex = 1;
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(12, 164);
            this.tbInterval.Maximum = 2000;
            this.tbInterval.Minimum = 50;
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(211, 42);
            this.tbInterval.TabIndex = 8;
            this.tbInterval.Value = 50;
            this.tbInterval.ValueChanged += new System.EventHandler(this.tbInterval_ValueChanged);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.AutoSize = true;
            this.btnStartTimer.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnStartTimer.FlatAppearance.BorderSize = 0;
            this.btnStartTimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStartTimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStartTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.ForeColor = System.Drawing.Color.LightCyan;
            this.btnStartTimer.Location = new System.Drawing.Point(12, 108);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(113, 41);
            this.btnStartTimer.TabIndex = 7;
            this.btnStartTimer.Text = "Auto Run";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnCalcNextGen
            // 
            this.btnCalcNextGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcNextGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcNextGen.Location = new System.Drawing.Point(154, 111);
            this.btnCalcNextGen.Name = "btnCalcNextGen";
            this.btnCalcNextGen.Size = new System.Drawing.Size(298, 34);
            this.btnCalcNextGen.TabIndex = 6;
            this.btnCalcNextGen.Text = "Calculate Next Generation";
            this.btnCalcNextGen.UseVisualStyleBackColor = true;
            this.btnCalcNextGen.Click += new System.EventHandler(this.btnCalcNextGen_Click);
            // 
            // btnInitLife
            // 
            this.btnInitLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitLife.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInitLife.Location = new System.Drawing.Point(245, 54);
            this.btnInitLife.Name = "btnInitLife";
            this.btnInitLife.Size = new System.Drawing.Size(207, 34);
            this.btnInitLife.TabIndex = 5;
            this.btnInitLife.Text = "Init Life";
            this.btnInitLife.UseVisualStyleBackColor = true;
            this.btnInitLife.Click += new System.EventHandler(this.btnInitLife_Click);
            // 
            // lbColNum
            // 
            this.lbColNum.AutoSize = true;
            this.lbColNum.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbColNum.Location = new System.Drawing.Point(119, 5);
            this.lbColNum.Name = "lbColNum";
            this.lbColNum.Size = new System.Drawing.Size(104, 13);
            this.lbColNum.TabIndex = 4;
            this.lbColNum.Text = "Number Of Columns:";
            // 
            // lbRowNum
            // 
            this.lbRowNum.AutoSize = true;
            this.lbRowNum.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbRowNum.Location = new System.Drawing.Point(12, 5);
            this.lbRowNum.Name = "lbRowNum";
            this.lbRowNum.Size = new System.Drawing.Size(91, 13);
            this.lbRowNum.TabIndex = 3;
            this.lbRowNum.Text = "Number Of Rows:";
            // 
            // nudRowNum
            // 
            this.nudRowNum.Location = new System.Drawing.Point(12, 28);
            this.nudRowNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudRowNum.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRowNum.Name = "nudRowNum";
            this.nudRowNum.Size = new System.Drawing.Size(91, 20);
            this.nudRowNum.TabIndex = 2;
            this.nudRowNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudColNum
            // 
            this.nudColNum.Location = new System.Drawing.Point(119, 28);
            this.nudColNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudColNum.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudColNum.Name = "nudColNum";
            this.nudColNum.Size = new System.Drawing.Size(104, 20);
            this.nudColNum.TabIndex = 1;
            this.nudColNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // pnCells
            // 
            this.pnCells.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnCells.Location = new System.Drawing.Point(13, 238);
            this.pnCells.Name = "pnCells";
            this.pnCells.Size = new System.Drawing.Size(468, 102);
            this.pnCells.TabIndex = 2;
            // 
            // tmNextGen
            // 
            this.tmNextGen.Interval = 200;
            this.tmNextGen.Tick += new System.EventHandler(this.tmNextGen_Tick);
            // 
            // btSave
            // 
            this.btSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSave.Location = new System.Drawing.Point(12, 55);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(91, 38);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // sfgSave
            // 
            this.sfgSave.FileOk += new System.ComponentModel.CancelEventHandler(this.sfgSave_FileOk);
            // 
            // btLoad
            // 
            this.btLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLoad.Location = new System.Drawing.Point(109, 55);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(91, 38);
            this.btLoad.TabIndex = 10;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // ofdLoad
            // 
            this.ofdLoad.FileName = "openFileDialog1";
            this.ofdLoad.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLoad_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(493, 352);
            this.Controls.Add(this.pnCells);
            this.Controls.Add(this.pnMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnCells;
        private System.Windows.Forms.Label lbColNum;
        private System.Windows.Forms.Label lbRowNum;
        private System.Windows.Forms.NumericUpDown nudRowNum;
        private System.Windows.Forms.NumericUpDown nudColNum;
        private System.Windows.Forms.Button btnInitLife;
        private System.Windows.Forms.Button btnCalcNextGen;
        private System.Windows.Forms.Timer tmNextGen;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.TrackBar tbInterval;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.SaveFileDialog sfgSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
    }
}

