namespace HelpCookies
{
    partial class Cookie
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
            this.timeBar = new System.Windows.Forms.ProgressBar();
            this.incBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timeBar
            // 
            this.timeBar.Location = new System.Drawing.Point(12, 84);
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(618, 29);
            this.timeBar.TabIndex = 0;
            // 
            // incBar
            // 
            this.incBar.Location = new System.Drawing.Point(12, 48);
            this.incBar.Name = "incBar";
            this.incBar.Size = new System.Drawing.Size(618, 29);
            this.incBar.TabIndex = 1;
            // 
            // Cookie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 125);
            this.Controls.Add(this.incBar);
            this.Controls.Add(this.timeBar);
            this.Name = "Cookie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cookie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar timeBar;
        private System.Windows.Forms.ProgressBar incBar;
    }
}

