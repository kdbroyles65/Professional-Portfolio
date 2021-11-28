// Exam 2, Part 3
// CIS 199-02
// Fall 2018
// Estimates how much home sale price is affected by
// perception of zipcode being in a good school district

// By: B3389

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2Part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsGoodSchoolZip (string zipcode)
        {
            // Zipcodes perceived to be in good school districts
            string[] bestSchoolZips = { "12345", "54321", "11111", "22222", "33333", "44444", "55555", "90210", "77777", "88888" };
            bool isGoodSchool = false;

            // ADD CODE HERE
            // #1
            // Put sequential search code here
            // You MUST write your own loop
            // Your code should be correct AND efficient
            // Remember to return search result (true or false)
            for (int x = 0; x <= bestSchoolZips.Length - 1; x++)
            {
                if (zipcode == bestSchoolZips[x])
                {
                    isGoodSchool = true;
                    break;
                }
                
                return isGoodSchool;
            }
        }

        private void calcSalePriceBtn_Click(object sender, EventArgs e)
        {
            const double NOTGOOD_EFFECT = 0.98;  // 2% lower sale price for zips that aren't perceived
                                                 // to have good schools
            const double GOOD_EFFECT = 1.10;     // 10% higher sales price for zips that are perceived
                                                 // to have good schools

            string zipcode;      // Entered zipcode
            double askingPrice;  // Entered asking price
            double schoolEffect; // Calculated effect percentage
            double salePrice;    // Calculated sale price estimate
            bool isGoodSchool;   // Will hold result from method call

            zipcode = zipcodeTxt.Text; // Gets zipcode from form

            if (double.TryParse(askingPriceTxt.Text, out askingPrice) && askingPrice > 0) // Try to parse asking price
            {
                // Add code where indicated below (2-6) to:
                // Call method to determine if homeZip is a good school zipcode
                // If so, assign good effect to schoolEffect. Otherwise, assign not good effect
                // Calculate estimated sale price (using determined schoolEffect as multiplier of askingPrice)
                // Display whether perceived as good school zip (in goodSchoolOutputLbl on form), "Yes" or "No"
                // Display estimated sale price (in salePriceOutputLbl on form), currency format

                // ADD CODE HERE
                // #2
                isGoodSchool = IsGoodSchoolZip(zipcode);

                if (isGoodSchool)
                {
                    schoolEffect = GOOD_EFFECT;
                    goodSchoolOutputLbl.Text = "Yes";
                    // ADD CODE HERE
                    // #3
                    // Assign good schoolEffect value
                    // Display "Yes" in goodSchoolOutputLbl on form
                }
                else // Not perceived good school zip
                {
                    schoolEffect = NOTGOOD_EFFECT;
                    goodSchoolOutputLbl.Text = "No";
                    // ADD CODE HERE
                    // #4
                    // Assign not good schoolEffect value
                    // Display "No" in goodSchoolOutputLbl on form
                }

                // ADD CODE HERE
                // #5
                salePrice = schoolEffect * askingPrice;  // Complete calculation of estimated sale price

                // ADD CODE HERE
                // #6
                // Display estimated sale price (in salePriceOutputLbl on form), currency format
                salePriceOutputLbl.Text = $"{salePrice:C}";
            }
            else
            {
                MessageBox.Show("Please enter valid asking price!");
            }

        }
    }
}
