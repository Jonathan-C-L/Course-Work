namespace ICA3
{
    partial class UI_Timers_Form
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
            this.UI_Timer_Lbl = new System.Windows.Forms.Label();
            this.UI_Start_Btn = new System.Windows.Forms.Button();
            this.UI_Stop_Btn = new System.Windows.Forms.Button();
            this.UI_Reset_Btn = new System.Windows.Forms.Button();
            this.UI_Split_Btn = new System.Windows.Forms.Button();
            this.UI_Timer_Lbx = new System.Windows.Forms.ListBox();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_Timer_Lbl
            // 
            this.UI_Timer_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Timer_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Timer_Lbl.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Timer_Lbl.Location = new System.Drawing.Point(12, 9);
            this.UI_Timer_Lbl.Name = "UI_Timer_Lbl";
            this.UI_Timer_Lbl.Size = new System.Drawing.Size(290, 74);
            this.UI_Timer_Lbl.TabIndex = 4;
            this.UI_Timer_Lbl.Text = "(0) 00:00:00.00";
            this.UI_Timer_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_Timer_Lbl.Click += new System.EventHandler(this.UI_Timer_Lbl_Click);
            // 
            // UI_Start_Btn
            // 
            this.UI_Start_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UI_Start_Btn.Location = new System.Drawing.Point(227, 86);
            this.UI_Start_Btn.Name = "UI_Start_Btn";
            this.UI_Start_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Start_Btn.TabIndex = 0;
            this.UI_Start_Btn.Text = "Start";
            this.UI_Start_Btn.UseVisualStyleBackColor = true;
            this.UI_Start_Btn.Click += new System.EventHandler(this.UI_Start_Btn_Click);
            // 
            // UI_Stop_Btn
            // 
            this.UI_Stop_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UI_Stop_Btn.Location = new System.Drawing.Point(227, 115);
            this.UI_Stop_Btn.Name = "UI_Stop_Btn";
            this.UI_Stop_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Stop_Btn.TabIndex = 2;
            this.UI_Stop_Btn.Text = "Stop";
            this.UI_Stop_Btn.UseVisualStyleBackColor = true;
            this.UI_Stop_Btn.Click += new System.EventHandler(this.UI_Stop_Btn_Click);
            // 
            // UI_Reset_Btn
            // 
            this.UI_Reset_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UI_Reset_Btn.Location = new System.Drawing.Point(227, 144);
            this.UI_Reset_Btn.Name = "UI_Reset_Btn";
            this.UI_Reset_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Reset_Btn.TabIndex = 3;
            this.UI_Reset_Btn.Text = "Reset";
            this.UI_Reset_Btn.UseVisualStyleBackColor = true;
            this.UI_Reset_Btn.Click += new System.EventHandler(this.UI_Reset_Btn_Click);
            // 
            // UI_Split_Btn
            // 
            this.UI_Split_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UI_Split_Btn.Location = new System.Drawing.Point(227, 417);
            this.UI_Split_Btn.Name = "UI_Split_Btn";
            this.UI_Split_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Split_Btn.TabIndex = 1;
            this.UI_Split_Btn.Text = "Split";
            this.UI_Split_Btn.UseVisualStyleBackColor = true;
            this.UI_Split_Btn.Click += new System.EventHandler(this.UI_Split_Btn_Click);
            // 
            // UI_Timer_Lbx
            // 
            this.UI_Timer_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Timer_Lbx.FormattingEnabled = true;
            this.UI_Timer_Lbx.IntegralHeight = false;
            this.UI_Timer_Lbx.Location = new System.Drawing.Point(12, 86);
            this.UI_Timer_Lbx.Name = "UI_Timer_Lbx";
            this.UI_Timer_Lbx.Size = new System.Drawing.Size(209, 355);
            this.UI_Timer_Lbx.TabIndex = 5;
            this.UI_Timer_Lbx.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UI_Timer
            // 
            this.UI_Timer.Interval = 20;
            this.UI_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UI_Timers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 453);
            this.Controls.Add(this.UI_Timer_Lbx);
            this.Controls.Add(this.UI_Split_Btn);
            this.Controls.Add(this.UI_Reset_Btn);
            this.Controls.Add(this.UI_Stop_Btn);
            this.Controls.Add(this.UI_Start_Btn);
            this.Controls.Add(this.UI_Timer_Lbl);
            this.Name = "UI_Timers_Form";
            this.Text = "Timers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UI_Timer_Lbl;
        private System.Windows.Forms.Button UI_Start_Btn;
        private System.Windows.Forms.Button UI_Stop_Btn;
        private System.Windows.Forms.Button UI_Reset_Btn;
        private System.Windows.Forms.Button UI_Split_Btn;
        private System.Windows.Forms.ListBox UI_Timer_Lbx;
        private System.Windows.Forms.Timer UI_Timer;
    }
}

