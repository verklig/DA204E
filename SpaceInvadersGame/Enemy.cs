using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvadersGame
{
    internal class Enemy
    {
        List<PictureBox> invaders;
        List<PictureBox> delay;

        private MainForm form;
        private Projectile projectile;

        private int width;
        private int height;
        private int columns;
        private int rows;
        private int x;
        private int y;
        private int space;
        private int speed;
        private int left;
        private int top;
        private int count;

        public List<PictureBox> GetInvaders { get { return invaders; } }

        public Enemy(MainForm mainForm)
        {
            invaders = new List<PictureBox>();
            delay = new List<PictureBox>();

            form = mainForm;

            width = 40;
            height = 40;
            columns = 10;
            rows = 5;
            space = 10;
            x = 140;
            y = 0;
            speed = -1;
            left = -1;
            top = 0;
            count = 0;
        }

        public void CreateInvader1(Form form)
        {
            PictureBox invader1 = new PictureBox();
            invader1.Location = new Point(x, y);
            invader1.Size = new Size(width, height);
            invader1.BackgroundImage = Properties.Resources.invader;
            invader1.BackgroundImageLayout = ImageLayout.Stretch;
            invader1.Name = "Invader1";
            form.Controls.Add(invader1);
        }

        public void CreateInvader2(Form form)
        {
            PictureBox invader2 = new PictureBox();
            invader2.Location = new Point(x, y);
            invader2.Size = new Size(width, height);
            invader2.BackgroundImage = Properties.Resources.invader2;
            invader2.BackgroundImageLayout = ImageLayout.Stretch;
            invader2.Name = "Invader2";
            form.Controls.Add(invader2);
        }

        public void CreateInvader3(Form form)
        {
            PictureBox invader3 = new PictureBox();
            invader3.Location = new Point(x, y);
            invader3.Size = new Size(width, height);
            invader3.BackgroundImage = Properties.Resources.invader3;
            invader3.BackgroundImageLayout = ImageLayout.Stretch;
            invader3.Name = "Invader3";
            form.Controls.Add(invader3);
        }

        public void CreateInvader4(Form form)
        {
            PictureBox invader4 = new PictureBox();
            invader4.Location = new Point(x, y);
            invader4.Size = new Size(width, height);
            invader4.BackgroundImage = Properties.Resources.invader4;
            invader4.BackgroundImageLayout = ImageLayout.Stretch;
            invader4.Name = "Invader4";
            form.Controls.Add(invader4);
        }

        public void CreateInvader5(Form form)
        {
            PictureBox invader5 = new PictureBox();
            invader5.Location = new Point(x, y);
            invader5.Size = new Size(width, height);
            invader5.BackgroundImage = Properties.Resources.invader5;
            invader5.BackgroundImageLayout = ImageLayout.Stretch;
            invader5.Name = "Invader5";
            form.Controls.Add(invader5);
        }

        public void AddEmemies(Form form)
        {
            for (int i = 0; i < rows; i++)
            {

                if (i == 0)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        CreateInvader2(form);
                        x += width + space;
                    }
                }

                if (i == 1)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        CreateInvader5(form);
                        x += width + space;
                    }
                }

                if (i == 2)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        CreateInvader3(form);
                        x += width + space;
                    }
                }

                if (i == 3)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        CreateInvader4(form);
                        x += width + space;
                    }
                }

                if (i == 4)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        CreateInvader1(form);
                        x += width + space;
                    }
                }

                y += height + space;
                x = 140;
            }
        }

        public void SpawnEnemies()
        {
            foreach (Control control in form.Controls)
            {
                if (control is PictureBox && control.Name == "Invader1")
                {
                    PictureBox invader1 = (PictureBox)control;
                    invaders.Add(invader1);
                }
                else if (control is PictureBox && control.Name == "Invader2")
                {
                    PictureBox invader2 = (PictureBox)control;
                    invaders.Add(invader2);
                }
                else if (control is PictureBox && control.Name == "Invader3")
                {
                    PictureBox invader3 = (PictureBox)control;
                    invaders.Add(invader3);
                }
                else if (control is PictureBox && control.Name == "Invader4")
                {
                    PictureBox invader4 = (PictureBox)control;
                    invaders.Add(invader4);
                }
                else if (control is PictureBox && control.Name == "Invader5")
                {
                    PictureBox invader5 = (PictureBox)control;
                    invaders.Add(invader5);
                }
            }
        }

        public void InvaderMove(List<PictureBox> invaders)
        {
            foreach (PictureBox invader in invaders)
            {
                invader.Location = new Point(invader.Location.X + left, invader.Location.Y + top);
                SetDirection(invader);
                form.Collided(invader);
            }
        }

        public void SetDirection(PictureBox invader)
        {
            int size = invader.Height;

            if (form.Touched(invader))
            {
                top = 1; left = 0; count++;

                if (count == size)
                {
                    top = 0; left = speed * (-1); form.StartMonitor(true);
                }
                else if (count == size * 2)
                {
                    top = 0; left = speed; count = 0; form.StartMonitor(true);
                }
            }
        }

        public void RandomLazer()
        {
            projectile = new Projectile(form);
            Random rand = new Random();
            int choice;

            if (invaders.Count > 0)
            {
                choice = rand.Next(invaders.Count);
                projectile.EnemyLaser(invaders[choice]);
            }
        }

        public void RemoveInvaders(PictureBox invader)
        {
            invaders.Remove(invader);
        }

        public void AddDelayed(PictureBox invader)
        {
            delay.Add(invader);
        }

        public void RemoveDelayed()
        {
            foreach (PictureBox delayed in delay)
            {
                invaders.Remove(delayed);
            }
            delay.Clear();
        }
    }
}
