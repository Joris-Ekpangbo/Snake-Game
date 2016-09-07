/*
 * Created by EKPANGBO Joris and MBENGUE Pape Adama.
 * Last date modified: 26/05/2015
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeProject1
{
    internal class Input
    {
        private static Hashtable keyTable = new Hashtable();

        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }

        /// <summary>
        /// Return whether or not key is being pressed
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool KeyPressed(Keys key)
        {

            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }
    }
}
