/*
 * Created by EKPANGBO Joris and MBENGUE Pape Adama.
 * Last date modified: 26/05/2015
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject1
{
    //This class represents each gamer characterized by an idGamer, a pseudonym,
    //a score, and the time taken to reach his/her score.
    //This class implements the IComparable <Gamer> interface in order to make sorted gamer lists
    class Gamer: IComparable <Gamer>
    {
        public int idGamer { get; set; }
        public string pseudonym { get; set; }
        public int score { get; set; }
        public string time { get; set; }
        
        
        public Gamer(string pseudonym, int score, string time) {

            this.pseudonym=pseudonym;
            this.score=score;
            this.time=time;
            
            
        }
        //Here is overridden the CompareTo method
        public int CompareTo(Gamer gm)
        {
            //The comparison is made between two gamers scores
            //if the two scores are same, sort by time ascending
            if (this.score == gm.score)
                return (this.time.CompareTo(gm.time));

            //otherwise by score descending
            else
                return -(this.score-gm.score);
        }
    }
}
