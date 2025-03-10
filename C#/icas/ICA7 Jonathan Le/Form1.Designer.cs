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
            this.components = new System.ComponentModel.Container();
            this.UI_Display2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Display1_Tbx = new System.Windows.Forms.TextBox();
            this.UI_SortVal_Lbl = new System.Windows.Forms.Label();
            this.UI_InitVal_Lbl = new System.Windows.Forms.Label();
            this.UI_SortMethod_Gbx = new System.Windows.Forms.GroupBox();
            this.UI_InsertSort_Rbtn = new System.Windows.Forms.RadioButton();
            this.UI_SelectSort_Rbtn = new System.Windows.Forms.RadioButton();
            this.UI_TickRate_Tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_DropBox_Lbl = new System.Windows.Forms.Label();
            this.UI_SortVal_Btn = new System.Windows.Forms.Button();
            this.UI_ClearSort_Btn = new System.Windows.Forms.Button();
            this.UI_Tick_Timer = new System.Windows.Forms.Timer(this.components);
            this.UI_SortMethod_Gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Display2_Tbx
            // 
            this.UI_Display2_Tbx.Location = new System.Drawing.Point(510, 61);
            this.UI_Display2_Tbx.Multiline = true;
            this.UI_Display2_Tbx.Name = "UI_Display2_Tbx";
            this.UI_Display2_Tbx.ReadOnly = true;
            this.UI_Display2_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_Display2_Tbx.Size = new System.Drawing.Size(246, 288);
            this.UI_Display2_Tbx.TabIndex = 0;
            // 
            // UI_Display1_Tbx
            // 
            this.UI_Display1_Tbx.Location = new System.Drawing.Point(12, 61);
            this.UI_Display1_Tbx.Multiline = true;
            this.UI_Display1_Tbx.Name = "UI_Display1_Tbx";
            this.UI_Display1_Tbx.ReadOnly = true;
            this.UI_Display1_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_Display1_Tbx.Size = new System.Drawing.Size(246, 288);
            this.UI_Display1_Tbx.TabIndex = 1;
            // 
            // UI_SortVal_Lbl
            // 
            this.UI_SortVal_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SortVal_Lbl.Location = new System.Drawing.Point(566, 27);
            this.UI_SortVal_Lbl.Name = "UI_SortVal_Lbl";
            this.UI_SortVal_Lbl.Size = new System.Drawing.Size(135, 31);
            this.UI_SortVal_Lbl.TabIndex = 2;
            this.UI_SortVal_Lbl.Text = "Sorted Values";
            this.UI_SortVal_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_InitVal_Lbl
            // 
            this.UI_InitVal_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_InitVal_Lbl.Location = new System.Drawing.Point(67, 27);
            this.UI_InitVal_Lbl.Name = "UI_InitVal_Lbl";
            this.UI_InitVal_Lbl.Size = new System.Drawing.Size(135, 31);
            this.UI_InitVal_Lbl.TabIndex = 3;
            this.UI_InitVal_Lbl.Text = "Initial Values";
            this.UI_InitVal_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_SortMethod_Gbx
            // 
            this.UI_SortMethod_Gbx.Controls.Add(this.UI_InsertSort_Rbtn);
            this.UI_SortMethod_Gbx.Controls.Add(this.UI_SelectSort_Rbtn);
            this.UI_SortMethod_Gbx.Location = new System.Drawing.Point(264, 93);
            this.UI_SortMethod_Gbx.Name = "UI_SortMethod_Gbx";
            this.UI_SortMethod_Gbx.Size = new System.Drawing.Size(240, 112);
            this.UI_SortMethod_Gbx.TabIndex = 4;
            this.UI_SortMethod_Gbx.TabStop = false;
            this.UI_SortMethod_Gbx.Text = "Sorting Method";
            // 
            // UI_InsertSort_Rbtn
            // 
            this.UI_InsertSort_Rbtn.AutoSize = true;
            this.UI_InsertSort_Rbtn.Location = new System.Drawing.Point(22, 73);
            this.UI_InsertSort_Rbtn.Name = "UI_InsertSort_Rbtn";
            this.UI_InsertSort_Rbtn.Size = new System.Drawing.Size(87, 17);
            this.UI_InsertSort_Rbtn.TabIndex = 1;
            this.UI_InsertSort_Rbtn.TabStop = true;
            this.UI_InsertSort_Rbtn.Text = "Insertion Sort";
            this.UI_InsertSort_Rbtn.UseVisualStyleBackColor = true;
            this.UI_InsertSort_Rbtn.CheckedChanged += new System.EventHandler(this.UI_Click_Event);
            // 
            // UI_SelectSort_Rbtn
            // 
            this.UI_SelectSort_Rbtn.AutoSize = true;
            this.UI_SelectSort_Rbtn.Checked = true;
            this.UI_SelectSort_Rbtn.Location = new System.Drawing.Point(22, 35);
            this.UI_SelectSort_Rbtn.Name = "UI_SelectSort_Rbtn";
            this.UI_SelectSort_Rbtn.Size = new System.Drawing.Size(91, 17);
            this.UI_SelectSort_Rbtn.TabIndex = 0;
            this.UI_SelectSort_Rbtn.TabStop = true;
            this.UI_SelectSort_Rbtn.Text = "Selection Sort";
            this.UI_SelectSort_Rbtn.UseVisualStyleBackColor = true;
            this.UI_SelectSort_Rbtn.CheckedChanged += new System.EventHandler(this.UI_Click_Event);
            // 
            // UI_TickRate_Tbx
            // 
            this.UI_TickRate_Tbx.Location = new System.Drawing.Point(328, 302);
            this.UI_TickRate_Tbx.Name = "UI_TickRate_Tbx";
            this.UI_TickRate_Tbx.ReadOnly = true;
            this.UI_TickRate_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_TickRate_Tbx.TabIndex = 5;
            this.UI_TickRate_Tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sorting Time (Ticks):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_DropBox_Lbl
            // 
            this.UI_DropBox_Lbl.AllowDrop = true;
            this.UI_DropBox_Lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UI_DropBox_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_DropBox_Lbl.Location = new System.Drawing.Point(9, 358);
            this.UI_DropBox_Lbl.Name = "UI_DropBox_Lbl";
            this.UI_DropBox_Lbl.Size = new System.Drawing.Size(249, 42);
            this.UI_DropBox_Lbl.TabIndex = 7;
            this.UI_DropBox_Lbl.Text = "Drop File";
            this.UI_DropBox_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DropBox_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDrop);
            this.UI_DropBox_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // UI_SortVal_Btn
            // 
            this.UI_SortVal_Btn.Location = new System.Drawing.Point(328, 229);
            this.UI_SortVal_Btn.Name = "UI_SortVal_Btn";
            this.UI_SortVal_Btn.Size = new System.Drawing.Size(100, 29);
            this.UI_SortVal_Btn.TabIndex = 8;
            this.UI_SortVal_Btn.Text = "Sort Values";
            this.UI_SortVal_Btn.UseVisualStyleBackColor = true;
            this.UI_SortVal_Btn.Click += new System.EventHandler(this.UI_Click_Event);
            // 
            // UI_ClearSort_Btn
            // 
            this.UI_ClearSort_Btn.Location = new System.Drawing.Point(584, 365);
            this.UI_ClearSort_Btn.Name = "UI_ClearSort_Btn";
            this.UI_ClearSort_Btn.Size = new System.Drawing.Size(100, 29);
            this.UI_ClearSort_Btn.TabIndex = 9;
            this.UI_ClearSort_Btn.Text = "Clear Sorted";
            this.UI_ClearSort_Btn.UseVisualStyleBackColor = true;
            this.UI_ClearSort_Btn.Click += new System.EventHandler(this.UI_Click_Event);
            // 
            // UI_Tick_Timer
            // 
            this.UI_Tick_Timer.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.UI_ClearSort_Btn);
            this.Controls.Add(this.UI_SortVal_Btn);
            this.Controls.Add(this.UI_DropBox_Lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_TickRate_Tbx);
            this.Controls.Add(this.UI_SortMethod_Gbx);
            this.Controls.Add(this.UI_InitVal_Lbl);
            this.Controls.Add(this.UI_SortVal_Lbl);
            this.Controls.Add(this.UI_Display1_Tbx);
            this.Controls.Add(this.UI_Display2_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_SortMethod_Gbx.ResumeLayout(false);
            this.UI_SortMethod_Gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Display2_Tbx;
        private System.Windows.Forms.TextBox UI_Display1_Tbx;
        private System.Windows.Forms.Label UI_SortVal_Lbl;
        private System.Windows.Forms.Label UI_InitVal_Lbl;
        private System.Windows.Forms.GroupBox UI_SortMethod_Gbx;
        private System.Windows.Forms.RadioButton UI_InsertSort_Rbtn;
        private System.Windows.Forms.RadioButton UI_SelectSort_Rbtn;
        private System.Windows.Forms.TextBox UI_TickRate_Tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UI_DropBox_Lbl;
        private System.Windows.Forms.Button UI_SortVal_Btn;
        private System.Windows.Forms.Button UI_ClearSort_Btn;
        private System.Windows.Forms.Timer UI_Tick_Timer;
    }
}

