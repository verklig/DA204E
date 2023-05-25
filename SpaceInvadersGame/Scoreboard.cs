using SpaceInvadersGame.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvadersGame
{
    internal class Scoreboard
    {
        private MainForm form;

        public Scoreboard(MainForm mainForm)
        {
            form = mainForm;
        }

        public void ShowWin() 
        {
            foreach (Control c in form.Controls)
            {
                if (c is Label && c.Name == "lblFinish")
                {
                    Label lbl = (Label)c;
                    lbl.Text = "  You Won!" + "\n"
                             + "Score: " + form.Points.ToString();
                    form.StartScoreboardTimer(true);
                }
                else
                {
                    c.Visible = false;
                }
            }

            foreach (Control c in form.Controls)
            {
                if (c is Label && c.Name == "lblRestart")
                {
                    Label lbl = (Label)c;
                    lbl.Text = "Press ENTER to restart";
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        public void ShowLoss()
        {
            foreach (Control c in form.Controls)
            {
                if (c is Label && c.Name == "lblFinish")
                {
                    Label lbl = (Label)c;
                    lbl.Text = "Game Over!";
                    form.StartScoreboardTimer(true);
                }
                else
                {
                    c.Visible = false;
                }
            }

            foreach (Control c in form.Controls)
            {
                if (c is Label && c.Name == "lblRestart")
                {
                    Label lbl = (Label)c;
                    lbl.Text = "Press ENTER to restart";
                }
                else
                {
                    c.Visible = false;
                }
            }
        }
    }
}
