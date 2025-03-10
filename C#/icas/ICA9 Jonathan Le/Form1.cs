using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA9_Jonathan_Le
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /***************************************EVENT HANDLERS*******************************************/
        private void UI_RecursionOptions_Click(object sender, EventArgs e)
        {
            UI_ReversedString_Tbx.Clear();
            if (sender == UI_RecShow_Btn)
            {
                PreOrder(UI_TestString_Tbx.Text, 0);
            }
            if (sender == UI_RecReverse_Btn)
            {

            }
        }
        private void UI_FindFactors_Btn_Click(object sender, EventArgs e)
        {
            int value = (int)UI_FactorFinder_Nbx.Value;
            long factors = Factorial(value);
            UI_FindFactors_Tbx.Text = $"{factors}";

        }
        private void UI_BinaryHunter_Btn_Click(object sender, EventArgs e)
        {

        }
        /******************************************METHODS***********************************************/
        private long Factorial(int n)
        {
            if (n < 1)
                return 1;
            else
                return n * Factorial(n - 1);

        }
        void PreOrder(string sString, int posn)
        {
            if (posn < sString.Length)
            {
                UI_ReversedString_Tbx.Text += $"{sString[posn]}";
                PreOrder(sString, posn + 1);
            }

        }
        void PostOrder(string sString, int posn)
        {
            if (posn < sString.Length)
            {
                PostOrder(sString, posn + 1);
                Console.Write(sString[posn]);
            }
        }


    }
}
