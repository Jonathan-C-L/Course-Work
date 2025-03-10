namespace ICA9_Jonathan_Le
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
            this.UI_StringRecursion_Gbx = new System.Windows.Forms.GroupBox();
            this.UI_FactorFinder_Gbx = new System.Windows.Forms.GroupBox();
            this.UI_BinaryHunter_Gbx = new System.Windows.Forms.GroupBox();
            this.UI_TestString_Tbx = new System.Windows.Forms.TextBox();
            this.UI_RecShow_Btn = new System.Windows.Forms.Button();
            this.UI_RecReverse_Btn = new System.Windows.Forms.Button();
            this.UI_FactorFinder_Nbx = new System.Windows.Forms.NumericUpDown();
            this.UI_FindFactors_Btn = new System.Windows.Forms.Button();
            this.UI_FindFactors_Tbx = new System.Windows.Forms.TextBox();
            this.UI_BinaryHunter_Tbx = new System.Windows.Forms.TextBox();
            this.UI_BinaryHunter_Btn = new System.Windows.Forms.Button();
            this.UI_BinaryResult_Tbx = new System.Windows.Forms.TextBox();
            this.UI_ReversedString_Tbx = new System.Windows.Forms.TextBox();
            this.UI_StringRecursion_Gbx.SuspendLayout();
            this.UI_FactorFinder_Gbx.SuspendLayout();
            this.UI_BinaryHunter_Gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_FactorFinder_Nbx)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_StringRecursion_Gbx
            // 
            this.UI_StringRecursion_Gbx.Controls.Add(this.UI_ReversedString_Tbx);
            this.UI_StringRecursion_Gbx.Controls.Add(this.UI_RecReverse_Btn);
            this.UI_StringRecursion_Gbx.Controls.Add(this.UI_RecShow_Btn);
            this.UI_StringRecursion_Gbx.Controls.Add(this.UI_TestString_Tbx);
            this.UI_StringRecursion_Gbx.Location = new System.Drawing.Point(12, 9);
            this.UI_StringRecursion_Gbx.Name = "UI_StringRecursion_Gbx";
            this.UI_StringRecursion_Gbx.Size = new System.Drawing.Size(572, 128);
            this.UI_StringRecursion_Gbx.TabIndex = 0;
            this.UI_StringRecursion_Gbx.TabStop = false;
            this.UI_StringRecursion_Gbx.Text = "String Recursion";
            // 
            // UI_FactorFinder_Gbx
            // 
            this.UI_FactorFinder_Gbx.Controls.Add(this.UI_FindFactors_Tbx);
            this.UI_FactorFinder_Gbx.Controls.Add(this.UI_FindFactors_Btn);
            this.UI_FactorFinder_Gbx.Controls.Add(this.UI_FactorFinder_Nbx);
            this.UI_FactorFinder_Gbx.Location = new System.Drawing.Point(12, 143);
            this.UI_FactorFinder_Gbx.Name = "UI_FactorFinder_Gbx";
            this.UI_FactorFinder_Gbx.Size = new System.Drawing.Size(572, 128);
            this.UI_FactorFinder_Gbx.TabIndex = 1;
            this.UI_FactorFinder_Gbx.TabStop = false;
            this.UI_FactorFinder_Gbx.Text = "Factor Finder";
            // 
            // UI_BinaryHunter_Gbx
            // 
            this.UI_BinaryHunter_Gbx.Controls.Add(this.UI_BinaryResult_Tbx);
            this.UI_BinaryHunter_Gbx.Controls.Add(this.UI_BinaryHunter_Btn);
            this.UI_BinaryHunter_Gbx.Controls.Add(this.UI_BinaryHunter_Tbx);
            this.UI_BinaryHunter_Gbx.Location = new System.Drawing.Point(12, 277);
            this.UI_BinaryHunter_Gbx.Name = "UI_BinaryHunter_Gbx";
            this.UI_BinaryHunter_Gbx.Size = new System.Drawing.Size(572, 128);
            this.UI_BinaryHunter_Gbx.TabIndex = 2;
            this.UI_BinaryHunter_Gbx.TabStop = false;
            this.UI_BinaryHunter_Gbx.Text = "Binary Hunter";
            // 
            // UI_TestString_Tbx
            // 
            this.UI_TestString_Tbx.Location = new System.Drawing.Point(6, 19);
            this.UI_TestString_Tbx.Name = "UI_TestString_Tbx";
            this.UI_TestString_Tbx.Size = new System.Drawing.Size(560, 20);
            this.UI_TestString_Tbx.TabIndex = 0;
            // 
            // UI_RecShow_Btn
            // 
            this.UI_RecShow_Btn.Location = new System.Drawing.Point(153, 45);
            this.UI_RecShow_Btn.Name = "UI_RecShow_Btn";
            this.UI_RecShow_Btn.Size = new System.Drawing.Size(132, 40);
            this.UI_RecShow_Btn.TabIndex = 1;
            this.UI_RecShow_Btn.Text = "Rec Show";
            this.UI_RecShow_Btn.UseVisualStyleBackColor = true;
            this.UI_RecShow_Btn.Click += new System.EventHandler(this.UI_RecursionOptions_Click);
            // 
            // UI_RecReverse_Btn
            // 
            this.UI_RecReverse_Btn.Location = new System.Drawing.Point(291, 45);
            this.UI_RecReverse_Btn.Name = "UI_RecReverse_Btn";
            this.UI_RecReverse_Btn.Size = new System.Drawing.Size(132, 40);
            this.UI_RecReverse_Btn.TabIndex = 2;
            this.UI_RecReverse_Btn.Text = "Rec Reverse";
            this.UI_RecReverse_Btn.UseVisualStyleBackColor = true;
            this.UI_RecReverse_Btn.Click += new System.EventHandler(this.UI_RecursionOptions_Click);
            // 
            // UI_FactorFinder_Nbx
            // 
            this.UI_FactorFinder_Nbx.Location = new System.Drawing.Point(176, 19);
            this.UI_FactorFinder_Nbx.Name = "UI_FactorFinder_Nbx";
            this.UI_FactorFinder_Nbx.Size = new System.Drawing.Size(224, 20);
            this.UI_FactorFinder_Nbx.TabIndex = 3;
            // 
            // UI_FindFactors_Btn
            // 
            this.UI_FindFactors_Btn.Location = new System.Drawing.Point(221, 46);
            this.UI_FindFactors_Btn.Name = "UI_FindFactors_Btn";
            this.UI_FindFactors_Btn.Size = new System.Drawing.Size(132, 40);
            this.UI_FindFactors_Btn.TabIndex = 4;
            this.UI_FindFactors_Btn.Text = "Find Factors";
            this.UI_FindFactors_Btn.UseVisualStyleBackColor = true;
            this.UI_FindFactors_Btn.Click += new System.EventHandler(this.UI_FindFactors_Btn_Click);
            // 
            // UI_FindFactors_Tbx
            // 
            this.UI_FindFactors_Tbx.Location = new System.Drawing.Point(6, 92);
            this.UI_FindFactors_Tbx.Name = "UI_FindFactors_Tbx";
            this.UI_FindFactors_Tbx.ReadOnly = true;
            this.UI_FindFactors_Tbx.Size = new System.Drawing.Size(560, 20);
            this.UI_FindFactors_Tbx.TabIndex = 5;
            // 
            // UI_BinaryHunter_Tbx
            // 
            this.UI_BinaryHunter_Tbx.Location = new System.Drawing.Point(6, 19);
            this.UI_BinaryHunter_Tbx.Name = "UI_BinaryHunter_Tbx";
            this.UI_BinaryHunter_Tbx.Size = new System.Drawing.Size(560, 20);
            this.UI_BinaryHunter_Tbx.TabIndex = 6;
            // 
            // UI_BinaryHunter_Btn
            // 
            this.UI_BinaryHunter_Btn.Location = new System.Drawing.Point(221, 45);
            this.UI_BinaryHunter_Btn.Name = "UI_BinaryHunter_Btn";
            this.UI_BinaryHunter_Btn.Size = new System.Drawing.Size(132, 40);
            this.UI_BinaryHunter_Btn.TabIndex = 7;
            this.UI_BinaryHunter_Btn.Text = "Find Uppercase";
            this.UI_BinaryHunter_Btn.UseVisualStyleBackColor = true;
            this.UI_BinaryHunter_Btn.Click += new System.EventHandler(this.UI_BinaryHunter_Btn_Click);
            // 
            // UI_BinaryResult_Tbx
            // 
            this.UI_BinaryResult_Tbx.Location = new System.Drawing.Point(6, 91);
            this.UI_BinaryResult_Tbx.Name = "UI_BinaryResult_Tbx";
            this.UI_BinaryResult_Tbx.ReadOnly = true;
            this.UI_BinaryResult_Tbx.Size = new System.Drawing.Size(560, 20);
            this.UI_BinaryResult_Tbx.TabIndex = 8;
            // 
            // UI_ReversedString_Tbx
            // 
            this.UI_ReversedString_Tbx.Location = new System.Drawing.Point(6, 91);
            this.UI_ReversedString_Tbx.Name = "UI_ReversedString_Tbx";
            this.UI_ReversedString_Tbx.ReadOnly = true;
            this.UI_ReversedString_Tbx.Size = new System.Drawing.Size(560, 20);
            this.UI_ReversedString_Tbx.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 418);
            this.Controls.Add(this.UI_BinaryHunter_Gbx);
            this.Controls.Add(this.UI_FactorFinder_Gbx);
            this.Controls.Add(this.UI_StringRecursion_Gbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_StringRecursion_Gbx.ResumeLayout(false);
            this.UI_StringRecursion_Gbx.PerformLayout();
            this.UI_FactorFinder_Gbx.ResumeLayout(false);
            this.UI_FactorFinder_Gbx.PerformLayout();
            this.UI_BinaryHunter_Gbx.ResumeLayout(false);
            this.UI_BinaryHunter_Gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_FactorFinder_Nbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_StringRecursion_Gbx;
        private System.Windows.Forms.GroupBox UI_FactorFinder_Gbx;
        private System.Windows.Forms.GroupBox UI_BinaryHunter_Gbx;
        private System.Windows.Forms.TextBox UI_ReversedString_Tbx;
        private System.Windows.Forms.Button UI_RecReverse_Btn;
        private System.Windows.Forms.Button UI_RecShow_Btn;
        private System.Windows.Forms.TextBox UI_TestString_Tbx;
        private System.Windows.Forms.TextBox UI_FindFactors_Tbx;
        private System.Windows.Forms.Button UI_FindFactors_Btn;
        private System.Windows.Forms.NumericUpDown UI_FactorFinder_Nbx;
        private System.Windows.Forms.TextBox UI_BinaryResult_Tbx;
        private System.Windows.Forms.Button UI_BinaryHunter_Btn;
        private System.Windows.Forms.TextBox UI_BinaryHunter_Tbx;
    }
}

