/*
 * Created by EKPANGBO Joris and MBENGUE Pape Adama.
 * Date: 03/05/2015
 * Time: 14:28
 */

namespace SnakeProject1
{
    partial class PageAccueil
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
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.labelOfScore = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelStopwatch = new System.Windows.Forms.Label();
            this.stopWatch = new System.Windows.Forms.Timer(this.components);
            this.labelPseudo = new System.Windows.Forms.Label();
            this.labelPseudonym = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.GhostWhite;
            this.pbCanvas.Location = new System.Drawing.Point(21, 12);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(396, 270);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // labelOfScore
            // 
            this.labelOfScore.AutoSize = true;
            this.labelOfScore.BackColor = System.Drawing.Color.Transparent;
            this.labelOfScore.Font = new System.Drawing.Font("French Script MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfScore.ForeColor = System.Drawing.Color.Yellow;
            this.labelOfScore.Location = new System.Drawing.Point(462, 27);
            this.labelOfScore.Name = "labelOfScore";
            this.labelOfScore.Size = new System.Drawing.Size(68, 31);
            this.labelOfScore.TabIndex = 1;
            this.labelOfScore.Text = "Score:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("French Script MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Yellow;
            this.labelScore.Location = new System.Drawing.Point(561, 32);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 24);
            this.labelScore.TabIndex = 2;
            // 
            // labelStopwatch
            // 
            this.labelStopwatch.AutoSize = true;
            this.labelStopwatch.BackColor = System.Drawing.Color.Transparent;
            this.labelStopwatch.Font = new System.Drawing.Font("French Script MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopwatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelStopwatch.Location = new System.Drawing.Point(462, 73);
            this.labelStopwatch.Name = "labelStopwatch";
            this.labelStopwatch.Size = new System.Drawing.Size(92, 31);
            this.labelStopwatch.TabIndex = 3;
            this.labelStopwatch.Text = "00:00:00";
            // 
            // stopWatch
            // 
            this.stopWatch.Enabled = true;
            this.stopWatch.Tick += new System.EventHandler(this.stopWatch_Tick);
            // 
            // labelPseudo
            // 
            this.labelPseudo.AutoSize = true;
            this.labelPseudo.BackColor = System.Drawing.Color.Transparent;
            this.labelPseudo.Font = new System.Drawing.Font("French Script MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPseudo.ForeColor = System.Drawing.Color.Brown;
            this.labelPseudo.Location = new System.Drawing.Point(582, 121);
            this.labelPseudo.Name = "labelPseudo";
            this.labelPseudo.Size = new System.Drawing.Size(0, 31);
            this.labelPseudo.TabIndex = 6;
            // 
            // labelPseudonym
            // 
            this.labelPseudonym.AutoSize = true;
            this.labelPseudonym.BackColor = System.Drawing.Color.Transparent;
            this.labelPseudonym.Font = new System.Drawing.Font("French Script MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPseudonym.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPseudonym.Location = new System.Drawing.Point(462, 121);
            this.labelPseudonym.Name = "labelPseudonym";
            this.labelPseudonym.Size = new System.Drawing.Size(114, 31);
            this.labelPseudonym.TabIndex = 5;
            this.labelPseudonym.Text = "Pseudonym:";
            // 
            // PageAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeProject1.Properties.Resources.green_boa_constrictor_wallpaper_1366x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(644, 323);
            this.Controls.Add(this.labelPseudo);
            this.Controls.Add(this.labelPseudonym);
            this.Controls.Add(this.labelStopwatch);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelOfScore);
            this.Controls.Add(this.pbCanvas);
            this.Name = "PageAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageAccueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PageAccueil_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PageAccueil_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PageAccueil_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label labelOfScore;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label labelStopwatch;
        private System.Windows.Forms.Timer stopWatch;
        private System.Windows.Forms.Label labelPseudo;
        private System.Windows.Forms.Label labelPseudonym;
    }
}