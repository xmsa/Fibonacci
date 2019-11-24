namespace Fibonacci
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.chBoxLoop = new System.Windows.Forms.CheckBox();
            this.chBoxRecursive = new System.Windows.Forms.CheckBox();
            this.chBoxMyAlgorithm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(32, 29);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(393, 86);
            this.txtNumber.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(32, 136);
            this.btnStart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(272, 91);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(507, 134);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 91);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(448, 36);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(213, 95);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Number";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(320, 134);
            this.btnStop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(171, 91);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // chBoxLoop
            // 
            this.chBoxLoop.AutoSize = true;
            this.chBoxLoop.Location = new System.Drawing.Point(696, 45);
            this.chBoxLoop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chBoxLoop.Name = "chBoxLoop";
            this.chBoxLoop.Size = new System.Drawing.Size(117, 36);
            this.chBoxLoop.TabIndex = 3;
            this.chBoxLoop.Text = "Loop";
            this.chBoxLoop.UseVisualStyleBackColor = true;
            // 
            // chBoxRecursive
            // 
            this.chBoxRecursive.AutoSize = true;
            this.chBoxRecursive.Location = new System.Drawing.Point(696, 100);
            this.chBoxRecursive.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chBoxRecursive.Name = "chBoxRecursive";
            this.chBoxRecursive.Size = new System.Drawing.Size(179, 36);
            this.chBoxRecursive.TabIndex = 4;
            this.chBoxRecursive.Text = "Recursive";
            this.chBoxRecursive.UseVisualStyleBackColor = true;
            // 
            // chBoxMyAlgorithm
            // 
            this.chBoxMyAlgorithm.AutoSize = true;
            this.chBoxMyAlgorithm.Location = new System.Drawing.Point(696, 150);
            this.chBoxMyAlgorithm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chBoxMyAlgorithm.Name = "chBoxMyAlgorithm";
            this.chBoxMyAlgorithm.Size = new System.Drawing.Size(211, 36);
            this.chBoxMyAlgorithm.TabIndex = 5;
            this.chBoxMyAlgorithm.Text = "MyAlgorithm";
            this.chBoxMyAlgorithm.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 238);
            this.Controls.Add(this.chBoxMyAlgorithm);
            this.Controls.Add(this.chBoxRecursive);
            this.Controls.Add(this.chBoxLoop);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chBoxLoop;
        private System.Windows.Forms.CheckBox chBoxRecursive;
        private System.Windows.Forms.CheckBox chBoxMyAlgorithm;
    }
}

