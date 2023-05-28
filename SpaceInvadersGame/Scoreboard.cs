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
            foreach (Control control in form.Controls)
            {
                if (control is Label && control.Name == "lblFinish")
                {
                    Label lbl = (Label)control;
                    lbl.Text = "You Won!" + "\n"
                             + "Score: " + form.Points.ToString() + "\n\n"
                             + "Press ENTER to restart";
                    form.StartBlinkTimer(true);
                }
                else
                {
                    control.Visible = false;
                }
            }
        }

        public void ShowLoss()
        {
            foreach (Control control in form.Controls)
            {
                if (control is Label && control.Name == "lblFinish")
                {
                    Label lbl = (Label)control;
                    lbl.Text = "Game Over!" + "\n\n"
                             + "Press ENTER to restart";
                    form.StartBlinkTimer(true);
                }
                else
                {
                    control.Visible = false;
                }
            }
        }
    }
}
