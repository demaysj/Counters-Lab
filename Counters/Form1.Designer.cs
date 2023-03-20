namespace Counters
{
    partial class Form1
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
            this.cboDev = new System.Windows.Forms.ComboBox();
            this.cboCountIn = new System.Windows.Forms.ComboBox();
            this.cboCountOut = new System.Windows.Forms.ComboBox();
            this.nudFreq = new System.Windows.Forms.NumericUpDown();
            this.nudDuty = new System.Windows.Forms.NumericUpDown();
            this.nudInput = new System.Windows.Forms.NumericUpDown();
            this.nudOutput = new System.Windows.Forms.NumericUpDown();
            this.tbActFreq = new System.Windows.Forms.TextBox();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblCountIn = new System.Windows.Forms.Label();
            this.lblCountOut = new System.Windows.Forms.Label();
            this.lblFreq = new System.Windows.Forms.Label();
            this.lblDuty = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblMeasFreq = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDev
            // 
            this.cboDev.FormattingEnabled = true;
            this.cboDev.Location = new System.Drawing.Point(144, 23);
            this.cboDev.Name = "cboDev";
            this.cboDev.Size = new System.Drawing.Size(121, 21);
            this.cboDev.TabIndex = 0;
            // 
            // cboCountIn
            // 
            this.cboCountIn.FormattingEnabled = true;
            this.cboCountIn.Location = new System.Drawing.Point(144, 57);
            this.cboCountIn.Name = "cboCountIn";
            this.cboCountIn.Size = new System.Drawing.Size(121, 21);
            this.cboCountIn.TabIndex = 0;
            // 
            // cboCountOut
            // 
            this.cboCountOut.FormattingEnabled = true;
            this.cboCountOut.Location = new System.Drawing.Point(144, 91);
            this.cboCountOut.Name = "cboCountOut";
            this.cboCountOut.Size = new System.Drawing.Size(121, 21);
            this.cboCountOut.TabIndex = 0;
            // 
            // nudFreq
            // 
            this.nudFreq.Location = new System.Drawing.Point(145, 125);
            this.nudFreq.Name = "nudFreq";
            this.nudFreq.Size = new System.Drawing.Size(120, 20);
            this.nudFreq.TabIndex = 1;
            this.nudFreq.ValueChanged += new System.EventHandler(this.nudFreq_ValueChanged);
            // 
            // nudDuty
            // 
            this.nudDuty.Location = new System.Drawing.Point(144, 158);
            this.nudDuty.Name = "nudDuty";
            this.nudDuty.Size = new System.Drawing.Size(120, 20);
            this.nudDuty.TabIndex = 1;
            this.nudDuty.ValueChanged += new System.EventHandler(this.nudDuty_ValueChanged);
            // 
            // nudInput
            // 
            this.nudInput.Location = new System.Drawing.Point(144, 191);
            this.nudInput.Name = "nudInput";
            this.nudInput.Size = new System.Drawing.Size(120, 20);
            this.nudInput.TabIndex = 1;
            // 
            // nudOutput
            // 
            this.nudOutput.Location = new System.Drawing.Point(144, 224);
            this.nudOutput.Name = "nudOutput";
            this.nudOutput.Size = new System.Drawing.Size(120, 20);
            this.nudOutput.TabIndex = 1;
            // 
            // tbActFreq
            // 
            this.tbActFreq.Location = new System.Drawing.Point(145, 257);
            this.tbActFreq.Name = "tbActFreq";
            this.tbActFreq.ReadOnly = true;
            this.tbActFreq.Size = new System.Drawing.Size(119, 20);
            this.tbActFreq.TabIndex = 2;
            // 
            // btnMeasure
            // 
            this.btnMeasure.Location = new System.Drawing.Point(145, 290);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(120, 23);
            this.btnMeasure.TabIndex = 3;
            this.btnMeasure.Text = "Measure Frequency";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(91, 26);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(46, 13);
            this.lblDev.TabIndex = 4;
            this.lblDev.Text = "Devices";
            // 
            // lblCountIn
            // 
            this.lblCountIn.AutoSize = true;
            this.lblCountIn.Location = new System.Drawing.Point(81, 60);
            this.lblCountIn.Name = "lblCountIn";
            this.lblCountIn.Size = new System.Drawing.Size(56, 13);
            this.lblCountIn.TabIndex = 4;
            this.lblCountIn.Text = "Counter In";
            // 
            // lblCountOut
            // 
            this.lblCountOut.AutoSize = true;
            this.lblCountOut.Location = new System.Drawing.Point(73, 94);
            this.lblCountOut.Name = "lblCountOut";
            this.lblCountOut.Size = new System.Drawing.Size(64, 13);
            this.lblCountOut.TabIndex = 4;
            this.lblCountOut.Text = "Counter Out";
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(80, 127);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(57, 13);
            this.lblFreq.TabIndex = 4;
            this.lblFreq.Text = "Frequency";
            // 
            // lblDuty
            // 
            this.lblDuty.AutoSize = true;
            this.lblDuty.Location = new System.Drawing.Point(79, 160);
            this.lblDuty.Name = "lblDuty";
            this.lblDuty.Size = new System.Drawing.Size(58, 13);
            this.lblDuty.TabIndex = 4;
            this.lblDuty.Text = "Duty Cycle";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(38, 193);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(99, 13);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Input Terminal (PFI)";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(30, 226);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(107, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output Terminal (PFI)";
            // 
            // lblMeasFreq
            // 
            this.lblMeasFreq.AutoSize = true;
            this.lblMeasFreq.Location = new System.Drawing.Point(30, 259);
            this.lblMeasFreq.Name = "lblMeasFreq";
            this.lblMeasFreq.Size = new System.Drawing.Size(107, 13);
            this.lblMeasFreq.TabIndex = 4;
            this.lblMeasFreq.Text = "Measured Frequency";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(19, 290);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(120, 23);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "Output Frequency";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 326);
            this.Controls.Add(this.lblMeasFreq);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblDuty);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.lblCountOut);
            this.Controls.Add(this.lblCountIn);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnMeasure);
            this.Controls.Add(this.tbActFreq);
            this.Controls.Add(this.nudOutput);
            this.Controls.Add(this.nudInput);
            this.Controls.Add(this.nudDuty);
            this.Controls.Add(this.nudFreq);
            this.Controls.Add(this.cboCountOut);
            this.Controls.Add(this.cboCountIn);
            this.Controls.Add(this.cboDev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDev;
        private System.Windows.Forms.ComboBox cboCountIn;
        private System.Windows.Forms.ComboBox cboCountOut;
        private System.Windows.Forms.NumericUpDown nudFreq;
        private System.Windows.Forms.NumericUpDown nudDuty;
        private System.Windows.Forms.NumericUpDown nudInput;
        private System.Windows.Forms.NumericUpDown nudOutput;
        private System.Windows.Forms.TextBox tbActFreq;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblCountIn;
        private System.Windows.Forms.Label lblCountOut;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.Label lblDuty;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblMeasFreq;
        private System.Windows.Forms.Button btnOutput;
    }
}

