using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace SpaceInvadersGame
{
    internal class Player
    {
        private MainForm form;
        private Projectile projectile;
        private PictureBox player;

        private Stream playerShootSound;
        private Stream playerHitSound;

        private const int x = 367;
        private const int y = 650;

        private bool moveLeft;
        private bool moveRight;
        private bool canShoot;

        public Player(MainForm mainForm, PictureBox player, Stream playerShootSound, Stream playerHitSound)
        {
            form = mainForm;
            this.player = player;
            this.playerShootSound = playerShootSound;
            this.playerHitSound = playerHitSound;

            moveLeft = false;
            moveRight = false;
        }

        public void KeyPressed(Keys keyCode)
        {
            if (keyCode == Keys.A || keyCode == Keys.Left)
            {
                moveLeft = true;
            }
            else if (keyCode == Keys.D || keyCode == Keys.Right)
            {
                moveRight = true;
            }
            else if (keyCode == Keys.Space && !form.Fired && form.GetIsGameActive && !form.GetIsGamePaused && canShoot)
            {
                projectile = new Projectile(form);
                projectile.PlayerBullet(player);
                form.PlaySound(playerShootSound);
                form.Fired = true;
            }
        }

        public void KeyReleased(Keys keyCode)
        {
            if (keyCode == Keys.A || keyCode == Keys.Left)
            {
                moveLeft = false;
            }
            else if (keyCode == Keys.D || keyCode == Keys.Right)
            {
                moveRight = false;
            }
            else if (keyCode == Keys.Space)
            {
                form.Fired = false;
            }
        }

        public void PlayerMove()
        {
            if (moveLeft && player.Location.X >= 2)
            {
                player.Left -= 2;
            }
            else if (moveRight && player.Location.X <= form.GetWallLimit)
            {
                player.Left += 2;
            }
        }

        public void DetectLaser()
        {
            foreach (Control control in form.Controls)
            {
                if (control is PictureBox && control.Name == "Laser")
                {
                    PictureBox laser = (PictureBox)control;
                    laser.Top += 5;

                    if (laser.Location.Y >= form.GetWallLimit)
                    {
                        form.Controls.Remove(laser);
                    }

                    if (laser.Bounds.IntersectsWith(player.Bounds))
                    {
                        form.Controls.Remove(laser);
                        LoseLife();
                    }
                }
            }
        }

        public void ResetPlayerLocation()
        {
            player.Location = new Point(x, y);
        }

        private void LoseLife()
        {
            ResetPlayerLocation();

            foreach (Control control in form.Controls)
            {
                if (control is PictureBox && control.Name.Contains("Life") && control.Visible == true)
                {
                    PictureBox life = (PictureBox)control;
                    life.Visible = false;
                    form.PlaySound(playerHitSound);
                    return;
                }
            }

            form.GameOver();
        }

        public void SetCanPlayerShoot(bool setting)
        {
            if (setting)
            {
                canShoot = true;
            }
            else
            {
                canShoot = false;
            }
        }
    }
}
