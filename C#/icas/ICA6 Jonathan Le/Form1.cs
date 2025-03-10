/* CMPE 1666 - Intermediate Programming (ICA 6)
 * 
 * Author: Jonathan Le
 * 
 * Date: Feb 11, 2025
 * 
 * Purpose: program will accept file with string of numbers. The program must 
 * display the values, convert the string into their individual numbers and 
 * return the number of values, minimum value, and/or maximum value when their 
 * respective buttons are pressed.
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
using System.IO;
using System.Web;

namespace ICA6_Jonathan_Le
{
    public partial class Form1 : Form
    {
        //global list for the parsed numbers within the file
        List<int> numbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        //EVENT HANDLERS
        private void DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void DragDrop(object sender, DragEventArgs e)
        {
            //ensures textbox contents will clear when a new file is dropped in
            UI_Display_Tbx.Clear();
            //grabbing the file location of the dropped file and storing in "fileName"
            string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            //viewing the contents within the dropped file and storing it into "fileName"
            fileName = File.ReadAllText(fileName);
            Display(fileName);
            string[] intermediate = fileName.Split(',');
            Convert(fileName, intermediate);

        }

        //consolidated event handler for the "Display Count", "Display Minimum", and "Display Maximum" buttons
        private void UI_Click_Event(object sender, EventArgs e)
        {
            //if click is on "Display Count" button
            if (sender == UI_DisplayCount_Btn)
            {
                //display total number of values
                UI_NumVal_Tbx.Text = numbers.Count.ToString();
            }
            //if click is on "Display Minimum" button
            else if (sender == UI_DisplayMin_Btn)
            {
                //display min value in the list
                UI_MinVal_Tbx.Text = numbers.Min().ToString();
            }
            //if click is on "Display Maximum" button
            else
            {
                //display max value in the list
                UI_MaxVal_Tbx.Text = numbers.Max().ToString();
            }
        }

        //METHODS

        /// <summary>
        /// Sort() method takes in the string contents of the dropped file, separates the numbers
        /// within the string, then parses and passes it to the "numbers" list.
        /// </summary>
        /// <param name="fileName"></param>
        void Convert(string fileName, string[] intermediate)
        {
            int storeVal;
            foreach(string num in intermediate)
            {
                int.TryParse(num, out storeVal);
                numbers.Add(storeVal);
            }
        }

        /// <summary>
        /// Display() method takes the string contents within the dropped file, adds a space
        /// after the ',' to make the format easier to view, then displays the result in the textbox
        /// </summary>
        /// <param name="fileName"></param>
        void Display(string fileName)
        {
            string fileDisplay;
            fileDisplay = fileName.Replace(",", ", ");
            UI_Display_Tbx.Text = fileDisplay;
        }
        
    }
}
