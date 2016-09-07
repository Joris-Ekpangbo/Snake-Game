/*
 * Created by EKPANGBO Joris and MBENGUE Pape Adama.
 * Last date modified: 26/05/2015
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SnakeProject1
{
    class bdd
    {
        //For the connection with the database snakedatabase
        public static string connectionString = "Server=localhost;Database=snakedatabase;Uid=root;Pwd=";

        //This integer is used to guarantee that a gamer is successfully added to our database table highscore_table
        public static int gamerAdded = 0;

        //Lauching the connection with the database
        private static MySqlConnection MSConnexion = new MySqlConnection(connectionString);

        //This integer is used to indicate whether the connection is successful or not
        private static int ReturnCode = 0;

        public static int connexion()
        {
            try
            {
                ReturnCode = 0; //Connection successfully established
                MSConnexion.Open(); //Opening the connection with the database table highscore_table

                System.Console.WriteLine("Connexion Réussie!\n");
            }
            catch (Exception Ex)
            {
                System.Console.WriteLine("Erreur de connexion !!!\n" + Ex.Message);
                ReturnCode = 1; //Connection establishment failed
            }
            return ReturnCode;
        }
        public static void deconnexion()
        {
            MSConnexion.Close(); //Closing the connection with the database table highscore_table
        }

        //This method is used to find the best gamer according to the score he/she made and the time taken to reach it 
        public static Gamer getReferenceGamer()
        {
            
                Gamer gm;
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(score), MIN(time) FROM highscore_table");
                
                    cmd.Connection = MSConnexion;
                    MySqlDataReader MSDR;
                    MSDR = cmd.ExecuteReader();
                    MSDR.Read();
                    gm = new Gamer("pseudo", MSDR.GetInt32(0), MSDR.GetString(1));
                    MSDR.Dispose();
                    return gm;
                 
        }

        //This method is used to make an ordered gamers list by score descending and by time ascending  
        public static List<Gamer> listGamer()
        {
            List<Gamer> LC = new List<Gamer>();
            MySqlCommand cmd = new MySqlCommand("SELECT idGamer, pseudonym, score, time FROM highscore_table");
            cmd.Connection = MSConnexion;
            MySqlDataReader MSDR;
            MSDR = cmd.ExecuteReader();
            while (MSDR.Read())
            {
                LC.Add(new Gamer(MSDR.GetString(1),MSDR.GetInt32(2), MSDR.GetString(3)));
                
            }
            LC.Sort(); // The list is sorted by score descending and by time ascending
            MSDR.Dispose();
            return LC;
        }

        //This method is used to add a gamer to the highscore_table table
        public static void AddGamer(Gamer gm)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO highscore_table(pseudonym, score, time) VALUES ('"+ gm.pseudonym + "','" + gm.score + "','" + gm.time +"')");
            cmd.Connection = MSConnexion;
            try
            {
                gamerAdded=cmd.ExecuteNonQuery(); //if a gamer is successfully added
            } 
            catch (Exception Ex)
            {
                Console.WriteLine("ERREUR : " + Ex.Message);
                gamerAdded = 0; //if a gamer is not successfully added
            }
        }
        
    }
}



