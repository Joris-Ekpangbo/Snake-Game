/*
 * Created by EKPANGBO Joris and MBENGUE Pape Adama.
 * Last date modified: 26/05/2015
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject1
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    //Here are set up all of the game settings
    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static bool SoundOn { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool enableDrawObstacle { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            
            Width = 16;
            Height = 16;

            //According to the choice made by the player on the difficulty, on the Windows Form SettingsPage,
            //we can set the speed of the snake
            if(SettingsPage.difficultyChoice==0)
                Speed = 2;
            if (SettingsPage.difficultyChoice == 1)
                Speed = 5;
            if (SettingsPage.difficultyChoice == 2)
                Speed = 10;
            Score = 0;

            //According to the choice made by the player on the sound enablement, on the Windows Form SettingsPage,
            //we can set whether the sound is enable or not in the game
            if (SettingsPage.soundPlaying == 1)
                SoundOn = true;
            if (SettingsPage.soundPlaying == 0)
                SoundOn = false;
            
            //If the generation of obstacles is allowed, we set the enableDrawObstacle to true
            if(PageAccueil.generateObstacle==true)
                enableDrawObstacle = true;
            else
                enableDrawObstacle = false;

            //This is used for counting down the score made by gamers
            Points = 100;

            //For each new game, the game is not over.
            GameOver = false;

            //The head of the snake at the start of any new game heads south
            direction = Direction.Down;
        }
    }
}
