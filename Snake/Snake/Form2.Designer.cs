namespace Snake
{
    partial class Form2
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SnakeColorSelectButton = new System.Windows.Forms.Button();
            this.BackgroundColorSelectButton = new System.Windows.Forms.Button();
            this.SelectLevelButton = new System.Windows.Forms.Button();
            this.CurrentSpeedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SnakeColorSelectButton
            // 
            this.SnakeColorSelectButton.Location = new System.Drawing.Point(46, 14);
            this.SnakeColorSelectButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SnakeColorSelectButton.Name = "SnakeColorSelectButton";
            this.SnakeColorSelectButton.Size = new System.Drawing.Size(273, 85);
            this.SnakeColorSelectButton.TabIndex = 0;
            this.SnakeColorSelectButton.Text = "select snake color";
            this.SnakeColorSelectButton.UseVisualStyleBackColor = true;
            this.SnakeColorSelectButton.Click += new System.EventHandler(this.SnakeColorSelectButton_Click);
            SnakeColorSelectButton.BackColor = Palette.SnakeBody;
            // 
            // BackgroundColorSelectButton
            // 
            this.BackgroundColorSelectButton.Location = new System.Drawing.Point(46, 109);
            this.BackgroundColorSelectButton.Margin = new System.Windows.Forms.Padding(5);
            this.BackgroundColorSelectButton.Name = "BackgroundColorSelectButton";
            this.BackgroundColorSelectButton.Size = new System.Drawing.Size(273, 85);
            this.BackgroundColorSelectButton.TabIndex = 0;
            this.BackgroundColorSelectButton.Text = "select background color";
            this.BackgroundColorSelectButton.UseVisualStyleBackColor = true;
            this.BackgroundColorSelectButton.Click += new System.EventHandler(this.BackgroundColorSelectButton_Click);
            BackgroundColorSelectButton.BackColor = Palette.FieldBackground;
            // 
            // SelectLevelButton
            // 
            this.SelectLevelButton.Location = new System.Drawing.Point(46, 204);
            this.SelectLevelButton.Margin = new System.Windows.Forms.Padding(5);
            this.SelectLevelButton.Name = "SelectLevelButton";
            this.SelectLevelButton.Size = new System.Drawing.Size(188, 85);
            this.SelectLevelButton.TabIndex = 0;
            this.SelectLevelButton.Text = "change start speed";
            this.SelectLevelButton.UseVisualStyleBackColor = true;
            this.SelectLevelButton.Click += new System.EventHandler(this.SelectLevelButton_Click);
            // 
            // CurrentSpeedLabel
            // 
            this.CurrentSpeedLabel.AutoSize = true;
            this.CurrentSpeedLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentSpeedLabel.Location = new System.Drawing.Point(254, 214);
            this.CurrentSpeedLabel.Name = "CurrentSpeedLabel";
            this.CurrentSpeedLabel.Size = new System.Drawing.Size(54, 65);
            this.CurrentSpeedLabel.TabIndex = 1;
            this.CurrentSpeedLabel.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 366);
            this.Controls.Add(this.CurrentSpeedLabel);
            this.Controls.Add(this.SelectLevelButton);
            this.Controls.Add(this.BackgroundColorSelectButton);
            this.Controls.Add(this.SnakeColorSelectButton);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorDialog colorDialog1;
        private Button SnakeColorSelectButton;
        private Button BackgroundColorSelectButton;
        private Button SelectLevelButton;
        private Label CurrentSpeedLabel;
    }
}