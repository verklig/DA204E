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
        private bool isGameActive;

        public int Points { get { return points; } set { points = value; } }
        public int GetWallLimit { get { return wallLimit; } }

        public MainForm() 
        {
            InitializeComponent();
            AddCustomFont();
            InitializeGame();
        }

        private void InitializeGame()
        {
            ResetGame();

            player = new Player(this, pbPlayer);
            enemy = new Enemy(this);
            projectile = new Projectile(this, enemy);
            scoreboard = new Scoreboard(this);

            isGameActive = true;
            points = 0;
            lblFinish.Text = "";
            lblRestart.Text = "";
            lblFinish.Visible = false;
            lblRestart.Visible = false;
            lblScore.Visible = true;
            lblLives.Visible = true;
            pbLife1.Visible = true;
            pbLife2.Visible = true;
            pbPlayer.Visible = true;

            StartScoreboardTimer(false);

            enemy.AddEmemies(this);
            enemy.SpawnEnemies();
        }

        private void ResetGame()
        {

        }

        private void AddCustomFont()
        {
            Font customFont = Program.GetCustomFont(Properties.Resources.Retro_Gaming, 12, FontStyle.Regular);
            Font customFont2 = Program.GetCustomFont(Properties.Resources.Retro_Gaming, 24, FontStyle.Regular);
            lblLives.Font = customFont;
            lblScore.Font = customFont;
            lblFinish.Font = customFont2;
            lblRestart.Font = customFont2;
        }

        public void CheckForWinner()
        {
            int count = 0;

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name.StartsWith("Invader"))
                {
                    count++;
                }
            }

            if (count == 0) YouWon();
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

        public void Collided(PictureBox a)
        {
            if (a.Bounds.IntersectsWith(pbPlayer.Bounds))
            {
                GameOver();
            }
        }

        public void Score(int pts)
        {
            lblScore.Text = "Score: " + pts.ToString();
        }

        public bool Touched(PictureBox invader)
        {
            return invader.Location.X <= 0 || invader.Location.X >= wallLimit;
        }

        public void StartScoreboardTimer(bool setting)
        {
            if (setting)
            {
                scoreboardTimer.Start();
            }
            else
            {
                scoreboardTimer.Stop();
            }
        }

        private void ScoreboardBlink(object sender, EventArgs e)
        {
            if (lblFinish.Visible && lblRestart.Visible)
            {
                lblFinish.Visible = false;
                lblRestart.Visible = false;
            }
            else
            {
                lblFinish.Visible = true;
                lblRestart.Visible = true;
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

            if (e.KeyCode == Keys.Space && isGameActive)
            {
                projectile.FireProjectile();
            }

            if (e.KeyCode == Keys.Enter && !isGameActive)
            {
                InitializeGame();
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
