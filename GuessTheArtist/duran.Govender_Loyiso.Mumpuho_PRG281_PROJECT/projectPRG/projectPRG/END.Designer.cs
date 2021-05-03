namespace projectPRG
{
    partial class END
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(177, 70);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(78, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "YOUR SCORE";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(194, 145);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(35, 13);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "label2";
            // 
            // END
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 342);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblname);
            this.Name = "END";
            this.Text = "END";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblscore;
    }
}