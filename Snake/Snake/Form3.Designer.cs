namespace Snake
{
    partial class Form3
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
            this.DelevoperInfoText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DelevoperInfoText
            // 
            this.DelevoperInfoText.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelevoperInfoText.Location = new System.Drawing.Point(12, 12);
            this.DelevoperInfoText.Multiline = true;
            this.DelevoperInfoText.Name = "DelevoperInfoText";
            this.DelevoperInfoText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DelevoperInfoText.Size = new System.Drawing.Size(684, 579);
            this.DelevoperInfoText.TabIndex = 0;
            this.DelevoperInfoText.TextChanged += new System.EventHandler(this.DelevoperInfoText_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 603);
            this.Controls.Add(this.DelevoperInfoText);
            this.Name = "Form3";
            this.Text = "developer info";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox DelevoperInfoText;
    }
}