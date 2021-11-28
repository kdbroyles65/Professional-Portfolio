//B3389
//Prgm1
//September 15, 2018
//199-02
//program allows the user to specify wall length and height, window and door total and number of 
//coats and will calculate the number of gallons they will use and need to buy
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //calculates the amount of paint needed based on 5 variables and displays the total as a whole number
        private void button1_Click(object sender, EventArgs e)
        {
            const double doorSquarefoot = 20,//squarefootage of a door
                         windowSquarefoot = 15,//squarefootage of a window
                         canSquarefoot = 385;//squarefootage a can of paint can cover
            double wallLengthCalc,//variable assigned to hold the contents of the wallLength text box
                   wallHeightCalc,//variable assigned to hold the contents of the wallHeight text box
                   gallonsToUse,//variable assigned to hold the total number of gallons you will use
                   gallonsToBuy;//variable assigned to hold the total of gallons to buy
            int doorTotalCalc,//variable assigned to hold the contents of the doorTotal text box
                windowTotalCalc,//variable assigned to hold the contents of the windowTotal text box
                paintCoatsCalc;//variable assigned to hold the contents of the paintCoats text box

            //Parses the information from the text boxes and stores the values in the preset variables (above)
            wallLengthCalc = double.Parse(wallLength.Text);
            wallHeightCalc = double.Parse(wallHeight.Text);
            doorTotalCalc = int.Parse(doorTotal.Text);
            windowTotalCalc = int.Parse(windowTotal.Text);
            paintCoatsCalc = int.Parse(paintCoats.Text);

            gallonsToUse = (((wallLengthCalc * wallHeightCalc) - (doorTotalCalc * doorSquarefoot) - (windowTotalCalc * windowSquarefoot)) * 2)/canSquarefoot;
            gallonsToBuy = Convert.ToDouble($"{gallonsToUse:0}");

            estimateTotal.Text = ($"You'll need a minimum of {gallonsToUse:0.0} gallons of paint. You'll need to buy {gallonsToBuy} gallons, though");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            wallLength.Text = string.Empty;
            wallHeight.Text = string.Empty;
            doorTotal.Text = string.Empty;
            windowTotal.Text = string.Empty;
            paintCoats.Text = string.Empty;
            estimateTotal.Text = string.Empty;

            wallLength.Focus();
        }
    }
}
