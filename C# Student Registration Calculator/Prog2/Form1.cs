//B3389
//Prgm2
//October 18, 2018
//199-02
//This program displays the date and time a person can register for the next semester
//based on their current standing and first letter of their last name

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //performs the calculation for when a person can register
        private void calcBtn_Click(object sender, EventArgs e)
        {
            const string DAY1 = "November 2nd";//day for senior registration
            const string DAY2 = "November 5th";//day for junior registration
            const string DAY3 = "November 6th";//day for sophomore A-Q registration
            const string DAY4 = "November 7th";//day for sophomore R-Z registration
            const string DAY5 = "November 8th";//day for freshman A-Q registration
            const string DAY6 = "November 9th";//day for freshman R-Z registration
            const string TIME1 = "8:30";//time value 1
            const string TIME2 = "10:00";//time value 2
            const string TIME3 = "11:30";//time value 3
            const string TIME4 = "2:00";//time value 4
            const string TIME5 = "4:00";//time value 5
            char ch;//holds the value for the first letter of a person's last name
            string time = "Error"; //gives time a default value of ERROR before storing time value
            string day = "Error";//gives day a default value of ERROR before storing day value

            ch = Convert.ToChar(firstLetterTxt.Text);
            if (char.IsLetter(ch))
                ch = char.ToUpper(ch);

            if (juniorBtn.Checked || seniorBtn.Checked)
            {
                if (seniorBtn.Checked)
                    day = DAY1;
                else
                    day = DAY2;

                if (ch <= 'D')
                    time = TIME5;
                else if (ch <= 'I')
                    time = TIME1;
                else if (ch <= 'O')
                    time = TIME2;
                else if (ch <= 'S')
                    time = TIME3;
                else
                    time = TIME4;
            }
            else
            {
                if (sophomoreBtn.Checked)
                {
                    if (ch >= 'E' && ch <= 'Q')
                        day = DAY3;
                    else
                        day = DAY4;
                }
                else //if freshamnBtn.Checked
                {
                    if (ch >= 'E' && ch <= 'Q')
                        day = DAY5;
                    else
                        day = DAY6;
                }
                if (ch <= 'B' || (ch >= 'M' && ch <= 'O'))
                    time = TIME4;
                else if ((ch >= 'E' && ch <= 'F') || (ch >= 'R' && ch <= 'S'))
                    time = TIME1;
                else if ((ch >= 'G' && ch <= 'I') || (ch >= 'T' && ch <= 'V'))
                    time = TIME2;
                else if ((ch >= 'J' && ch <= 'L') || (ch >= 'W' && ch <= 'Z'))
                    time = TIME3;
                else if ((ch >= 'P' && ch <= 'Q') || (ch >= 'C' && ch <= 'D'))
                    time = TIME4;
                else
                    time = "ERROR"; 
            }
            datetimeLbl.Text = $"{day} at {time}";
        }
        //clears any data on the form
        private void clearBtn_Click(object sender, EventArgs e)
        {
            datetimeLbl.Text = "";
            firstLetterTxt.Text = "";
            freshmanBtn.Checked = false;
            sophomoreBtn.Checked = false;
            juniorBtn.Checked = false;
            seniorBtn.Checked = false;
        }
    }
}
