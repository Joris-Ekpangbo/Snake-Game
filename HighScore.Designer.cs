namespace SnakeProject1
{
    partial class HighScore
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
            this.listHighScore = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listHighScore
            // 
            this.listHighScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listHighScore.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHighScore.ForeColor = System.Drawing.Color.White;
            this.listHighScore.FormattingEnabled = true;
            this.listHighScore.ItemHeight = 27;
            this.listHighScore.Location = new System.Drawing.Point(2, 32);
            this.listHighScore.Name = "listHighScore";
            this.listHighScore.Size = new System.Drawing.Size(282, 247);
            this.listHighScore.TabIndex = 0;
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeProject1.Properties.Resources.lion_7_wallpaper_1366x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 306);
            this.Controls.Add(this.listHighScore);
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listHighScore;
    }
}