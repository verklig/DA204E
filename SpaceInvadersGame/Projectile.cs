using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvadersGame
{
    internal class Projectile
    {
        private MainForm form;
        private Enemy enemy;

        public Projectile(MainForm mainForm)
        {
            form = mainForm;
        }

        public Projectile(MainForm mainForm, Enemy enemy)
        {
            form = mainForm;
            this.enemy = enemy;
        }

        public void FireProjectile()
        {
            foreach (Control c in form.Controls)
            {
                if (c is PictureBox && c.Name == "Bullet")
                {
                    PictureBox bullet = (PictureBox)c;
                    bullet.Top -= 5;

                    if (bullet.Location.Y <= 0)
                    {
                        form.Controls.Remove(bullet);
                    }

                    foreach (Control ct in form.Controls)
                    {
                        if (ct is PictureBox && ct.Name == "Laser")
                        {
                            PictureBox laser = (PictureBox)ct;

                            if (bullet.Bounds.IntersectsWith(laser.Bounds))
                            {
                                form.Controls.Remove(bullet);
                                form.Controls.Remove(laser);
                                form.Points++;
                                form.Score(form.Points);
                            }
                        }
                    }

                    foreach (Control ctrl in form.Controls)
                    {
                        if (ctrl is PictureBox && ctrl.Name.StartsWith("Invader"))
                        {
                            PictureBox invader = (PictureBox)ctrl;

                            if (bullet.Bounds.IntersectsWith(invader.Bounds) && !form.Touched(invader))
                            {
                                form.Controls.Remove(bullet);
                                form.Controls.Remove(invader);
                                enemy.RemoveInvaders(invader);
                                form.Points += 5;
                                form.Score(form.Points);
                                form.CheckForWinner();
                            }
                            else if (bullet.Bounds.IntersectsWith(invader.Bounds) && form.Touched(invader))
                            {
                                form.Controls.Remove(bullet);
                                form.Controls.Remove(invader);
                                enemy.AddDelayed(invader);
                                form.Points += 5;
                                form.Score(form.Points);
                                form.CheckForWinner();
                            }
                        }
                    }
                }
            }
        }

        public void PlayerBullet(PictureBox player)
        {
            PictureBox bullet = new PictureBox();
            bullet.Location = new Point(player.Location.X + player.Width / 2 - 5, player.Location.Y - 20);
            bullet.Size = new Size(12, 20);
            bullet.BackgroundImage = Properties.Resources.bullet;
            bullet.BackgroundImageLayout = ImageLayout.Stretch;
            bullet.Name = "Bullet";
            form.Controls.Add(bullet);
        }

        public void EnemyLaser(PictureBox enemy)
        {
            PictureBox laser = new PictureBox();
            laser.Location = new Point(enemy.Location.X + enemy.Width / 3, enemy.Location.Y + 20);
            laser.Size = new Size(12, 20);
            laser.BackgroundImage = Properties.Resources.laser;
            laser.BackgroundImageLayout = ImageLayout.Stretch;
            laser.Name = "Laser";
            form.Controls.Add(laser);
        }
    }
}
