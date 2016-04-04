using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpInClass4416
{
    class Dice
    {
        private int _reslt;
        private Random random;

        public Dice()
        {
            //random = new Random();
        }
        
        public int Reslt
        {
            get { _reslt = random.Next(1, 7);
                return _reslt;
            }
            set { _reslt = value; }
        }

        public int getDiceResult()
        {
            random = new Random();
            return _reslt = random.Next(1, 7);
        }

        public void showDiceResult()
        {
            MessageBox.Show(getDiceResult().ToString());
        }
    }
}
