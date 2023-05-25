using System.Drawing.Text;
using System.Runtime.InteropServices;
using System;

namespace SpaceInvadersGame
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblLives = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.playerTimer = new System.Windows.Forms.Timer(this.components);
            this.projectileTimer = new System.Windows.Forms.Timer(this.components);
            this.invaderTimer = new System.Windows.Forms.Timer(this.components);
            this.laserFrequencyTimer = new System.Windows.Forms.Timer(this.components);
            this.laserDetectionTimer = new System.Windows.Forms.Timer(this.components);
            this.monitorTimer = new System.Windows.Forms.Timer(this.components);
            this.pbLife2 = new System.Windows.Forms.PictureBox();
            this.pbLife1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.scoreboardTimer = new System.Windows.Forms.Timer(this.components);
            this.lblRestart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Retro Gaming", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(12, 726);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(66, 26);
            this.lblLives.TabIndex = 1;
            this.lblLives.Text = "Lives:";
            this.lblLives.UseCompatibleTextRendering = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Retro Gaming", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(660, 726);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(92, 26);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            this.lblScore.UseCompatibleTextRendering = true;
            // 
            // playerTimer
            // 
            this.playerTimer.Enabled = true;
            this.playerTimer.Interval = 10;
            this.playerTimer.Tick += new System.EventHandler(this.PlayerMove);
            // 
            // projectileTimer
            // 
            this.projectileTimer.Enabled = true;
            this.projectileTimer.Interval = 10;
            this.projectileTimer.Tick += new System.EventHandler(this.FireProjectile);
            // 
            // invaderTimer
            // 
            this.invaderTimer.Enabled = true;
            this.invaderTimer.Interval = 10;
            this.invaderTimer.Tick += new System.EventHandler(this.InvaderMove);
            // 
            // laserFrequencyTimer
            // 
            this.laserFrequencyTimer.Enabled = true;
            this.laserFrequencyTimer.Interval = 500;
            this.laserFrequencyTimer.Tick += new System.EventHandler(this.LaserFrequency);
            // 
            // laserDetectionTimer
            // 
            this.laserDetectionTimer.Enabled = true;
            this.laserDetectionTimer.Interval = 1;
            this.laserDetectionTimer.Tick += new System.EventHandler(this.DetectLaser);
            // 
            // monitorTimer
            // 
            this.monitorTimer.Interval = 1;
            this.monitorTimer.Tick += new System.EventHandler(this.Monitor);
            // 
            // pbLife2
            // 
            this.pbLife2.Image = global::SpaceInvadersGame.Properties.Resources.heart;
            this.pbLife2.Location = new System.Drawing.Point(120, 721);
            this.pbLife2.Name = "pbLife2";
            this.pbLife2.Size = new System.Drawing.Size(30, 30);
            this.pbLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLife2.TabIndex = 4;
            this.pbLife2.TabStop = false;
            // 
            // pbLife1
            // 
            this.pbLife1.Image = global::SpaceInvadersGame.Properties.Resources.heart;
            this.pbLife1.Location = new System.Drawing.Point(84, 721);
            this.pbLife1.Name = "pbLife1";
            this.pbLife1.Size = new System.Drawing.Size(30, 30);
            this.pbLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLife1.TabIndex = 3;
            this.pbLife1.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::SpaceInvadersGame.Properties.Resources.spaceship;
            this.pbPlayer.Location = new System.Drawing.Point(360, 650);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 50);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.BackColor = System.Drawing.Color.Black;
            this.lblFinish.Font = new System.Drawing.Font("Retro Gaming", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.Color.White;
            this.lblFinish.Location = new System.Drawing.Point(270, 300);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(0, 44);
            this.lblFinish.TabIndex = 5;
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinish.UseCompatibleTextRendering = true;
            this.lblFinish.Visible = false;
            // 
            // scoreboardTimer
            // 
            this.scoreboardTimer.Interval = 800;
            this.scoreboardTimer.Tick += new System.EventHandler(this.ScoreboardBlink);
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.BackColor = System.Drawing.Color.Black;
            this.lblRestart.Font = new System.Drawing.Font("Retro Gaming", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.Color.White;
            this.lblRestart.Location = new System.Drawing.Point(135, 425);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(0, 44);
            this.lblRestart.TabIndex = 6;
            this.lblRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRestart.UseCompatibleTextRendering = true;
            this.lblRestart.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.pbLife2);
            this.Controls.Add(this.pbLife1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.pbPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Invaders Game by Eric Blohm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormKeyReleased);
            ((System.ComponentModel.ISupportInitialize)(this.pbLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbLife1;
        private System.Windows.Forms.PictureBox pbLife2;
        private System.Windows.Forms.Timer playerTimer;
        private System.Windows.Forms.Timer projectileTimer;
        private System.Windows.Forms.Timer invaderTimer;
        private System.Windows.Forms.Timer laserFrequencyTimer;
        private System.Windows.Forms.Timer laserDetectionTimer;
        private System.Windows.Forms.Timer monitorTimer;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Timer scoreboardTimer;
        private System.Windows.Forms.Label lblRestart;
    }
}

