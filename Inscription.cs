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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeProject1
{
    //This Windows Form is used for gamers registration
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        
        private void buttonValiderInscription_Click(object sender, EventArgs e)
        {
            //New Game started
            Form MyPage = new PageAccueil(textBoxPseudonym.Text);
            MyPage.Show();
                   

            //Closing the page needed for inscripton by writing pseudonym
            this.Close();
        }
    }
}
