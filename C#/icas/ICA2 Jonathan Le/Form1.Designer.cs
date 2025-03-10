namespace ICA2_Jonathan_Le
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.UI_Activated_Event);
            this.Deactivate += new System.EventHandler(this.UI_Deactivate_Event);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_Closing_Event);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_Closed_Event);
            this.Load += new System.EventHandler(this.UI_Load_Form);
            this.Shown += new System.EventHandler(this.UI_Shown_Event);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UI_Paint_Event);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

