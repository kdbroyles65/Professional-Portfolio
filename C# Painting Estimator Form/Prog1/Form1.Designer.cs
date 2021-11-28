namespace Prog1
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
            this.label1 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wallLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wallHeight = new System.Windows.Forms.TextBox();
            this.doorTotal = new System.Windows.Forms.TextBox();
            this.windowTotal = new System.Windows.Forms.TextBox();
            this.paintCoats = new System.Windows.Forms.TextBox();
            this.estimateTotal = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Handy-Dandy Paint Estimator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(212, 335);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(112, 35);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Estimate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the total length of all walls (in feet):";
            // 
            // wallLength
            // 
            this.wallLength.Location = new System.Drawing.Point(368, 77);
            this.wallLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wallLength.Name = "wallLength";
            this.wallLength.Size = new System.Drawing.Size(148, 26);
            this.wallLength.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the height of the walls (in feet):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter the # of doors (non-neg int):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter the # of windows (non-neg int):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Enter the # of coats of paint (non-neg int):";
            // 
            // wallHeight
            // 
            this.wallHeight.Location = new System.Drawing.Point(368, 128);
            this.wallHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wallHeight.Name = "wallHeight";
            this.wallHeight.Size = new System.Drawing.Size(148, 26);
            this.wallHeight.TabIndex = 8;
            // 
            // doorTotal
            // 
            this.doorTotal.Location = new System.Drawing.Point(368, 177);
            this.doorTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doorTotal.Name = "doorTotal";
            this.doorTotal.Size = new System.Drawing.Size(148, 26);
            this.doorTotal.TabIndex = 9;
            // 
            // windowTotal
            // 
            this.windowTotal.Location = new System.Drawing.Point(368, 228);
            this.windowTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowTotal.Name = "windowTotal";
            this.windowTotal.Size = new System.Drawing.Size(148, 26);
            this.windowTotal.TabIndex = 10;
            // 
            // paintCoats
            // 
            this.paintCoats.Location = new System.Drawing.Point(368, 278);
            this.paintCoats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paintCoats.Name = "paintCoats";
            this.paintCoats.Size = new System.Drawing.Size(148, 26);
            this.paintCoats.TabIndex = 11;
            // 
            // estimateTotal
            // 
            this.estimateTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.estimateTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estimateTotal.Location = new System.Drawing.Point(124, 402);
            this.estimateTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estimateTotal.Name = "estimateTotal";
            this.estimateTotal.Size = new System.Drawing.Size(474, 87);
            this.estimateTotal.TabIndex = 12;
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(368, 335);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 35);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(726, 525);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.estimateTotal);
            this.Controls.Add(this.paintCoats);
            this.Controls.Add(this.windowTotal);
            this.Controls.Add(this.doorTotal);
            this.Controls.Add(this.wallHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wallLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wallLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wallHeight;
        private System.Windows.Forms.TextBox doorTotal;
        private System.Windows.Forms.TextBox windowTotal;
        private System.Windows.Forms.TextBox paintCoats;
        private System.Windows.Forms.Label estimateTotal;
        private System.Windows.Forms.Button clearButton;
    }
}

