using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PRG282_PROJECT_Military_Simulations
{
    public partial class Form1 : Form
    {
        //Some variables
        bool goLeft, goRight, goDown, goUp, gameOver = false;
        //aircraft facing direction
        string facing = "up";
        //Progress Bars(Start)
        int aircraftHealth = 100;
        int fuel = 100;
        int enemCampHealth = 100;
        //Progress Bars(Start)
        int speed = 10;
        int ammo = 10;
        int score = 0;
        //This is for the generated(dynimacally) obstacle objects
        int obstacleSpeed = 1;
        //Genearting a random num
        Random rnd = new Random();
        //List for the genrated obstacles
        List<PictureBox> obsList = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            restartGame();
        }

        private void mainTimerEvent(object sender, EventArgs e)
        {
            if (enemCampHealth > 1)
            {
                enemyCampHealth.Value = enemCampHealth;
            }
            else
            {
                gameOver = true;
                this.Hide();
                Congrats c = new Congrats();
                c.Show();
                gameTimer.Stop();
            }
            if (fuel > 1)
            {
                fuelBar.Value = fuel;
            }
            else
            {
                gameOver = true;
                aircraftPicBox.Image = Properties.Resources.dead;
                gameTimer.Stop();
            }
            // || enemCampHealth > 1 || fuel > 1
            if (aircraftHealth > 1)
            {
                healthBar.Value = aircraftHealth;
            }
            else
            {
                gameOver = true;
                aircraftPicBox.Image = Properties.Resources.dead;
                gameTimer.Stop();
            }

            ammolbl.Text = "Ammo: " + ammo.ToString();
            scorelbl.Text = "Score: " + score.ToString();

            if (goLeft == true && aircraftPicBox.Left > 0)
            {
                aircraftPicBox.Left -= speed;
            }
            if (goRight == true && aircraftPicBox.Left + aircraftPicBox.Width < this.ClientSize.Width)
            {
                aircraftPicBox.Left += speed;
            }
            if (goUp == true && aircraftPicBox.Top > 45)
            {
                aircraftPicBox.Top -= speed;
            }
            if (goDown == true && aircraftPicBox.Top + aircraftPicBox.Height < this.ClientSize.Height)
            {
                aircraftPicBox.Top += speed;
            }

            foreach (Control x in Controls)
            {
                if (x is PictureBox &&(string)x.Tag == "EnemyCamp")
                {
                    if (aircraftPicBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        enemCampHealth -= 1;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (aircraftPicBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 10;
                    }
                }


                if (x is PictureBox && (string)x.Tag == "obstacle")
                {

                    if (aircraftPicBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        aircraftHealth -= 1;
                    }


                    if (x.Left > aircraftPicBox.Left)
                    {
                        x.Left -= obstacleSpeed;
                        ((PictureBox)x).Image = Properties.Resources.obstacle;
                    }
                    if (x.Left < aircraftPicBox.Left)
                    {
                        x.Left += obstacleSpeed;
                        ((PictureBox)x).Image = Properties.Resources.obstacle;
                    }
                    if (x.Top > aircraftPicBox.Top)
                    {
                        x.Top -= obstacleSpeed;
                        ((PictureBox)x).Image = Properties.Resources.obstacle;
                    }
                    if (x.Top < aircraftPicBox.Top)
                    {
                        x.Top += obstacleSpeed;
                        ((PictureBox)x).Image = Properties.Resources.obstacle;
                    }
                }


                foreach (Control c in Controls)
                {
                    if (c is PictureBox && (string)c.Tag == "bullet" && x is PictureBox && (string)x.Tag == "obstacle")
                    {
                        if (x.Bounds.IntersectsWith(c.Bounds))
                        {
                            score++;

                            this.Controls.Remove(c);
                            ((PictureBox)c).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            obsList.Remove(((PictureBox)x));
                            makeObstacle();
                        }
                    }
                }

            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            

            if (gameOver == true)
            {
                return; // if game over is true then do nothing in this event
            }
            if (e.KeyCode == Keys.Left)
            {
                fuel -= 1;
                goLeft = true;
                facing = "left";
                aircraftPicBox.Image = Properties.Resources.player_left;
            }
            if (e.KeyCode == Keys.Right)
            {
                fuel -= 1;
                goRight = true;
                facing = "right";
                aircraftPicBox.Image = Properties.Resources.player_right;
            }
            if (e.KeyCode == Keys.Down)
            {
                fuel -= 1;
                goDown = true;
                facing = "down";
                aircraftPicBox.Image = Properties.Resources.player_back;
            }
            if (e.KeyCode == Keys.Up)
            {
                fuel -= 1;
                goUp = true;
                facing = "up";
                aircraftPicBox.Image = Properties.Resources.player_front;
            }
            if (e.KeyCode == Keys.Space)
            {
                shoot(facing);
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                shoot(facing);

                if (ammo < 1)
                {
                    dropAmmo();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                restartGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Custom made methods
        public void shoot(string direction)
        {
            Bullets shootBullet = new Bullets();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = aircraftPicBox.Left + (aircraftPicBox.Width / 2);
            shootBullet.bulletTop = aircraftPicBox.Top + (aircraftPicBox.Height / 2);
            shootBullet.makeBullet(this);
        }
        public void makeObstacle()
        {
            PictureBox obstacle = new PictureBox();
            obstacle.Tag = "obstacle";
            obstacle.Image = Properties.Resources.obstacle;
            obstacle.Left = rnd.Next(0,900);
            obstacle.Top = rnd.Next(0,800);
            obstacle.SizeMode = PictureBoxSizeMode.AutoSize;
            obsList.Add(obstacle);
            this.Controls.Add(obstacle);
            aircraftPicBox.BringToFront();
        }
        private void dropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.bullet;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(0, this.ClientSize.Width - ammo.Width);
            ammo.Top = rnd.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            aircraftPicBox.BringToFront();
        } 
        private void restartGame()
        {
            aircraftPicBox.Image = Properties.Resources.player_front;
            foreach (PictureBox pic in obsList)
            {
                this.Controls.Remove(pic);
            }
            obsList.Clear();
            for (int i = 0; i < 3; i++)
            {
                makeObstacle();
            }
            goUp = false;
            goDown = false;
            goRight = false;
            goLeft = false;
            gameOver = false;
            aircraftHealth = 100;
            fuel = 100;
            enemCampHealth = 100;
            score = 0;
            ammo = 10;
            gameTimer.Start();
        }
    }
}
