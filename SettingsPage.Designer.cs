namespace SnakeProject1
{
    partial class SettingsPage
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
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.labelSound = new System.Windows.Forms.Label();
            this.comboBoxDifficultyChoice = new System.Windows.Forms.ComboBox();
            this.comboBoxSound = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.labelDifficulty.Font = new System.Drawing.Font("French Script MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDifficulty.Location = new System.Drawing.Point(171, 81);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(172, 55);
            this.labelDifficulty.TabIndex = 0;
            this.labelDifficulty.Text = "Difficulty";
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.BackColor = System.Drawing.Color.Transparent;
            this.labelSound.Font = new System.Drawing.Font("French Script MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSound.Location = new System.Drawing.Point(224, 136);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(119, 55);
            this.labelSound.TabIndex = 1;
            this.labelSound.Text = "Sound";
            // 
            // comboBoxDifficultyChoice
            // 
            this.comboBoxDifficultyChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficultyChoice.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDifficultyChoice.FormattingEnabled = true;
            this.comboBoxDifficultyChoice.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Difficult"});
            this.comboBoxDifficultyChoice.Location = new System.Drawing.Point(349, 99);
            this.comboBoxDifficultyChoice.Name = "comboBoxDifficultyChoice";
            this.comboBoxDifficultyChoice.Size = new System.Drawing.Size(121, 37);
            this.comboBoxDifficultyChoice.TabIndex = 3;
            this.comboBoxDifficultyChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxDifficultyChoice_SelectedIndexChanged);
            // 
            // comboBoxSound
            // 
            this.comboBoxSound.BackColor = System.Drawing.Color.MintCream;
            this.comboBoxSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSound.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSound.FormattingEnabled = true;
            this.comboBoxSound.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.comboBoxSound.Location = new System.Drawing.Point(349, 154);
            this.comboBoxSound.Name = "comboBoxSound";
            this.comboBoxSound.Size = new System.Drawing.Size(121, 37);
            this.comboBoxSound.TabIndex = 4;
            this.comboBoxSound.SelectedIndexChanged += new System.EventHandler(this.comboBoxSound_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("French Script MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonBack.Location = new System.Drawing.Point(21, 293);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(91, 33);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeProject1.Properties.Resources.flowers_75_wallpaper_1366x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 338);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxSound);
            this.Controls.Add(this.comboBoxDifficultyChoice);
            this.Controls.Add(this.labelSound);
            this.Controls.Add(this.labelDifficulty);
            this.KeyPreview = true;
            this.Name = "SettingsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.ComboBox comboBoxDifficultyChoice;
        private System.Windows.Forms.ComboBox comboBoxSound;
        private System.Windows.Forms.Button buttonBack;
    }
}