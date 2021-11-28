namespace Exam2Part3
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
            this.zipPromptLbl = new System.Windows.Forms.Label();
            this.askingPricePromptLbl = new System.Windows.Forms.Label();
            this.schoolPromptLbl = new System.Windows.Forms.Label();
            this.estSalePomptLbl = new System.Windows.Forms.Label();
            this.zipcodeTxt = new System.Windows.Forms.TextBox();
            this.askingPriceTxt = new System.Windows.Forms.TextBox();
            this.calcSalePriceBtn = new System.Windows.Forms.Button();
            this.goodSchoolOutputLbl = new System.Windows.Forms.Label();
            this.salePriceOutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zipPromptLbl
            // 
            this.zipPromptLbl.Location = new System.Drawing.Point(29, 13);
            this.zipPromptLbl.Name = "zipPromptLbl";
            this.zipPromptLbl.Size = new System.Drawing.Size(68, 13);
            this.zipPromptLbl.TabIndex = 0;
            this.zipPromptLbl.Text = "Zip Code:";
            this.zipPromptLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // askingPricePromptLbl
            // 
            this.askingPricePromptLbl.Location = new System.Drawing.Point(13, 36);
            this.askingPricePromptLbl.Name = "askingPricePromptLbl";
            this.askingPricePromptLbl.Size = new System.Drawing.Size(84, 13);
            this.askingPricePromptLbl.TabIndex = 1;
            this.askingPricePromptLbl.Text = "Asking Price:";
            this.askingPricePromptLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // schoolPromptLbl
            // 
            this.schoolPromptLbl.Location = new System.Drawing.Point(12, 59);
            this.schoolPromptLbl.Name = "schoolPromptLbl";
            this.schoolPromptLbl.Size = new System.Drawing.Size(85, 13);
            this.schoolPromptLbl.TabIndex = 2;
            this.schoolPromptLbl.Text = "Good School:";
            this.schoolPromptLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // estSalePomptLbl
            // 
            this.estSalePomptLbl.Location = new System.Drawing.Point(16, 82);
            this.estSalePomptLbl.Name = "estSalePomptLbl";
            this.estSalePomptLbl.Size = new System.Drawing.Size(81, 13);
            this.estSalePomptLbl.TabIndex = 3;
            this.estSalePomptLbl.Text = "Est. Sale Price:";
            this.estSalePomptLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // zipcodeTxt
            // 
            this.zipcodeTxt.Location = new System.Drawing.Point(103, 10);
            this.zipcodeTxt.Name = "zipcodeTxt";
            this.zipcodeTxt.Size = new System.Drawing.Size(100, 20);
            this.zipcodeTxt.TabIndex = 4;
            // 
            // askingPriceTxt
            // 
            this.askingPriceTxt.Location = new System.Drawing.Point(103, 33);
            this.askingPriceTxt.Name = "askingPriceTxt";
            this.askingPriceTxt.Size = new System.Drawing.Size(100, 20);
            this.askingPriceTxt.TabIndex = 5;
            // 
            // calcSalePriceBtn
            // 
            this.calcSalePriceBtn.Location = new System.Drawing.Point(48, 105);
            this.calcSalePriceBtn.Name = "calcSalePriceBtn";
            this.calcSalePriceBtn.Size = new System.Drawing.Size(127, 23);
            this.calcSalePriceBtn.TabIndex = 8;
            this.calcSalePriceBtn.Text = "Calculate Sale Price";
            this.calcSalePriceBtn.UseVisualStyleBackColor = true;
            this.calcSalePriceBtn.Click += new System.EventHandler(this.calcSalePriceBtn_Click);
            // 
            // goodSchoolOutputLbl
            // 
            this.goodSchoolOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goodSchoolOutputLbl.Location = new System.Drawing.Point(103, 58);
            this.goodSchoolOutputLbl.Name = "goodSchoolOutputLbl";
            this.goodSchoolOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.goodSchoolOutputLbl.TabIndex = 9;
            this.goodSchoolOutputLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // salePriceOutputLbl
            // 
            this.salePriceOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceOutputLbl.Location = new System.Drawing.Point(103, 81);
            this.salePriceOutputLbl.Name = "salePriceOutputLbl";
            this.salePriceOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.salePriceOutputLbl.TabIndex = 10;
            this.salePriceOutputLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcSalePriceBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 141);
            this.Controls.Add(this.salePriceOutputLbl);
            this.Controls.Add(this.goodSchoolOutputLbl);
            this.Controls.Add(this.calcSalePriceBtn);
            this.Controls.Add(this.askingPriceTxt);
            this.Controls.Add(this.zipcodeTxt);
            this.Controls.Add(this.estSalePomptLbl);
            this.Controls.Add(this.schoolPromptLbl);
            this.Controls.Add(this.askingPricePromptLbl);
            this.Controls.Add(this.zipPromptLbl);
            this.Name = "Form1";
            this.Text = "Exam 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zipPromptLbl;
        private System.Windows.Forms.Label askingPricePromptLbl;
        private System.Windows.Forms.Label schoolPromptLbl;
        private System.Windows.Forms.Label estSalePomptLbl;
        private System.Windows.Forms.TextBox zipcodeTxt;
        private System.Windows.Forms.TextBox askingPriceTxt;
        private System.Windows.Forms.Button calcSalePriceBtn;
        private System.Windows.Forms.Label goodSchoolOutputLbl;
        private System.Windows.Forms.Label salePriceOutputLbl;
    }
}

