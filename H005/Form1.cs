using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace H005
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player1 = new WMPLib.WindowsMediaPlayer();
        SoundPlayer player2 = new SoundPlayer("noo.wav");

        int score = 0;
        int life = 2;
        bool dead = false;
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[] brick = new PictureBox[48];
        int brickCounter=0;
        int perBrickPixRow = 70, perBrickPixCol=40;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { board.Left -= 5; }
            if (e.KeyCode == Keys.Right) { board.Left += 5; }
        }

        int leftSpeed = 7;
        int topSpeed = -20;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = "分數 :" + score.ToString();
            label2.Text = "生命值 : " + life.ToString();
            ball.Left += leftSpeed;
            ball.Top += topSpeed;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        player2.Play();
                        this.Controls.Remove(x);
                        topSpeed = -topSpeed;
                        score++;
                    }
                }
            }
            if (ball.Top<=0||ball.Bounds.IntersectsWith(board.Bounds))
            {
                player2.Play();
                topSpeed = -topSpeed;
            }
            if(ball.Left<=0||ball.Right>=this.Width)
            {
                player2.Play();
                leftSpeed = -leftSpeed;
            }
            if(ball.Bottom>=718)
            {
                this.KeyPreview = false;
                timer1.Enabled = false;
                life--;
                dead = true;
            }
            if(dead&&life>0)
            {
                button1.Enabled = true;
                button1.Visible = true;
                button1.Text = "還有"+life+"條生命";
                dead = false;
            }
            if(dead&&life==0)
            {
                ball.Location = new Point(board.Left, board.Top - 30);
                this.KeyPreview = false;
                timer1.Stop();
                label2.Text = "遊戲結束";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ball.Location = new Point(board.Left, board.Top-30);
            this.KeyPreview = true;
            button1.Enabled = false;
            button1.Visible = false;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player1.URL = "frog_song.mp3";

            for (int k = 0; k < 12; k++)
            {
                for (int j = 0; j < 4; j++)
                {
                    brick[brickCounter] = new PictureBox();
                    if(j==0)
                        brick[brickCounter].Image = red.Image;
                    else if(j==1)
                        brick[brickCounter].Image = Obrick.Image;
                    else if(j==2)
                        brick[brickCounter].Image = blue.Image;
                    else if(j==3)
                        brick[brickCounter].Image = green.Image;
                    brick[brickCounter].Size = new System.Drawing.Size(50, 20);
                    brick[brickCounter].Location = new Point(k*perBrickPixRow+10, j*perBrickPixCol+10);
                    brick[brickCounter].BringToFront();
                    brick[brickCounter].BackColor = System.Drawing.Color.Transparent;
                    brick[brickCounter].Tag = "block";
                    this.Controls.Add(brick[brickCounter]);
                    brickCounter++;
                }
            }
        }
    }
}
