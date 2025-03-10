namespace ICA5_Jonathan_Le
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
            this.UI_State_Lbl = new System.Windows.Forms.Label();
            this.UI_Polling_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_State_Lbl
            // 
            this.UI_State_Lbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_State_Lbl.Location = new System.Drawing.Point(142, 83);
            this.UI_State_Lbl.Name = "UI_State_Lbl";
            this.UI_State_Lbl.Size = new System.Drawing.Size(181, 55);
            this.UI_State_Lbl.TabIndex = 0;
            this.UI_State_Lbl.Text = "Idle";
            this.UI_State_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Polling_Timer
            // 
            this.UI_Polling_Timer.Enabled = true;
            this.UI_Polling_Timer.Interval = 50;
            this.UI_Polling_Timer.Tick += new System.EventHandler(this.UI_Polling_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 241);
            this.Controls.Add(this.UI_State_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UI_State_Lbl;
        private System.Windows.Forms.Timer UI_Polling_Timer;
    }
}

