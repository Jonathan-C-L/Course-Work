/* CMPE 1666 - Intermediate Programming (ICA 7)
 * 
 * Author: Jonathan Le
 * 
 * Date: Feb 14, 2025
 * 
 * Purpose: program will accept file with string of numbers. The program must 
 * display the values, convert the string into their individual numbers, sort them
 * either through selection or insertion sorting methods. The ticks will be displayed
 * after sorting and displaying the sorted result.
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
using System.Diagnostics;


namespace ICA6_Jonathan_Le
{
    public partial class Form1 : Form
    {
        //global list for the parsed numbers within the file
        List<int> numbers = new List<int>();
        Stopwatch sw = new Stopwatch();
        long tick;

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
            UI_Display1_Tbx.Clear();
            //grabbing the file location of the dropped file and storing in "fileName"
            string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            //viewing the contents within the dropped file and storing it into "fileName"
            fileName = File.ReadAllText(fileName);
            string[] intermediate = fileName.Split(',');
            Format(fileName, intermediate);
            UI_Display1_Tbx.Text = string.Join(", ", numbers);
        }

        //consolidated event handler for the "Display Count", "Display Minimum", and "Display Maximum" buttons
        private void UI_Click_Event(object sender, EventArgs e)
        {
            if (sender == UI_SortVal_Btn)
            {
                //reset timer before starting on click
                sw.Reset();
                sw.Start();
                if (UI_SelectSort_Rbtn.Checked)
                {
                    //selection sort method
                    SelectionSort(numbers);
                }
                else
                {
                    //insertion sort method
                    InsertionSort(numbers);
                }
                //stop timer for the ticks to be counted
                sw.Stop();
                tick = sw.ElapsedTicks;
                //display of metrics to user
                UI_TickRate_Tbx.Text = tick.ToString();
                UI_Display2_Tbx.Text = $"{string.Join(", ", numbers)}";
            }

            if (sender == UI_ClearSort_Btn)
            {
                UI_Display2_Tbx.Clear();
            }
        }

        //METHODS

        /// <summary>
        /// Sort() method takes in the string contents of the dropped file, separates the numbers
        /// within the string, then parses and passes it to the "numbers" list.
        /// </summary>
        /// <param name="fileName"></param>
        void Format(string fileName, string[] intermediate)
        {
            int storeVal;
            foreach (string num in intermediate)
            {
                int.TryParse(num, out storeVal);
                numbers.Add(storeVal);
            }
        }
        /// <summary>
        /// SelectionSort() is a sorting algorithm with O(n^2) time complexity
        /// </summary>
        /// <param name="list"></param>
        void SelectionSort(List<int> list)
        {
            int n = list.Count;
            for (int pass = 0; pass < n - 1; pass++)//n-1 passes
            {
                //in each pass, we set max_posn to 0 and we scan the unsorted list to find
                //the next max value
                int max_posn = 0;
                int last_posn = n - 1 - pass;//last_posn is the index of the last position of unsorted list

                for (int j = 1; j <= last_posn; j++)
                {
                    if (list[j] > list[max_posn])//we have found position j having a greater value than the value at max_posn
                    {
                        max_posn = j;
                    }
                }
                Swap(list, max_posn, last_posn);
            }
        }
        /// <summary>
        /// Swap() is a helper method for the SelectionSort() method that will swap a larger number and smaller number
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="posn1"></param>
        /// <param name="posn2"></param>
        void Swap(List<int> list1, int posn1, int posn2)
        {
            int temp = list1[posn1];
            list1[posn1] = list1[posn2];
            list1[posn2] = temp;
        }

        /// <summary>
        /// InsertionSort() is a sorting algorithm that has a worse case time complexity of O(n^2) and best case O(n)
        /// </summary>
        /// <param name="list2"></param>
        void InsertionSort(List<int> list2)
        {
            int n = list2.Count;

            //we have n-1 passes, we start with p=1 (p is pass number)
            for (int p = 1; p < n; p++)
            {
                int temp = list2[p];//in each pass pick the element at position p
                int j = p - 1;//have a variable j initialied to p-1 (for iterating backwards)
                while ((j >= 0) && (list2[j] > temp))
                {
                    list2[j + 1] = list2[j];//each element bigger than temp is moved 1 position to right
                    j = j - 1;
                }
                //when leaving the while loop, we have already gone one position too far for temp
                list2[j + 1] = temp;
            }
        }
    }
}
