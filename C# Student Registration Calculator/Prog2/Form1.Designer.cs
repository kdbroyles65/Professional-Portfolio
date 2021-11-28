namespace Prog2
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
            this.firstLetterTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.freshmanBtn = new System.Windows.Forms.RadioButton();
            this.sophomoreBtn = new System.Windows.Forms.RadioButton();
            this.juniorBtn = new System.Windows.Forms.RadioButton();
            this.seniorBtn = new System.Windows.Forms.RadioButton();
            this.staticTxt2 = new System.Windows.Forms.Label();
            this.staticTxt1 = new System.Windows.Forms.Label();
            this.datetimeLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLetterTxt
            // 
            this.firstLetterTxt.Location = new System.Drawing.Point(630, 131);
            this.firstLetterTxt.Name = "firstLetterTxt";
            this.firstLetterTxt.Size = new System.Drawing.Size(100, 26);
            this.firstLetterTxt.TabIndex = 0;
            // 
            // calcBtn
            // 
            this.calcBtn.AutoSize = true;
            this.calcBtn.Location = new System.Drawing.Point(300, 400);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(223, 30);
            this.calcBtn.TabIndex = 1;
            this.calcBtn.Text = "When is my registration date!";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // freshmanBtn
            // 
            this.freshmanBtn.AutoSize = true;
            this.freshmanBtn.Location = new System.Drawing.Point(186, 214);
            this.freshmanBtn.Name = "freshmanBtn";
            this.freshmanBtn.Size = new System.Drawing.Size(106, 24);
            this.freshmanBtn.TabIndex = 2;
            this.freshmanBtn.TabStop = true;
            this.freshmanBtn.Text = "Freshman";
            this.freshmanBtn.UseVisualStyleBackColor = true;
            // 
            // sophomoreBtn
            // 
            this.sophomoreBtn.AutoSize = true;
            this.sophomoreBtn.Location = new System.Drawing.Point(357, 214);
            this.sophomoreBtn.Name = "sophomoreBtn";
            this.sophomoreBtn.Size = new System.Drawing.Size(117, 24);
            this.sophomoreBtn.TabIndex = 3;
            this.sophomoreBtn.TabStop = true;
            this.sophomoreBtn.Text = "Sophomore";
            this.sophomoreBtn.UseVisualStyleBackColor = true;
            // 
            // juniorBtn
            // 
            this.juniorBtn.AutoSize = true;
            this.juniorBtn.Location = new System.Drawing.Point(547, 214);
            this.juniorBtn.Name = "juniorBtn";
            this.juniorBtn.Size = new System.Drawing.Size(77, 24);
            this.juniorBtn.TabIndex = 4;
            this.juniorBtn.TabStop = true;
            this.juniorBtn.Text = "Junior";
            this.juniorBtn.UseVisualStyleBackColor = true;
            // 
            // seniorBtn
            // 
            this.seniorBtn.AutoSize = true;
            this.seniorBtn.Location = new System.Drawing.Point(683, 214);
            this.seniorBtn.Name = "seniorBtn";
            this.seniorBtn.Size = new System.Drawing.Size(80, 24);
            this.seniorBtn.TabIndex = 5;
            this.seniorBtn.TabStop = true;
            this.seniorBtn.Text = "Senior";
            this.seniorBtn.UseVisualStyleBackColor = true;
            // 
            // staticTxt2
            // 
            this.staticTxt2.AutoSize = true;
            this.staticTxt2.Location = new System.Drawing.Point(229, 134);
            this.staticTxt2.Name = "staticTxt2";
            this.staticTxt2.Size = new System.Drawing.Size(370, 20);
            this.staticTxt2.TabIndex = 8;
            this.staticTxt2.Text = "Please enter the FIRST LETTER of your last name:";
            // 
            // staticTxt1
            // 
            this.staticTxt1.AutoSize = true;
            this.staticTxt1.Location = new System.Drawing.Point(305, 316);
            this.staticTxt1.Name = "staticTxt1";
            this.staticTxt1.Size = new System.Drawing.Size(198, 20);
            this.staticTxt1.TabIndex = 9;
            this.staticTxt1.Text = "Your registaration date is...";
            // 
            // datetimeLbl
            // 
            this.datetimeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datetimeLbl.Location = new System.Drawing.Point(544, 315);
            this.datetimeLbl.Name = "datetimeLbl";
            this.datetimeLbl.Size = new System.Drawing.Size(293, 23);
            this.datetimeLbl.TabIndex = 10;
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearBtn.Location = new System.Drawing.Point(611, 400);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(91, 30);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Start Over";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearBtn;
            this.ClientSize = new System.Drawing.Size(997, 648);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.datetimeLbl);
            this.Controls.Add(this.staticTxt1);
            this.Controls.Add(this.staticTxt2);
            this.Controls.Add(this.seniorBtn);
            this.Controls.Add(this.juniorBtn);
            this.Controls.Add(this.sophomoreBtn);
            this.Controls.Add(this.freshmanBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.firstLetterTxt);
            this.Name = "Form1";
            this.Text = " Prog 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstLetterTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.RadioButton freshmanBtn;
        private System.Windows.Forms.RadioButton sophomoreBtn;
        private System.Windows.Forms.RadioButton juniorBtn;
        private System.Windows.Forms.RadioButton seniorBtn;
        private System.Windows.Forms.Label staticTxt2;
        private System.Windows.Forms.Label staticTxt1;
        private System.Windows.Forms.Label datetimeLbl;
        private System.Windows.Forms.Button clearBtn;
    }
}

