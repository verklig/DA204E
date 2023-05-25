using System;
using System.Collections.Generic;
using System.Drawing;
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

        const int x = 360, y = 650;

        private bool moveLeft;
        private bool moveRight;
        private bool fired;

        public Player(MainForm mainForm, PictureBox player)
        {
            this.player = player;
            moveLeft = false;
            moveRight = false;
            fired = false;

            form = mainForm;
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
            else if (keyCode == Keys.Space && !fired)
            {
                projectile = new Projectile(form);
                projectile.PlayerBullet(player);
                fired = true;
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
                fired = false;
            }
        }

        public void PlayerMove()
        {
            if (moveLeft && player.Location.X >= 1)
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
            foreach (Control c in form.Controls)
            {
                if (c is PictureBox && c.Name == "Laser")
                {
                    PictureBox laser = (PictureBox)c;
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

        private void LoseLife()
        {
            player.Location = new Point(x, y);

            foreach (Control c in form.Controls)
            {
                if (c is PictureBox && c.Name.Contains("Life") && c.Visible == true)
                {
                    PictureBox player = (PictureBox)c;
                    player.Visible = false;
                    return;
                }
            }
            form.GameOver();
        }
    }
}
