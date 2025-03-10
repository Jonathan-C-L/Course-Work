namespace ICA6_Jonathan_Le
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_Drop_Lbl = new System.Windows.Forms.Label();
            this.UI_Display_Tbx = new System.Windows.Forms.TextBox();
            this.UI_DisplayCount_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayMin_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayMax_Btn = new System.Windows.Forms.Button();
            this.UI_NumVal_Lbl = new System.Windows.Forms.Label();
            this.UI_MinVal_Lbl = new System.Windows.Forms.Label();
            this.UI_MaxVal_Lbl = new System.Windows.Forms.Label();
            this.UI_NumVal_Tbx = new System.Windows.Forms.TextBox();
            this.UI_MinVal_Tbx = new System.Windows.Forms.TextBox();
            this.UI_MaxVal_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_Drop_Lbl
            // 
            this.UI_Drop_Lbl.AllowDrop = true;
            this.UI_Drop_Lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UI_Drop_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Drop_Lbl.Cursor = System.Windows.Forms.Cursors.Cross;
            this.UI_Drop_Lbl.Location = new System.Drawing.Point(50, 32);
            this.UI_Drop_Lbl.Name = "UI_Drop_Lbl";
            this.UI_Drop_Lbl.Size = new System.Drawing.Size(286, 61);
            this.UI_Drop_Lbl.TabIndex = 0;
            this.UI_Drop_Lbl.Text = "Drop File";
            this.UI_Drop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_Drop_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDrop);
            this.UI_Drop_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // UI_Display_Tbx
            // 
            this.UI_Display_Tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Display_Tbx.Location = new System.Drawing.Point(50, 96);
            this.UI_Display_Tbx.Multiline = true;
            this.UI_Display_Tbx.Name = "UI_Display_Tbx";
            this.UI_Display_Tbx.ReadOnly = true;
            this.UI_Display_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_Display_Tbx.Size = new System.Drawing.Size(303, 329);
            this.UI_Display_Tbx.TabIndex = 1;
            // 
            // UI_DisplayCount_Btn
            // 
            this.UI_DisplayCount_Btn.Location = new System.Drawing.Point(387, 96);
            this.UI_DisplayCount_Btn.Name = "UI_DisplayCount_Btn";
            this.UI_DisplayCount_Btn.Size = new System.Drawing.Size(119, 26);
            this.UI_DisplayCount_Btn.TabIndex = 2;
            this.UI_DisplayCount_Btn.Text = "Display Count";
            this.UI_DisplayCount_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayCount_Btn.Click += new System.EventHandler(this.UI_Click_Event);
            // 
            // UI_DisplayMin_Btn
            // 
            this.UI_DisplayMin_Btn.Location = new System.Drawing.Point(387, 128);
            this.UI_DisplayMin_Btn.Name = "UI_DisplayMin_Btn";
            this.UI_DisplayMin_Btn.Size = new System.Drawing.Size(119, 26);
            this.UI_DisplayMin_Btn.TabIndex = 3;
            this.UI_DisplayMin_Btn.Text = "Display Minimum";
            this.UI_DisplayMin_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayMin_Btn.Click += new System.EventHandler(this.UI_Click_Event);
            // 
            // UI_DisplayMax_Btn
            // 
            this.UI_DisplayMax_Btn.Location = new System.Drawing.Point(387, 160);
            this.UI_DisplayMax_Btn.Name = "UI_DisplayMax_Btn";
            this.UI_DisplayMax_Btn.Size = new System.Drawing.Size(119, 26);
            this.UI_DisplayMax_Btn.TabIndex = 4;
            this.UI_DisplayMax_Btn.Text = "Display Maximum";
            this.UI_DisplayMax_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayMax_Btn.Click += new System.EventHandler(this.UI_Click_Event);
            // 
            // UI_NumVal_Lbl
            // 
            this.UI_NumVal_Lbl.AutoSize = true;
            this.UI_NumVal_Lbl.Location = new System.Drawing.Point(538, 103);
            this.UI_NumVal_Lbl.Name = "UI_NumVal_Lbl";
            this.UI_NumVal_Lbl.Size = new System.Drawing.Size(94, 13);
            this.UI_NumVal_Lbl.TabIndex = 5;
            this.UI_NumVal_Lbl.Text = "Number of Values:";
            // 
            // UI_MinVal_Lbl
            // 
            this.UI_MinVal_Lbl.AutoSize = true;
            this.UI_MinVal_Lbl.Location = new System.Drawing.Point(551, 137);
            this.UI_MinVal_Lbl.Name = "UI_MinVal_Lbl";
            this.UI_MinVal_Lbl.Size = new System.Drawing.Size(81, 13);
            this.UI_MinVal_Lbl.TabIndex = 6;
            this.UI_MinVal_Lbl.Text = "Minimum Value:";
            // 
            // UI_MaxVal_Lbl
            // 
            this.UI_MaxVal_Lbl.AutoSize = true;
            this.UI_MaxVal_Lbl.Location = new System.Drawing.Point(548, 169);
            this.UI_MaxVal_Lbl.Name = "UI_MaxVal_Lbl";
            this.UI_MaxVal_Lbl.Size = new System.Drawing.Size(84, 13);
            this.UI_MaxVal_Lbl.TabIndex = 7;
            this.UI_MaxVal_Lbl.Text = "Maximum Value:";
            // 
            // UI_NumVal_Tbx
            // 
            this.UI_NumVal_Tbx.Location = new System.Drawing.Point(638, 100);
            this.UI_NumVal_Tbx.Name = "UI_NumVal_Tbx";
            this.UI_NumVal_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_NumVal_Tbx.TabIndex = 8;
            // 
            // UI_MinVal_Tbx
            // 
            this.UI_MinVal_Tbx.Location = new System.Drawing.Point(638, 134);
            this.UI_MinVal_Tbx.Name = "UI_MinVal_Tbx";
            this.UI_MinVal_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_MinVal_Tbx.TabIndex = 9;
            // 
            // UI_MaxVal_Tbx
            // 
            this.UI_MaxVal_Tbx.Location = new System.Drawing.Point(638, 166);
            this.UI_MaxVal_Tbx.Name = "UI_MaxVal_Tbx";
            this.UI_MaxVal_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_MaxVal_Tbx.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.UI_MaxVal_Tbx);
            this.Controls.Add(this.UI_MinVal_Tbx);
            this.Controls.Add(this.UI_NumVal_Tbx);
            this.Controls.Add(this.UI_MaxVal_Lbl);
            this.Controls.Add(this.UI_MinVal_Lbl);
            this.Controls.Add(this.UI_NumVal_Lbl);
            this.Controls.Add(this.UI_DisplayMax_Btn);
            this.Controls.Add(this.UI_DisplayMin_Btn);
            this.Controls.Add(this.UI_DisplayCount_Btn);
            this.Controls.Add(this.UI_Display_Tbx);
            this.Controls.Add(this.UI_Drop_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Drop_Lbl;
        private System.Windows.Forms.TextBox UI_Display_Tbx;
        private System.Windows.Forms.Button UI_DisplayCount_Btn;
        private System.Windows.Forms.Button UI_DisplayMin_Btn;
        private System.Windows.Forms.Button UI_DisplayMax_Btn;
        private System.Windows.Forms.Label UI_NumVal_Lbl;
        private System.Windows.Forms.Label UI_MinVal_Lbl;
        private System.Windows.Forms.Label UI_MaxVal_Lbl;
        private System.Windows.Forms.TextBox UI_NumVal_Tbx;
        private System.Windows.Forms.TextBox UI_MinVal_Tbx;
        private System.Windows.Forms.TextBox UI_MaxVal_Tbx;
    }
}

