using SpaceInvadersGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SpaceInvadersGame
{
    public partial class MainForm : Form
    {
        private Player player;
        private Enemy enemy;
        private Projectile projectile;
        private Scoreboard scoreboard;

        private const int wallLimit = 732;
        private int points = 0;
        private bool fired;
        private bool isGameActive;
        private bool isGamePaused;

        public bool Fired { get { return fired; } set { fired = value; } }
        public int Points { get { return points; } set { points = value; } }
        public int GetWallLimit { get { return wallLimit; } }
        public bool GetIsGameActive { get { return isGameActive; } }
        public bool GetIsGamePaused { get { return isGamePaused; } }

        public MainForm() 
        {
            InitializeComponent();
            AddCustomFont();
            InitializeGame();
        }

        private void InitializeGame()
        {
            ResetTimers();

            this.Controls.Clear();

            this.Controls.Add(pbPlayer);
            this.Controls.Add(pbLife1);
            this.Controls.Add(pbLife2);
            this.Controls.Add(lblScore);
            this.Controls.Add(lblLives);
            this.Controls.Add(lblPause);
            this.Controls.Add(lblFinish);

            player = new Player(this, pbPlayer);
            enemy = new Enemy(this);
            projectile = new Projectile(this, enemy);
            scoreboard = new Scoreboard(this);

            fired = false;
            isGameActive = true;
            isGamePaused = false;
            points = 0;
            lblFinish.Text = "";
            lblScore.Text = "Score: 0";
            lblLives.Text = "Lives:";
            lblPause.Text = "Press ESCAPE to pause";
            lblFinish.Visible = false;
            lblScore.Visible = true;
            lblLives.Visible = true;
            lblPause.Visible = true;
            lblBar.Visible = true;
            pbLife1.Visible = true;
            pbLife2.Visible = true;
            pbPlayer.Visible = true;

            StartBlinkTimer(false);

            player.ResetPlayerLocation();
            enemy.AddEmemies(this);
            enemy.SpawnEnemies();
        }

        private void ResetTimers()
        {
            playerTimer.Dispose();
            projectileTimer.Dispose();
            invaderTimer.Dispose();
            laserFrequencyTimer.Dispose();
            laserDetectionTimer.Dispose();
            monitorTimer.Dispose();

            playerTimer = new Timer();
            projectileTimer = new Timer();
            invaderTimer = new Timer();
            laserFrequencyTimer = new Timer();
            laserDetectionTimer = new Timer();
            monitorTimer = new Timer();

            playerTimer.Interval = 10;
            projectileTimer.Interval = 10;
            invaderTimer.Interval = 10;
            laserFrequencyTimer.Interval = 500;
            laserDetectionTimer.Interval = 1;
            monitorTimer.Interval = 1;

            playerTimer.Tick += PlayerMove;
            projectileTimer.Tick += FireProjectile;
            invaderTimer.Tick += InvaderMove;
            laserFrequencyTimer.Tick += LaserFrequency;
            laserDetectionTimer.Tick += DetectLaser;
            monitorTimer.Tick += Monitor;

            playerTimer.Start();
            projectileTimer.Start();
            invaderTimer.Start();
            laserFrequencyTimer.Start();
            laserDetectionTimer.Start();
            monitorTimer.Stop();
        }

        private void AddCustomFont()
        {
            Font customFont = Program.GetCustomFont(Resources.Retro_Gaming, 10, FontStyle.Regular);
            Font customFont2 = Program.GetCustomFont(Resources.Retro_Gaming, 12, FontStyle.Regular);
            Font customFont3 = Program.GetCustomFont(Resources.Retro_Gaming, 24, FontStyle.Regular);

            lblPause.Font = customFont;
            lblLives.Font = customFont2;
            lblScore.Font = customFont2;
            lblFinish.Font = customFont3;
        }

        public void CheckForWinner()
        {
            int count = 0;

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Name.StartsWith("Invader"))
                {
                    count++;
                }
            }

            if (count == 0) 
            {
                YouWon();
            }
        }

        public void YouWon()
        {
            isGameActive = false;

            playerTimer.Stop();
            projectileTimer.Stop();
            invaderTimer.Stop();
            laserFrequencyTimer.Stop();
            laserDetectionTimer.Stop();
            monitorTimer.Stop();

            scoreboard.ShowWin();
        }

        public void GameOver()
        {
            isGameActive = false;

            playerTimer.Stop();
            projectileTimer.Stop();
            invaderTimer.Stop();
            laserFrequencyTimer.Stop();
            laserDetectionTimer.Stop();
            monitorTimer.Stop();

            scoreboard.ShowLoss();
        }

        public void Collided(PictureBox pb)
        {
            if (pb.Bounds.IntersectsWith(pbPlayer.Bounds))
            {
                GameOver();
            }
        }

        public void Score(int pts)
        {
            lblScore.Text = "Score: " + pts.ToString();
        }

        public bool Touched(PictureBox pb)
        {
            return pb.Location.X <= 0 || pb.Location.X >= wallLimit;
        }

        public void StartBlinkTimer(bool setting)
        {
            if (setting)
            {
                blinkTimer.Start();
            }
            else
            {
                blinkTimer.Stop();
            }
        }

        private void Blink(object sender, EventArgs e)
        {
            if (!isGameActive)
            {
                if (lblFinish.Visible)
                {
                    lblFinish.Visible = false;
                }
                else
                {
                    lblFinish.Visible = true;
                }
            }

            if (isGameActive)
            {
                if (lblPause.Visible)
                {
                    lblPause.Visible = false;
                }
                else
                {
                    lblPause.Visible = true;
                }
            }
        }

        public void StartMonitor(bool setting)
        {
            if (setting)
            {
                monitorTimer.Start();
            }
            else
            {
                monitorTimer.Stop();
            }
        }

        private void Monitor(object sender, EventArgs e)
        {
            monitorTimer.Stop();
            enemy.RemoveDelayed();
        }

        private void FormKeyPressed(object sender, KeyEventArgs e)
        {
            player.KeyPressed(e.KeyCode);

            if (e.KeyCode == Keys.Space && !fired && isGameActive && !isGamePaused)
            {
                projectile.FireProjectile();
            }

            if (e.KeyCode == Keys.Enter && !isGameActive)
            {
                InitializeGame();
            }

            if (e.KeyCode == Keys.Escape && isGameActive && !isGamePaused)
            {
                isGamePaused = true;

                playerTimer.Stop();
                projectileTimer.Stop();
                invaderTimer.Stop();
                laserFrequencyTimer.Stop();
                laserDetectionTimer.Stop();

                lblPause.Text = "PAUSED";
                StartBlinkTimer(true);
            }
            else if (e.KeyCode == Keys.Escape && isGameActive && isGamePaused)
            {
                isGamePaused = false;

                playerTimer.Start();
                projectileTimer.Start();
                invaderTimer.Start();
                laserFrequencyTimer.Start();
                laserDetectionTimer.Start();

                lblPause.Text = "Press ESCAPE to pause";
                StartBlinkTimer(false);
                lblPause.Visible = true;
            }
        }

        private void FormKeyReleased(object sender, KeyEventArgs e)
        {
            player.KeyReleased(e.KeyCode);
        }

        private void PlayerMove(object sender, EventArgs e)
        {
            player.PlayerMove();
        }

        private void FireProjectile(object sender, EventArgs e)
        {
            projectile.FireProjectile();
        }

        private void InvaderMove(object sender, EventArgs e)
        {
            enemy.InvaderMove(enemy.GetInvaders);
        }

        private void LaserFrequency(object sender, EventArgs e)
        {
            enemy.RandomLazer();
        }

        private void DetectLaser(object sender, EventArgs e)
        {
            player.DetectLaser();
        }
    }
}

