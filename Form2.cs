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
        int Chamber = 0;
        int chamber_count = 0;
        Random ran = new Random();
        int[] playerGun = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        int round = 0;
        int miss_shot = 0;
        int total_score = 0;


        public void LoadBullet()
        {
            Chamber = ran.Next(1, 7);
            MessageBox.Show("Player chamber: " + Chamber);
        }

        public void SpinBullet()
        {
            playerGun[Chamber] = 1;
        }
        public void Restart()
        {
            Application.ExitThread();
            Application.Restart();
        }
        void round_count()
        {
            round++;
            label_round.Text = "Round " + round;
            if (round == 6)
            {
                label_round.Text = "Round " + round;
            }

        }
        public void PointAway()
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
            sound load_sound = new sound();
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

                sound shoot_sound = new sound();
                shoot_sound.shoot_sound();

                round_count();
                chamber_count++;
                if (Chamber == 0)
                {
                    MessageBox.Show("There is no bullet game will automatically restart");
                    Restart();
                }

                if (playerGun[chamber_count] == 1)
                    {
                        MessageBox.Show("Bang - You're dead\nBetter Lucks Next Time...\n\n***Restart Game***");
                        Restart();
                    }
                    else
                    {
                        MessageBox.Show("Bang - You survived");
                        total_score += 100; //User get 100 points each time they survived 
                        label_score.Text = "Total Shots: " + total_score;
                    }
                    if (round == 6)
                    {
                        MessageBox.Show("YOU WON!!!\n\n***End Game***\n***Restart Game***");
                        Restart();
                    }
            }

        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            sound spin_sound = new sound();
            spin_sound.spin_sound();

            SpinBullet();
            if (Chamber ==0)
            {
                MessageBox.Show("There is no bullet game will automatically restart");
                Restart();
            }


        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void btn_shootAway_Click(object sender, EventArgs e)
        {
            {
                Gun_PointHead.Hide();
                Gun_PointAway.Show();
                PointAway();
                miss_shot++;

                if (miss_shot <= 2)
                {
                    MessageBox.Show("You survived");
                    total_score += 100;
                    label_score.Text = "Total Scores: " + total_score;
                }
                if (miss_shot > 2 && playerGun[chamber_count]!=1)
                {
                    MessageBox.Show("Game Restart\nYou shoot away more than 2 times and the bullet has not been fired...\n\n***Restart Game***");

                    Restart();
                }

                if (round == 6)
                {
                    MessageBox.Show("YOU WON!!!\n\n***Restart Game***");
                    miss_shot = 0;
                    chamber_count++;
                    if (Chamber == 0)
                    {
                        MessageBox.Show("There is no bullet game will automatically restart");
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
