namespace ICA4_Jonathan_Le
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
            this.UI_Name_Lbl = new System.Windows.Forms.Label();
            this.UI_Name_Tbx = new System.Windows.Forms.TextBox();
            this.UI_CarType_Gbx = new System.Windows.Forms.GroupBox();
            this.UI_Sports_Rbtn = new System.Windows.Forms.RadioButton();
            this.UI_MidSize_Rbtn = new System.Windows.Forms.RadioButton();
            this.UI_Small_RBtn = new System.Windows.Forms.RadioButton();
            this.UI_Insurance_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_AMA_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_Days_Lbx = new System.Windows.Forms.ListBox();
            this.UI_Days_Lbl = new System.Windows.Forms.Label();
            this.UI_Total_Lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_CarType_Gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Name_Lbl
            // 
            this.UI_Name_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Name_Lbl.Location = new System.Drawing.Point(168, 65);
            this.UI_Name_Lbl.Name = "UI_Name_Lbl";
            this.UI_Name_Lbl.Size = new System.Drawing.Size(46, 20);
            this.UI_Name_Lbl.TabIndex = 8;
            this.UI_Name_Lbl.Text = "Name";
            this.UI_Name_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Name_Tbx
            // 
            this.UI_Name_Tbx.Location = new System.Drawing.Point(220, 64);
            this.UI_Name_Tbx.Name = "UI_Name_Tbx";
            this.UI_Name_Tbx.Size = new System.Drawing.Size(396, 20);
            this.UI_Name_Tbx.TabIndex = 0;
            // 
            // UI_CarType_Gbx
            // 
            this.UI_CarType_Gbx.Controls.Add(this.UI_Sports_Rbtn);
            this.UI_CarType_Gbx.Controls.Add(this.UI_MidSize_Rbtn);
            this.UI_CarType_Gbx.Controls.Add(this.UI_Small_RBtn);
            this.UI_CarType_Gbx.Location = new System.Drawing.Point(94, 144);
            this.UI_CarType_Gbx.Name = "UI_CarType_Gbx";
            this.UI_CarType_Gbx.Size = new System.Drawing.Size(276, 98);
            this.UI_CarType_Gbx.TabIndex = 4;
            this.UI_CarType_Gbx.TabStop = false;
            this.UI_CarType_Gbx.Text = "Car Type";
            // 
            // UI_Sports_Rbtn
            // 
            this.UI_Sports_Rbtn.AutoSize = true;
            this.UI_Sports_Rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Sports_Rbtn.Location = new System.Drawing.Point(12, 65);
            this.UI_Sports_Rbtn.Name = "UI_Sports_Rbtn";
            this.UI_Sports_Rbtn.Size = new System.Drawing.Size(105, 20);
            this.UI_Sports_Rbtn.TabIndex = 2;
            this.UI_Sports_Rbtn.Text = "Sports $60.00";
            this.UI_Sports_Rbtn.UseVisualStyleBackColor = true;
            // 
            // UI_MidSize_Rbtn
            // 
            this.UI_MidSize_Rbtn.AutoSize = true;
            this.UI_MidSize_Rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MidSize_Rbtn.Location = new System.Drawing.Point(12, 42);
            this.UI_MidSize_Rbtn.Name = "UI_MidSize_Rbtn";
            this.UI_MidSize_Rbtn.Size = new System.Drawing.Size(139, 20);
            this.UI_MidSize_Rbtn.TabIndex = 1;
            this.UI_MidSize_Rbtn.Text = "Midsize $50.00/day";
            this.UI_MidSize_Rbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Small_RBtn
            // 
            this.UI_Small_RBtn.AutoSize = true;
            this.UI_Small_RBtn.Checked = true;
            this.UI_Small_RBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Small_RBtn.Location = new System.Drawing.Point(12, 19);
            this.UI_Small_RBtn.Name = "UI_Small_RBtn";
            this.UI_Small_RBtn.Size = new System.Drawing.Size(127, 20);
            this.UI_Small_RBtn.TabIndex = 0;
            this.UI_Small_RBtn.TabStop = true;
            this.UI_Small_RBtn.Text = "Small $40.00/day";
            this.UI_Small_RBtn.UseVisualStyleBackColor = true;
            // 
            // UI_Insurance_Cbx
            // 
            this.UI_Insurance_Cbx.AutoSize = true;
            this.UI_Insurance_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Insurance_Cbx.Location = new System.Drawing.Point(535, 163);
            this.UI_Insurance_Cbx.Name = "UI_Insurance_Cbx";
            this.UI_Insurance_Cbx.Size = new System.Drawing.Size(152, 20);
            this.UI_Insurance_Cbx.TabIndex = 1;
            this.UI_Insurance_Cbx.Text = "Insurance $15.00/day";
            this.UI_Insurance_Cbx.UseVisualStyleBackColor = true;
            // 
            // UI_AMA_Cbx
            // 
            this.UI_AMA_Cbx.AutoSize = true;
            this.UI_AMA_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_AMA_Cbx.Location = new System.Drawing.Point(535, 186);
            this.UI_AMA_Cbx.Name = "UI_AMA_Cbx";
            this.UI_AMA_Cbx.Size = new System.Drawing.Size(143, 20);
            this.UI_AMA_Cbx.TabIndex = 2;
            this.UI_AMA_Cbx.Text = "AMA Discount -10%";
            this.UI_AMA_Cbx.UseVisualStyleBackColor = true;
            // 
            // UI_Days_Lbx
            // 
            this.UI_Days_Lbx.FormattingEnabled = true;
            this.UI_Days_Lbx.Location = new System.Drawing.Point(651, 209);
            this.UI_Days_Lbx.Name = "UI_Days_Lbx";
            this.UI_Days_Lbx.Size = new System.Drawing.Size(51, 17);
            this.UI_Days_Lbx.TabIndex = 3;
            // 
            // UI_Days_Lbl
            // 
            this.UI_Days_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Days_Lbl.Location = new System.Drawing.Point(532, 209);
            this.UI_Days_Lbl.Name = "UI_Days_Lbl";
            this.UI_Days_Lbl.Size = new System.Drawing.Size(113, 17);
            this.UI_Days_Lbl.TabIndex = 5;
            this.UI_Days_Lbl.Text = "Number of Days";
            this.UI_Days_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Total_Lbl
            // 
            this.UI_Total_Lbl.AutoSize = true;
            this.UI_Total_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Total_Lbl.Location = new System.Drawing.Point(276, 332);
            this.UI_Total_Lbl.Name = "UI_Total_Lbl";
            this.UI_Total_Lbl.Size = new System.Drawing.Size(94, 39);
            this.UI_Total_Lbl.TabIndex = 6;
            this.UI_Total_Lbl.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UI_Total_Lbl);
            this.Controls.Add(this.UI_Days_Lbl);
            this.Controls.Add(this.UI_Days_Lbx);
            this.Controls.Add(this.UI_AMA_Cbx);
            this.Controls.Add(this.UI_Insurance_Cbx);
            this.Controls.Add(this.UI_CarType_Gbx);
            this.Controls.Add(this.UI_Name_Tbx);
            this.Controls.Add(this.UI_Name_Lbl);
            this.Name = "Form1";
            this.Text = "Car Rental";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UI_CarType_Gbx.ResumeLayout(false);
            this.UI_CarType_Gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Name_Lbl;
        private System.Windows.Forms.TextBox UI_Name_Tbx;
        private System.Windows.Forms.GroupBox UI_CarType_Gbx;
        private System.Windows.Forms.RadioButton UI_Small_RBtn;
        private System.Windows.Forms.CheckBox UI_Insurance_Cbx;
        private System.Windows.Forms.RadioButton UI_Sports_Rbtn;
        private System.Windows.Forms.RadioButton UI_MidSize_Rbtn;
        private System.Windows.Forms.CheckBox UI_AMA_Cbx;
        private System.Windows.Forms.ListBox UI_Days_Lbx;
        private System.Windows.Forms.Label UI_Days_Lbl;
        private System.Windows.Forms.Label UI_Total_Lbl;
        private System.Windows.Forms.Label label4;
    }
}

