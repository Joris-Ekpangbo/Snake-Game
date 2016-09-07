namespace SnakeProject1
{
    partial class Inscription
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
            this.buttonValiderInscription = new System.Windows.Forms.Button();
            this.textBoxPseudonym = new System.Windows.Forms.TextBox();
            this.labelWritePseudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonValiderInscription
            // 
            this.buttonValiderInscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonValiderInscription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonValiderInscription.Font = new System.Drawing.Font("French Script MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValiderInscription.Location = new System.Drawing.Point(218, 233);
            this.buttonValiderInscription.Name = "buttonValiderInscription";
            this.buttonValiderInscription.Size = new System.Drawing.Size(81, 30);
            this.buttonValiderInscription.TabIndex = 0;
            this.buttonValiderInscription.Text = "Validate";
            this.buttonValiderInscription.UseVisualStyleBackColor = false;
            this.buttonValiderInscription.Click += new System.EventHandler(this.buttonValiderInscription_Click);
            // 
            // textBoxPseudonym
            // 
            this.textBoxPseudonym.Location = new System.Drawing.Point(185, 168);
            this.textBoxPseudonym.Name = "textBoxPseudonym";
            this.textBoxPseudonym.Size = new System.Drawing.Size(144, 20);
            this.textBoxPseudonym.TabIndex = 1;
            // 
            // labelWritePseudo
            // 
            this.labelWritePseudo.AutoSize = true;
            this.labelWritePseudo.BackColor = System.Drawing.Color.Transparent;
            this.labelWritePseudo.Font = new System.Drawing.Font("French Script MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWritePseudo.ForeColor = System.Drawing.Color.White;
            this.labelWritePseudo.Location = new System.Drawing.Point(140, 93);
            this.labelWritePseudo.Name = "labelWritePseudo";
            this.labelWritePseudo.Size = new System.Drawing.Size(250, 33);
            this.labelWritePseudo.TabIndex = 2;
            this.labelWritePseudo.Text = "Please write a pseudonym";
            this.labelWritePseudo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeProject1.Properties.Resources.camp_in_yellow_wallpaper_1366x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 362);
            this.Controls.Add(this.labelWritePseudo);
            this.Controls.Add(this.textBoxPseudonym);
            this.Controls.Add(this.buttonValiderInscription);
            this.Name = "Inscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValiderInscription;
        private System.Windows.Forms.TextBox textBoxPseudonym;
        private System.Windows.Forms.Label labelWritePseudo;
    }
}