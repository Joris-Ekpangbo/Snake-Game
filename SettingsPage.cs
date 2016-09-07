/*
 * Created by EKPANGBO Joris and MBENGUE Pape Adama.
 * Last date modified: 26/05/2015
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeProject1
{
    public partial class SettingsPage : Form
    {
        public static int difficultyChoice = 1, soundPlaying = 1;
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void comboBoxDifficultyChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //For each choice made in the comboBox comboBoxDifficultyChoice,
            //an integer difficultyChoice is implemented in order to be used lately
            if (comboBoxDifficultyChoice.SelectedItem.ToString().Equals("Easy"))
                difficultyChoice = 0;
                
            if (comboBoxDifficultyChoice.SelectedItem.ToString().Equals("Medium"))
                difficultyChoice = 1;

            if (comboBoxDifficultyChoice.SelectedItem.ToString().Equals("Difficult"))
                difficultyChoice = 2;
            
        }

        //What happens when the back button is clicked
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxSound_SelectedIndexChanged(object sender, EventArgs e)
        {
            //For each choice made in the comboBox comboBoxSound,
            //an integer soundPlaying is implemented in order to be used lately
            if (comboBoxSound.SelectedItem.ToString().Equals("Enable")) {
                soundPlaying = 1;

            } if (comboBoxSound.SelectedItem.ToString().Equals("Disable"))
            {
                soundPlaying = 0;

            }
        }

    }
}
