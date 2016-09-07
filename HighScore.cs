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
    //This Windows Form displays all the gamers scores achieved so far 
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
            listHighScore.Items.Clear();
            listHighScore.Visible = true;
            
            if (bdd.connexion() == 0)
                { 
                    List<Gamer> LC = bdd.listGamer();
                    foreach (Gamer gm in LC)
                    {
                        listHighScore.Items.Add(string.Format("{0,3}",gm.pseudonym.ToString())+"|"+gm.score+"|"+gm.time.ToString());
                        
                    }
                    bdd.deconnexion();
                }

        }

       
    }
}
