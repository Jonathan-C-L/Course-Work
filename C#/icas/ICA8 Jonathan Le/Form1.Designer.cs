namespace ICA8_Jonathan_Le
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
            this.UI_Load_Btn = new System.Windows.Forms.Button();
            this.UI_Shuffle_Btn = new System.Windows.Forms.Button();
            this.UI_Deal_Btn = new System.Windows.Forms.Button();
            this.UI_Winner_Btn = new System.Windows.Forms.Button();
            this.UI_Starting_Lbx = new System.Windows.Forms.ListBox();
            this.UI_Shuffled_Lbx = new System.Windows.Forms.ListBox();
            this.UI_Hands_Lbx = new System.Windows.Forms.ListBox();
            this.UI_Winner_Tbx = new System.Windows.Forms.TextBox();
            this.UI_StartingDeck_Lbl = new System.Windows.Forms.Label();
            this.UI_ShuffledDeck_Lbl = new System.Windows.Forms.Label();
            this.UI_PlayerHands_Lbl = new System.Windows.Forms.Label();
            this.UI_Winner_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Load_Btn
            // 
            this.UI_Load_Btn.Location = new System.Drawing.Point(12, 98);
            this.UI_Load_Btn.Name = "UI_Load_Btn";
            this.UI_Load_Btn.Size = new System.Drawing.Size(147, 41);
            this.UI_Load_Btn.TabIndex = 0;
            this.UI_Load_Btn.Text = "Load Cards";
            this.UI_Load_Btn.UseVisualStyleBackColor = true;
            this.UI_Load_Btn.Click += new System.EventHandler(this.Button_Clicks);
            // 
            // UI_Shuffle_Btn
            // 
            this.UI_Shuffle_Btn.Location = new System.Drawing.Point(12, 157);
            this.UI_Shuffle_Btn.Name = "UI_Shuffle_Btn";
            this.UI_Shuffle_Btn.Size = new System.Drawing.Size(147, 41);
            this.UI_Shuffle_Btn.TabIndex = 1;
            this.UI_Shuffle_Btn.Text = "Shuffle Cards";
            this.UI_Shuffle_Btn.UseVisualStyleBackColor = true;
            this.UI_Shuffle_Btn.Click += new System.EventHandler(this.Button_Clicks);
            // 
            // UI_Deal_Btn
            // 
            this.UI_Deal_Btn.Location = new System.Drawing.Point(12, 217);
            this.UI_Deal_Btn.Name = "UI_Deal_Btn";
            this.UI_Deal_Btn.Size = new System.Drawing.Size(147, 41);
            this.UI_Deal_Btn.TabIndex = 2;
            this.UI_Deal_Btn.Text = "Deal Hands";
            this.UI_Deal_Btn.UseVisualStyleBackColor = true;
            this.UI_Deal_Btn.Click += new System.EventHandler(this.Button_Clicks);
            // 
            // UI_Winner_Btn
            // 
            this.UI_Winner_Btn.Location = new System.Drawing.Point(12, 278);
            this.UI_Winner_Btn.Name = "UI_Winner_Btn";
            this.UI_Winner_Btn.Size = new System.Drawing.Size(147, 41);
            this.UI_Winner_Btn.TabIndex = 3;
            this.UI_Winner_Btn.Text = "Determine Winner";
            this.UI_Winner_Btn.UseVisualStyleBackColor = true;
            this.UI_Winner_Btn.Click += new System.EventHandler(this.Button_Clicks);
            // 
            // UI_Starting_Lbx
            // 
            this.UI_Starting_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UI_Starting_Lbx.FormattingEnabled = true;
            this.UI_Starting_Lbx.Location = new System.Drawing.Point(177, 41);
            this.UI_Starting_Lbx.Name = "UI_Starting_Lbx";
            this.UI_Starting_Lbx.Size = new System.Drawing.Size(204, 329);
            this.UI_Starting_Lbx.TabIndex = 4;
            // 
            // UI_Shuffled_Lbx
            // 
            this.UI_Shuffled_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UI_Shuffled_Lbx.FormattingEnabled = true;
            this.UI_Shuffled_Lbx.Location = new System.Drawing.Point(409, 41);
            this.UI_Shuffled_Lbx.Name = "UI_Shuffled_Lbx";
            this.UI_Shuffled_Lbx.Size = new System.Drawing.Size(204, 329);
            this.UI_Shuffled_Lbx.TabIndex = 5;
            // 
            // UI_Hands_Lbx
            // 
            this.UI_Hands_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UI_Hands_Lbx.FormattingEnabled = true;
            this.UI_Hands_Lbx.Location = new System.Drawing.Point(638, 41);
            this.UI_Hands_Lbx.Name = "UI_Hands_Lbx";
            this.UI_Hands_Lbx.Size = new System.Drawing.Size(204, 329);
            this.UI_Hands_Lbx.TabIndex = 6;
            // 
            // UI_Winner_Tbx
            // 
            this.UI_Winner_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Winner_Tbx.Location = new System.Drawing.Point(638, 407);
            this.UI_Winner_Tbx.Name = "UI_Winner_Tbx";
            this.UI_Winner_Tbx.ReadOnly = true;
            this.UI_Winner_Tbx.Size = new System.Drawing.Size(204, 20);
            this.UI_Winner_Tbx.TabIndex = 7;
            // 
            // UI_StartingDeck_Lbl
            // 
            this.UI_StartingDeck_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UI_StartingDeck_Lbl.Location = new System.Drawing.Point(177, 15);
            this.UI_StartingDeck_Lbl.Name = "UI_StartingDeck_Lbl";
            this.UI_StartingDeck_Lbl.Size = new System.Drawing.Size(204, 23);
            this.UI_StartingDeck_Lbl.TabIndex = 8;
            this.UI_StartingDeck_Lbl.Text = "Starting Deck";
            this.UI_StartingDeck_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_ShuffledDeck_Lbl
            // 
            this.UI_ShuffledDeck_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UI_ShuffledDeck_Lbl.Location = new System.Drawing.Point(409, 15);
            this.UI_ShuffledDeck_Lbl.Name = "UI_ShuffledDeck_Lbl";
            this.UI_ShuffledDeck_Lbl.Size = new System.Drawing.Size(204, 23);
            this.UI_ShuffledDeck_Lbl.TabIndex = 9;
            this.UI_ShuffledDeck_Lbl.Text = "Shuffled Deck";
            this.UI_ShuffledDeck_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_PlayerHands_Lbl
            // 
            this.UI_PlayerHands_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UI_PlayerHands_Lbl.Location = new System.Drawing.Point(638, 15);
            this.UI_PlayerHands_Lbl.Name = "UI_PlayerHands_Lbl";
            this.UI_PlayerHands_Lbl.Size = new System.Drawing.Size(204, 23);
            this.UI_PlayerHands_Lbl.TabIndex = 10;
            this.UI_PlayerHands_Lbl.Text = "Players Hands";
            this.UI_PlayerHands_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Winner_Lbl
            // 
            this.UI_Winner_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Winner_Lbl.Location = new System.Drawing.Point(638, 381);
            this.UI_Winner_Lbl.Name = "UI_Winner_Lbl";
            this.UI_Winner_Lbl.Size = new System.Drawing.Size(204, 23);
            this.UI_Winner_Lbl.TabIndex = 11;
            this.UI_Winner_Lbl.Text = "Winner";
            this.UI_Winner_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.UI_Winner_Lbl);
            this.Controls.Add(this.UI_PlayerHands_Lbl);
            this.Controls.Add(this.UI_ShuffledDeck_Lbl);
            this.Controls.Add(this.UI_StartingDeck_Lbl);
            this.Controls.Add(this.UI_Winner_Tbx);
            this.Controls.Add(this.UI_Hands_Lbx);
            this.Controls.Add(this.UI_Shuffled_Lbx);
            this.Controls.Add(this.UI_Starting_Lbx);
            this.Controls.Add(this.UI_Winner_Btn);
            this.Controls.Add(this.UI_Deal_Btn);
            this.Controls.Add(this.UI_Shuffle_Btn);
            this.Controls.Add(this.UI_Load_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Load_Btn;
        private System.Windows.Forms.Button UI_Shuffle_Btn;
        private System.Windows.Forms.Button UI_Deal_Btn;
        private System.Windows.Forms.Button UI_Winner_Btn;
        private System.Windows.Forms.ListBox UI_Starting_Lbx;
        private System.Windows.Forms.ListBox UI_Shuffled_Lbx;
        private System.Windows.Forms.ListBox UI_Hands_Lbx;
        private System.Windows.Forms.TextBox UI_Winner_Tbx;
        private System.Windows.Forms.Label UI_StartingDeck_Lbl;
        private System.Windows.Forms.Label UI_ShuffledDeck_Lbl;
        private System.Windows.Forms.Label UI_PlayerHands_Lbl;
        private System.Windows.Forms.Label UI_Winner_Lbl;
    }
}

