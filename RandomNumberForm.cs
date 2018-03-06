/*
 * Created by: Jadon Fournier
 * Created on: 5-Mar-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - RandomNumber
 * This program generates and displays a random number between 1 and 25 when you click the button.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class frmRandomNumber : Form
    {
        //Define variable and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 25;
        int RandomNumber;
        Random Generator = new Random();

        public frmRandomNumber()
        {
            InitializeComponent();

            //Hide the answer labels
            this.lblStateAnswer.Hide();
            this.lblAnswer.Hide();
        }

        private void frmRandomNumber_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Get the number
            RandomNumber = Generator.Next(MIN_VALUE, MAX_VALUE + 1);

            //Set the number to a label
            lblAnswer.Text = Convert.ToString(RandomNumber);

            //Show the labels
            this.lblStateAnswer.Show();
            this.lblAnswer.Show();

        }
    }
}
