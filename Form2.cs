using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gameshoot
{
    public partial class Form2 : Form
    {
        public Form2(string player)
        {
            InitializeComponent();
            label6.Text = player;
        }
        int Chamber = 0; // variables
        int chamber_count = 0;
        Random ran = new Random();
        int[] playerGun = new int[6] { 0, 0, 0, 0, 0, 0 };
        int round = 0;
        int miss_shot = 0;
        int total_score = 0;

        public void LoadBullet() //loads bullet- function
        {
            Chamber = ran.Next(1, 6);
            MessageBox.Show("Player chamber: " + Chamber);
        }

        public void SpinBullet() //spin the bullet - functions
        {
            playerGun[Chamber] = 1;
        }
        public void Restart() // restart the game - functions
        {
            Application.ExitThread();
            Application.Restart();
        }

        void round_count() // we incremented the round and added the round to label
        {
            round++;
            label_round.Text = "Round " + round;
            if (round == 6)
            {
                label_round.Text = "Round " + round;
            }

        }
        public void PointAway() // we incremented the chamber_count and added to the round_count
        {
            round_count();
            chamber_count++;
        }
        //Buttons Click: Load Button, Spin Button, Shoot Button, Shoot Away Button, Restart Button


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            sound load_sound = new sound(); // we loaded the sound
            load_sound.load_sound();

            LoadBullet();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_shoot_Click(object sender, EventArgs e)
        {
            {
            
                Gun_PointAway.Hide();
                Gun_PointHead.Show();

                sound shoot_sound = new sound(); // we added sound of shoot
                shoot_sound.shoot_sound();

                round_count();
                chamber_count++;
                if (Chamber == 0)
                {
                    MessageBox.Show("There is no bullet game will automatically restart"); // added comment to message box
                    Restart();
                }

                if (playerGun[chamber_count] == 1)
                    {
                        MessageBox.Show("Bang - You're dead\nBetter Lucks Next Time...\n\n***Restart Game***"); // Added comment to message box
                        Restart();
                    }
                    else
                    {
                        MessageBox.Show("Bang - You survived"); // Added comment to message box
                        total_score += 100; //User get 100 points each time they survived 
                        label_score.Text = "Total Shots: " + total_score;
                    }
                    if (round == 6)
                    {
                        MessageBox.Show("YOU WON!!!\n\n***End Game***\n***Restart Game***"); // Added comment to message box
                        Restart();
                    }
            }

        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            sound spin_sound = new sound(); //We added spin sound button
            spin_sound.spin_sound();

            SpinBullet();
            if (Chamber ==0)
            {
                MessageBox.Show("There is no bullet game will automatically restart"); // We added automatically restart button
                Restart();
            }


        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Restart(); // We added restart button
        }

        private void btn_shootAway_Click(object sender, EventArgs e)
        {
            {
                Gun_PointHead.Hide(); // We incremented the gun_pointhead and added to miss_shot
                Gun_PointAway.Show();
                PointAway();
                miss_shot++;

                if (miss_shot <= 2)
                {
                    MessageBox.Show("You survived"); // We added comment to messagebox
                    total_score += 100;
                    label_score.Text = "Total Scores: " + total_score;
                }
                if (miss_shot > 2 && playerGun[chamber_count]!=1)
                {
                    MessageBox.Show("Game Restart\nYou shoot away more than 2 times and the bullet has not been fired...\n\n***Restart Game***");

                    Restart(); // We added comment to messagebox
                }

                if (round == 6)
                {
                    MessageBox.Show("YOU WON!!!\n\n***Restart Game***"); // We added comment to messagebox
                    miss_shot = 0;
                    chamber_count++;
                    if (Chamber == 0)
                    {
                        MessageBox.Show("There is no bullet game will automatically restart"); // We added comment to messagebox
                    }

                    Restart();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
