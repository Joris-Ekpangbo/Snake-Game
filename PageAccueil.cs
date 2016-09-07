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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeProject1
{
    //Here are described the main operations of the game
    public partial class PageAccueil : Form
    {
        //This list will contain all the snake parts 
        private List<SnakePart> snake = new List<SnakePart>();

        //These lists are used in the drawing of obstacles in the stage 1 of the game
        private List<SnakePart> obstacles = new List<SnakePart>();
        private List<SnakePart> obstacles2 = new List<SnakePart>();

        //This will be used in genrating food for the snake
        private SnakePart food = new SnakePart();

        //All of these SnakeParts are used in the drawing of obstacles in the stage 1 of the game
        private SnakePart obstacle = new SnakePart();
        private SnakePart obstacle1 = new SnakePart();
        private SnakePart obstacle2 = new SnakePart();
        private SnakePart obstacle3 = new SnakePart();
        private SnakePart obstacle00 = new SnakePart();
        private SnakePart obstacle01 = new SnakePart();
        private SnakePart obstacle02 = new SnakePart();
        private SnakePart obstacle03 = new SnakePart();

        //This integer is used to allow or not the generation of obstacles
        public static bool generateObstacle = false;

        //This is used for counting down the player score
        public static int score = 0;

        //These integers are used to set the position of food for the snake
        public static int randomFoodX, randomFoodY;

        //This indicates whether a stage is passed or not
        public static int stagePassed = 0;

        //This for keeping the gamer pseudonym on the play game page
        string pseudo;

        //For recognizing the gamer with the highest score
        public int highScoreGamer = 0;
       
        public PageAccueil(string pseudo)
        {
            InitializeComponent();

            //Initializing the gamer pseudonym
            this.pseudo=pseudo;

            //set settings to default
            new Settings();

            //set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += new EventHandler(UpdateScreen);
            gameTimer.Start();

            stopWatch.Interval = 1000; //in milliseconds
            stopWatch.Tick += new EventHandler(this.stopWatch_Tick);

            //Start the timer when forms loads
            stopWatch.Start();

            //Start new Game
            StartGame();

        }

        System.Diagnostics.Stopwatch chrono = new System.Diagnostics.Stopwatch { };

        private void StartGame()
        {
            //set settings to default
            new Settings();
            Settings.Score = score;

            //create new player object
            SnakePart head = new SnakePart();
            head.X = 10;
            head.Y = 5;
            snake.Clear();
            snake.Add(head);

            //Writing Score
            labelScore.Text = Settings.Score.ToString();

            //Writing pseudonym
            labelPseudo.Text = pseudo;

            //Generating randomly food
            GenerateFood();
            
            //Generating obstacles if it is allowed
            if(Settings.enableDrawObstacle==true)
                GenerateObstacles();

            //Reseting the stopwatch if the player is still on the stage 0 of the game
            if (Settings.enableDrawObstacle== false)
                chrono.Reset();

        }
        
        //This method describes how food is generated on the game screen
        private void GenerateFood()
        {
            //These integers represent the bounds of the game out of which food cannot be generated
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new SnakePart();

            //If there is any obstacle on the game screen, we must verify 
            //whether the position of any food part is alike to any obstacle position or not, 
            //before randomly generating it 
            if (generateObstacle == true)
            {
                for (int j = 0; j < obstacles.Count; j++)
                    do
                    {
                        randomFoodX = random.Next(0, maxXPos);
                        randomFoodY = random.Next(0, maxYPos);

                    } while ((random.Next(0, maxXPos) == obstacles[j].X) || (random.Next(0, maxYPos) == obstacles[j].Y));

                for (int j = 0; j < obstacles2.Count; j++)
                    do
                    {
                        randomFoodX = random.Next(0, maxXPos);
                        randomFoodY = random.Next(0, maxYPos);

                    } while ((random.Next(0, maxXPos) == obstacles2[j].X) || (random.Next(0, maxYPos) == obstacles2[j].Y));

                food.X = randomFoodX;
                food.Y = randomFoodY;

            }

            //If there is no obstacle we can without concern, we can generate randomly food
            else {
                food.X = random.Next(0, maxXPos);
                food.Y = random.Next(0, maxYPos);
                
            }
        
        }
        
        //This method describes how obstacles are generating with precised and fixed positions
        private void GenerateObstacles()
        {
                obstacles.Clear();
                for (int i = 0; i < 5; i++)
                {
                    obstacles.Add(obstacle);
                    obstacles.Add(obstacle1);
                    obstacles.Add(obstacle2);
                    obstacles.Add(obstacle3);
                    obstacles[i].X = 22 - i;
                    obstacles[i].Y = 8 + i;
                }

                obstacles2.Clear();
                for (int i = 0; i < 5; i++)
                {
                    obstacles2.Add(obstacle00);
                    obstacles2.Add(obstacle01);
                    obstacles2.Add(obstacle02);
                    obstacles2.Add(obstacle03);
                    obstacles2[i].X = 7 - i;
                    obstacles2[i].Y = 8 - i;
                }

        }

        //This method describes the display of the game screen,
        //how the snake will move according to the key pressed (Up, Down, Right, Left) on the keyboard and,
        //how a new game is started when the Enter key is pressed at the end of the former
        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Settings.GameOver==true)
            {
                //Check for Enter key pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                    stopWatch.Enabled = true; 
                }              
            }
            else
            {
                if ((Input.KeyPressed(Keys.Left)) && (Settings.direction != Direction.Right))
                {
                    Settings.direction = Direction.Left;
                }
                else if ((Input.KeyPressed(Keys.Right)) && (Settings.direction != Direction.Left))
                {
                    Settings.direction = Direction.Right;
                }
                else if ((Input.KeyPressed(Keys.Up)) && (Settings.direction != Direction.Down))
                {
                    Settings.direction = Direction.Up;
                }
                else if ((Input.KeyPressed(Keys.Down)) && (Settings.direction != Direction.Up))
                {
                    Settings.direction = Direction.Down;
                }
                //Based on all of the pressed keys, is moved the snake
                MovePlayer();
            }
            pbCanvas.Invalidate();
        }

        //This method describes truly how the snake moves
        private void MovePlayer()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                //Moving the head of the snake
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            snake[i].X++;
                            break;
                        case Direction.Left:
                            snake[i].X--;
                            break;
                        case Direction.Up:
                            snake[i].Y--;
                            break;
                        case Direction.Down:
                            snake[i].Y++;
                            break;
                    }

                    //Get maximum X and Y Position

                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Check for out of bounds
                    
                        if (((-1)*(snake[i].X)) >0)
                            snake[i].X=maxXPos-1;
                        if (((-1) * (snake[i].Y)) > 0)
                            snake[i].Y = maxYPos-1;
                        if (snake[i].X >= maxXPos)
                            snake[i].X = 0;
                        if (snake[i].Y>= maxYPos)
                            snake[i].Y = 0;
                            
                    //Check for body collision
                    for (int j = 1; j < snake.Count; j++)
                        if ((snake[i].X == snake[j].X) && (snake[i].Y == snake[j].Y))
                            Die();

                    //Check for collision with food
                    if ((snake[0].X == food.X) && (snake[0].Y == food.Y))
                    {
                        Eat();
                    }

                    //Check for collision with obstacles
                    for (int j = 0; j < obstacles.Count; j++)
                        if (((snake[0].X == obstacles[j].X) && (snake[0].Y == obstacles[j].Y)))
                        {
                                Die();
                        }
                    for (int j = 0; j < obstacles2.Count; j++)
                        if (((snake[0].X == obstacles2[j].X) && (snake[0].Y == obstacles2[j].Y)))
                        {
                            Die();
                        }
                }
                else
                {
                    //Moving the body
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
        }

        private void Eat()
        {
            //Add part to the body
            SnakePart food = new SnakePart();
            food.X = snake[snake.Count - 1].X;
            food.Y = snake[snake.Count - 1].Y;
            snake.Add(food);

            //If the sound is enabled, eating food makes noise
            if (Settings.SoundOn == true)
            {
                SoundPlayer sound = new SoundPlayer(SnakeProject1.Properties.Resources.Blop_Mark_DiAngelo_79054334);
                sound.Play();
            }

            //Update score
            Settings.Score += Settings.Points;
            labelScore.Text = Settings.Score.ToString();

            //Starting a new stage 1 Game if score is greater than 1000
            if ((Settings.Score > 1000)&&(stagePassed==0)) {
                score = Settings.Score;
                generateObstacle= true;
                stagePassed++;
                StartGame();
            }

            //Generating food after eating it
            GenerateFood();
            
            
        }

        //This method describes what happens when the snake is destroyed
        private void Die()
        {
            Settings.GameOver = true;
            stopWatch.Enabled=false;

            //If sound on, it makes noise when the game is over
            if (Settings.SoundOn == true)
            {
                SoundPlayer sound = new SoundPlayer(SnakeProject1.Properties.Resources.Jab_SoundBible_com_1806727891__1_);
                sound.Play();
            }

            //The player is added to our database table highscore_table only when the game is over with the score reached
            //and the time taken to make it
            if (bdd.connexion() == 0)
            {
                Gamer gm = new Gamer(pseudo, Settings.Score, labelStopwatch.Text);
                bdd.AddGamer(gm);
                Console.Write("Gamer successfully added\n");
                if (bdd.gamerAdded== 0)
                {
                    MessageBox.Show("Error", "Registration failed !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bdd.deconnexion();
             }

            //We check if the score of the player is the highest ever reached
            if (bdd.connexion() == 0) {
                bdd.getReferenceGamer();
                if(Settings.Score==bdd.getReferenceGamer().score)
                    {
                        //Thanks to that integer is displayed a featured message for the best player
                        highScoreGamer = 1;
                        if (Settings.SoundOn == true)
                        {
                            SoundPlayer sound = new SoundPlayer(SnakeProject1.Properties.Resources.SMALL_CROWD_APPLAUSE_Yannick_Lemieux_1268806408);
                            sound.Play();
                        }
                        
                    }
            } bdd.deconnexion();

            //Finally we reset the score and cancel the enablement of generating obstacles
            score = 0;
            generateObstacle = false;
            obstacles.Clear();
            obstacles2.Clear();
        }

        //In this method is defined the display of the game screen
        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Font font = this.Font;
            if (!Settings.GameOver)
            {
                //set color of snake
                Brush snakeColour;

                //Draw snake
                for (int i = 0; i < snake.Count; i++)
                {
                    //Draw head
                    if (i == 0)
                        snakeColour = Brushes.Black;

                    //Draw the rest of the body
                    else
                        snakeColour = Brushes.Yellow;

                    //Draw snake
                    canvas.FillRectangle(snakeColour, new Rectangle(snake[i].X * Settings.Width,
                        snake[i].Y * Settings.Height, Settings.Width, Settings.Height));

                    //Draw food
                    canvas.FillRectangle(Brushes.Green, new Rectangle(food.X * Settings.Width,
                        food.Y * Settings.Height, Settings.Width, Settings.Height));
                    
                    //Stage 1
                    //Draw obastacles if allowed

                    if (generateObstacle == true)
                    {
                        canvas.FillRectangle(Brushes.Red, new Rectangle(obstacles[0].X * Settings.Width,
                            obstacles[0].Y * Settings.Height, Settings.Width, Settings.Height));
                        canvas.FillRectangle(Brushes.Red, new Rectangle(obstacles[1].X * Settings.Width,
                                obstacles[1].Y * Settings.Height, Settings.Width, Settings.Height));
                        canvas.FillRectangle(Brushes.Red, new Rectangle(obstacles[2].X * Settings.Width,
                                    obstacles[2].Y * Settings.Height, Settings.Width, Settings.Height));
                        canvas.FillRectangle(Brushes.Red, new Rectangle(obstacles[3].X * Settings.Width,
                                        obstacles[3].Y * Settings.Height, Settings.Width, Settings.Height));

                        canvas.FillRectangle(Brushes.Red, new Rectangle(obstacles2[0].X * Settings.Width,
                                obstacles2[0].Y * Settings.Height, Settings.Width, Settings.Height));
                        canvas.FillRectangle(Brushes.Red, new Rectangle(obstacles2[1].X * Settings.Width,
                                obstacles2[1].Y * Settings.Height, Settings.Width, Settings.Height));
                        canvas.FillRectangle(Brushes.Red, new Rectangle(obstacles2[2].X * Settings.Width,
                                    obstacles2[2].Y * Settings.Height, Settings.Width, Settings.Height));
                        canvas.FillRectangle(Brushes.Red, new Rectangle(obstacles2[3].X * Settings.Width,
                                        obstacles2[3].Y * Settings.Height, Settings.Width, Settings.Height));

                    }
                    
                }
                                      
            }

            //Here is defined the GameOver message
            else
            {
                SizeF message;
                //If you are the best player this message is for you
                if (highScoreGamer == 1)
                {
                    message = canvas.MeasureString("CONGRATULATIONS!!! You are the best", font);
                    canvas.DrawString("CONGRATULATIONS!!! You are the best", font, Brushes.Black, new PointF(200 - message.Width / 2, 120));
                }
                //If you are not yet, you can be
                else {
                    message = canvas.MeasureString("TRY AGAIN... You can do better", font);
                    canvas.DrawString("TRY AGAIN... You can do better", font, Brushes.Black, new PointF(200 - message.Width / 2, 120));
                
                }
                message = canvas.MeasureString("Gameover", font);
                canvas.DrawString("Gameover", font, Brushes.Black, new PointF(200 - message.Width / 2, 140));
                message = canvas.MeasureString("Final Score" + Settings.Score.ToString(), font);
                canvas.DrawString("Final Score: " + Settings.Score.ToString(), font, Brushes.Black, new PointF(200 - message.Width / 2, 160));
                message = canvas.MeasureString("Stopwatch" + labelStopwatch.Text.ToString(), font);
                canvas.DrawString("Stopwatch: "+labelStopwatch.Text.ToString(), font, Brushes.Black, new PointF(200 - message.Width / 2, 180));
                message = canvas.MeasureString("Press Enter to start a new game", font);
                canvas.DrawString("Press Enter to start a new game", font, Brushes.Black, new PointF(200 - message.Width / 2, 200));
            }
        
        }

        //These methods are used for detecting the pressed keys
        private void PageAccueil_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void PageAccueil_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        //This governs the display of the stopwatch
        private void stopWatch_Tick(object sender, EventArgs e)
        {
            chrono.Start();

            int hour = chrono.Elapsed.Hours;
            int mins = chrono.Elapsed.Minutes;
            int secs = chrono.Elapsed.Seconds;

            string time = "";

            time = hour + ":";

            if (mins < 10)
            {
                time += "0" + mins + ":";
            }
            else
            {
                time += mins + ":";
            }
            if (secs < 10)
            {
                time += "0" + secs;
            }
            else
            {
                time += secs;
            }
            labelStopwatch.Text = time;
        }

        //When the Windows Form is closed we reset the score and cancel the enablement of generating obstacles
        private void PageAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            score = 0;
            generateObstacle = false;
        }

       
        
        }
}
