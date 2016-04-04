using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpInClass4416
{
    public partial class UnivForm : Form
    {
        public UnivForm()
        {
            InitializeComponent();
        }

        private void btnGather_Click(object sender, EventArgs e)
        {
            University universityOne = new University();
            universityOne.Name = tbNameUniv.Text;
            universityOne.Location = tbLocation.Text;
            universityOne.FieldOfStudy = tbFieldOfStudy.Text;

            double cpsTemp = 0.0;
            if (double.TryParse(tbCostPerSemester.Text, out cpsTemp))
                universityOne.CostPerSemester = cpsTemp;
            else
                MessageBox.Show("Invalid cost per semester. Enter a valid numerical format entry.");

            bool dctTemp = false;
            if (bool.TryParse(tbDoCreditsTransfer.Text, out dctTemp))
                universityOne.DoCreditsTransfer = dctTemp;
            else
                MessageBox.Show("Invalid entry for \"Do Credits Transfer\". Try again (true/false only)");

            tbDisplayOutput.Text = universityOne.summary();
            //University universityTwo = new University(tbNameUniv.Text, tbLocation.Text, tbFieldOfStudy.Text,
              //  double.Parse(tbCostPerSemester.Text), bool.Parse(tbDoCreditsTransfer.Text));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
