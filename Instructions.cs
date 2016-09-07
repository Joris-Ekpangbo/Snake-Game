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
    //This Window Form shows all of the game commands  
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();

        }
        
        //If the back button is clicked
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
