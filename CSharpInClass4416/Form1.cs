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
    public partial class Form1 : Form
    {
        Dice diceOne = new Dice();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRollOne_Click(object sender, EventArgs e)
        {
            tbDiceResult.Text = diceOne.getDiceResult().ToString();
            DiceTwo diceTwo = new DiceTwo();
            diceTwo.Show();
        }
    }
}