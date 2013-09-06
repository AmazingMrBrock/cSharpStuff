using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {            
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimbursRate = .39;
        double amountOwed;

        public Form1()
        {

            InitializeComponent();

        }

        private void calculate_Click(object sender, EventArgs e)
        {

            startingMileage = (int) stMileage.Value;
            endingMileage = (int) enMileage.Value;

            if (startingMileage >= endingMileage)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot calculate Mileage");
            }
            else
            {
                milesTraveled = endingMileage - startingMileage;

                amountOwed = milesTraveled * reimbursRate;

                amOwed.Text = "$" + amountOwed;
            }

        }

        private void dislpayMiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + "miles", "Miles Traveled");
        }
    }
}
