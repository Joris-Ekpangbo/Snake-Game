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
    //This Windows Form is the first page of our game
    public partial class PageMenu : Form
    {

        public PageMenu()
        {
            InitializeComponent();
            new Settings();
            StartPage();
        }
        
        private void StartPage() { 
            
            //set settings to default
            new Settings();
        }

        //If the button 'Start a new game' is clicked
        private void buttonStartGame_Click(object sender, EventArgs e)
        {           
            Form MyPage = new Inscription();
            MyPage.Show();
          
        }
        //If the button 'Instructions' is clicked
        private void buttonInstructions_Click(object sender, EventArgs e)
        {
            Form MyPage = new Instructions();
            MyPage.Show();
            
        }

        //If the button 'Settings' is clicked
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Form MyPage = new SettingsPage();
            MyPage.Show();
          
        }

        //If the button 'About' is clicked
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            Form MyPage = new About();
            MyPage.Show();
           
        }

        //If the button 'High Score' is clicked
        private void buttonHighScore_Click(object sender, EventArgs e)
        {
           
           Form MyPage = new HighScore();
           MyPage.Show();
           if (Settings.SoundOn == true)
           {
               SoundPlayer sound = new SoundPlayer(SnakeProject1.Properties.Resources.Army_Strong_Theme_Song_TheArmy_2003285390);
               sound.Play();
               
           }
       
        }

    }
}
