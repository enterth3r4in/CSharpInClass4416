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
    public partial class DiceTwo : Form
    {
        Dice diceTwo = new Dice();

        public DiceTwo()
        {
            InitializeComponent();
        }

        private void btnRollTwo_Click(object sender, EventArgs e)
        {
            tbDiceResultTwo.Text = diceTwo.getDiceResult().ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
