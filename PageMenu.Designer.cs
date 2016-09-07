namespace SnakeProject1
{
    partial class PageMenu
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonInstructions = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonHighScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.Color.Yellow;
            this.buttonStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartGame.Font = new System.Drawing.Font("French Script MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.ForeColor = System.Drawing.Color.Black;
            this.buttonStartGame.Location = new System.Drawing.Point(12, 68);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(181, 38);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Start a new Game";
            this.buttonStartGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonInstructions
            // 
            this.buttonInstructions.BackColor = System.Drawing.Color.Yellow;
            this.buttonInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInstructions.Font = new System.Drawing.Font("French Script MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstructions.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonInstructions.Location = new System.Drawing.Point(12, 127);
            this.buttonInstructions.Name = "buttonInstructions";
            this.buttonInstructions.Size = new System.Drawing.Size(159, 38);
            this.buttonInstructions.TabIndex = 1;
            this.buttonInstructions.Text = "Instructions";
            this.buttonInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInstructions.UseVisualStyleBackColor = false;
            this.buttonInstructions.Click += new System.EventHandler(this.buttonInstructions_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Yellow;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSettings.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonSettings.Location = new System.Drawing.Point(12, 240);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(118, 37);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Yellow;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAbout.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.Lime;
            this.buttonAbout.Location = new System.Drawing.Point(12, 297);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(87, 34);
            this.buttonAbout.TabIndex = 3;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonHighScore
            // 
            this.buttonHighScore.BackColor = System.Drawing.Color.Yellow;
            this.buttonHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHighScore.Font = new System.Drawing.Font("French Script MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHighScore.ForeColor = System.Drawing.Color.Green;
            this.buttonHighScore.Location = new System.Drawing.Point(12, 184);
            this.buttonHighScore.Name = "buttonHighScore";
            this.buttonHighScore.Size = new System.Drawing.Size(142, 39);
            this.buttonHighScore.TabIndex = 4;
            this.buttonHighScore.Text = "HighScore";
            this.buttonHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHighScore.UseVisualStyleBackColor = false;
            this.buttonHighScore.Click += new System.EventHandler(this.buttonHighScore_Click);
            // 
            // PageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeProject1.Properties.Resources.green_snake_wallpaper_1366x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 352);
            this.Controls.Add(this.buttonHighScore);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonInstructions);
            this.Controls.Add(this.buttonStartGame);
            this.Name = "PageMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonInstructions;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHighScore;

    }
}