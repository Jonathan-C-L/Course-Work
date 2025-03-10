/* CMPE 1666 - Intermediate Programming ICA 3
 * 
 * Author: Jonathan Le
 * 
 * Purpose: the program is a timer that counts up and allows the user to
 * start, stop, reset, and split the time. The timestamps will be displayed 
 * in a list box for the user to review.
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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics.Eventing.Reader;

namespace ICA3
{
    public partial class UI_Timers_Form : Form
    {
        //initializing global variables
        Stopwatch sw = new Stopwatch();
        //for stopwatch counter in milliseconds
        long ms;
        //counter for the number of splits
        int splitCount = 0;
        bool splitCheck;

        public UI_Timers_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw = new Stopwatch();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void UI_Reset_Btn_Click(object sender, EventArgs e)
        {
            //when reset button clicked, stopwatch, timer, split count, ms, and list box will clear and reset
            UI_Timer.Start();
            sw.Reset();
            splitCount = 0;
            ms = 0;
            UI_Timer_Lbx.Items.Clear();
            UI_Timer_Lbl.Text = $"(0) 00:00:00.00";
        }

        private void UI_Timer_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void UI_Start_Btn_Click(object sender, EventArgs e)
        {
            //start button will start the timer and stopwatch
            UI_Timer.Start();
            sw.Start();
        }

        private void UI_Stop_Btn_Click(object sender, EventArgs e)
        {
            //stop button will stop the timer and stopwatch
            UI_Timer.Stop();
            sw.Stop();

        }

        private void UI_Split_Btn_Click(object sender, EventArgs e)
        {
            DisplayTime(ms, out string time);
            splitCheck = true;
            if (!UI_Timer.Enabled)
            {
                //checking for if any values in the listbox matches the current time
                foreach (string stamp in UI_Timer_Lbx.Items)
                {
                    //if any items in listbox matches the current time, user cannot split anymore
                    if (stamp.Contains(time))
                    {
                        splitCheck = false;
                    }

                }
            }
            
            //split button adds a new item to the list box when the split checker is true, so no repeat items are placed
            if (splitCheck)
            {
                UI_Timer_Lbx.Items.Add(UI_Timer_Lbl.Text);
                splitCount++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //stopwatch increments in milliseconds
            ms = sw.ElapsedMilliseconds;
            //DisplayTime() formats the time in the timer label display in the form
            DisplayTime(ms, out string time);
            UI_Timer_Lbl.Text = $"({splitCount}) {time}";

        }

        /// <summary>
        /// DisplayTime() takes a long value of milliseconds and formats the milliseconds to hundreths of a second, seconds,
        /// minutes, and hours. The values are formatted into a string and passed out.
        /// </summary>
        /// <param name="ms"></param>
        /// <param name="time"></param>
        void DisplayTime(long ms, out string time)
        {
            long hs, ss, mm, hh;
            
            //formulas to convert milliseconds into respective times and the modulo will reset the count when the count reaches a
            //specified point
            hs = (ms / 10)%100;
            ss = (ms / 1000)%60;
            mm = (ms / 60000)%60;
            hh = (ms / 3600000)%60;

            time = $"{hh:D2}:{mm:D2}:{ss:D2}.{hs:D2}";
        }
    }

}
