/* CMPE 1666 - Intermediate Programming
 * 
 * Author: Jonathan Le
 * 
 * Date: Jan. 1, 2025
 * 
 * Purpose: Program loads a form and the order of events when
 * opening, focusing, unfocusing, and closing the form will be reported
 * in console
 * 
 * 
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

namespace ICA2_Jonathan_Le
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Constructor");
        }

        private void UI_Load_Form(object sender, EventArgs e)
        {
            //writes in console when the form is created
            Console.WriteLine("Form has been loaded");
        }

        private void UI_Closing_Event(object sender, FormClosingEventArgs e)
        {
            //write in console when the form is being exited 
            Console.WriteLine("Form is closing");
        }

        private void UI_Paint_Event(object sender, PaintEventArgs e)
        {
            //write in console when the form graphics are loaded
            Console.WriteLine("Form is painted");
        }

        private void UI_Activated_Event(object sender, EventArgs e)
        {
            //write in console when form is in focus
            Console.WriteLine("Form is activated");
        }

        private void UI_Closed_Event(object sender, FormClosedEventArgs e)
        {
            //write in console when form fully closes
            Console.WriteLine("Form is closed");
        }

        private void UI_Deactivate_Event(object sender, EventArgs e)
        {
            //write in console when form is out of focus
            Console.WriteLine("Form is deactivated");
        }

        private void UI_Shown_Event(object sender, EventArgs e)
        {
            //write in console when form is first shown
            Console.WriteLine("Form is shown");
        }
    }
}
