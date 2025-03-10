/* CMPE 1666 - Intermediate Programming
 * 
 * Author: Jonathan Le
 * 
 * Purpose: program draws a line between the points that are stored by left clicking on the
 * graphic window. The user can continue to draw lines as much as they would like. Right 
 * clicking on the window will change the color and thickness of the line (between 1-15) randomly.
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
using System.Threading;
using GDIDrawer;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace ICA5_Jonathan_Le
{
    public partial class Form1 : Form
    {
        //initializing the line list and the CDrawer window
        List<SLine> Lines = new List<SLine>();
        CDrawer canvas = new CDrawer(800, 800, false);

        //line information
        private struct SLine
        {
            public Point _start;
            public Point _end;
            public Color _color;
            public byte _thickness;
        }

        //enums to track what the application should display
        private enum eState
        {
            Idle = 0,
            Armed = 1
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Render() method can take a struct parameter and will use the information to draw a line within the GDIDrawer window
        /// </summary>
        /// <param name="line"></param>
        void Render(SLine line)
        {

            //render an instance of the line
            canvas.AddLine(line._start.X, line._start.Y, line._end.X, line._end.Y, line._color, line._thickness);
            canvas.Render();
        }

        /// <summary>
        /// Render() method will use the globally available list of structs and uses the information in each element to create a new line
        /// in the GDIDrawer window
        /// </summary>
        void Render()
        {
            //clears all old lines for the new lines to be rendered
            canvas.Clear();
            //render all elements in the list
            for (int i = 0; i < Lines.Count; i++)
            {
                Render(Lines[i]);
                canvas.Render();
            }

        }

        //initializing variables for click counting, storing the point for the first click, and the idle/arming states
        int clickCount = 0;
        Point startPoint;

        private void UI_Polling_Timer_Tick(object sender, EventArgs e)
        {
            //part 1
            Point p;
            if (canvas.GetLastMouseLeftClick(out p))
            {
                clickCount++;
                //modulus operator returns either a 1 or 0 (0 = idle; 1 = armed)
                eState clickNum = (eState)(clickCount % 2);
                if (clickNum > eState.Idle)
                {
                    //storing the first click point
                    startPoint = p;
                    UI_State_Lbl.Text = eState.Armed.ToString();
                }
                else
                {
                    //assigning information into a line struct and then adding it to the struct list
                    SLine lineInfo = new SLine();
                    lineInfo._start = startPoint;
                    lineInfo._end = p;
                    lineInfo._color = Color.Red;
                    lineInfo._thickness = 3;
                    Lines.Add(lineInfo);
                    Render(lineInfo); //rendering the line using the specific instance of line information
                    UI_State_Lbl.Text = eState.Idle.ToString();
                }
            }

            //part 2
            if (canvas.GetLastMouseRightClick(out p))
            {
                //initializing variables for random colors and line thickness
                Random rand = new Random();
                //new line structs created to be re-added into the original list 
                SLine newLineInfo;
                for (int i = 0; i < Lines.Count; i++)
                {
                    //getting new values for the lines' color and thickness
                    newLineInfo._start = Lines[i]._start;
                    newLineInfo._end = Lines[i]._end;
                    newLineInfo._color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    newLineInfo._thickness = (byte)rand.Next(1, 16);
                    Lines[i] = newLineInfo; //new values are re-assigned back into the original list
                }
                Render();
            }
        }
    }
}
