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

namespace WindowsFormsApp10
{
    
    public partial class Form1 : Form
    {
        public int duriton = 40;
        public int counter = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
            
            
        }
        Game games = new Game();
        //public string c;
        public int level = 0;
        public int scor = 0;
        int  Time = 0;
        int x=3,T = 2, W = 2;
        Random r = new Random();
        Random v = new Random();





        void Fruits(PictureBox f)
        {

            f.Visible = true;
            if (f.Top <= groupBox1.Height)
            {
                f.Top += 6;
            }
            else
            {
                f.Top = -1;
                x = r.Next(1, 4);
                f.Visible = false;
            }



            if (f.Bounds.IntersectsWith(investigator.Bounds))
            {

                f.Location = new Point((r.Next(6, 326)), 9);
                scor++;
                x = r.Next(1, 4);
                sound();



            }


        }
        public void moveTrop()
        {
            if (T == 1 )
            {
                Trop(picturefic);
                picturepom.Visible = false;
                picturepom.Top = -1;
            }
             if (T == 2  )
            {
                Trop(picturepom);
                picturefic.Visible = false;
                picturefic.Top = -1;

            }
        }
        //
        public void move()
        {


            if (x == 1)
            {
                Fruits(picturbanana);
                pictureOrange.Visible = false;
                pictureApple.Visible = false;
                pictureApple.Top = -1;

                pictureOrange.Top = -1;



                ///  x = r.Next(1, 4);
            }


            else if (x == 2)
            {
                Fruits(pictureApple);
                picturbanana.Visible = false;

                pictureOrange.Visible = false;
                picturbanana.Top = -1;
                pictureOrange.Top = -1;



                ///  x = r.Next(1, 4);
            }
            else
            {
                Fruits(pictureOrange);
                picturbanana.Visible = false;
                pictureApple.Visible = false;
                picturbanana.Top = -1;

                pictureApple.Top = -1;

                /// x = r.Next(1, 4);
            }
        }
      
        public void move_Reward()
        {
            if (W == 1  )
            {
             
                Reward(picturstar);
                pictureTime.Visible = false;
                pictureTime.Tag = -60;

            }
             if (W == 2  )
            {
                Reward(pictureTime);
                picturstar.Visible = false;
                picturstar.Tag = -60;
            }
        }
        //
        void Trop(PictureBox t)
        {
            t.Visible = true;
            if (t.Top <= groupBox1.Height)
            {
                t.Top += 6;
            }
            else
            {
                t.Top = -60;
                t.Visible = false;
                T = r.Next(1, 3);
               
            }



            if (t.Bounds.IntersectsWith(investigator.Bounds))
            {
                T = r.Next(1, 3);
                t.Location = new Point((r.Next(6, 326)), -60);
                scor-=2;
                
                sound2();
                //sound();



            }
        
        }

        ////

        public void Reward(PictureBox rew)
        {
            rew.Visible = true;
            if (rew.Top <= groupBox1.Height)
            {
                rew.Top += 6;
            }
            else
            {
                rew.Top = -60;
                rew.Visible = false;
                W = r.Next(1, 3);

            }



            if (rew.Bounds.IntersectsWith(investigator.Bounds))
            {


                W = r.Next(1, 3);
                rew.Location = new Point((r.Next(6, 326)), -60);
                scor += 2;
                sound();
                

            }
        }
        //
          /* public void move_Not(PictureBox f , PictureBox t , PictureBox rew)
        {
            if ( rew.Bounds.IntersectsWith(f.Bounds) || rew.Bounds.IntersectsWith(t.Bounds) || f.Bounds.IntersectsWith(t.Bounds) || t.Bounds.IntersectsWith(f.Bounds))
            {
                f.Visible = false;
                t.Visible = false;
                rew.Visible = false;
               f.Location = new Point((r.Next(6, 326)), -60);
                t.Location = new Point((r.Next(6, 326)), -60);
                rew.Location = new Point((r.Next(6, 326)), -60);
            }
        }
          */
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                if (investigator.Left >= 6)
                    investigator.Left -= 8;
                // counter++;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (investigator.Left <= 326)
                    investigator.Left += 8;
                counter++;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (investigator.Top >= 115)
                    investigator.Top -= 8;
                // counter++;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (investigator.Top <= 191)

                    investigator.Top += 8;
                counter++;
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (DialogResult.OK == MessageBox.Show(("Do you want to exit? "), "Close The Game", MessageBoxButtons.OKCancel))
                {
                    //Application.Exit();
                    this.Close();
                }

            }
           
            }

     

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        public void sound()
        {
            SoundPlayer sound = new SoundPlayer("mario_04.wav");
            sound.Play();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show(("Do you want to exit? "), "Close The Game", MessageBoxButtons.OKCancel))
            {
                Application.Exit();
                this.Close();
            }
        }

        private void pictureOrange_Click(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            games.Score = scor;
            games.Level = level;
            games.Duration = Time;
            Program.gg.Add(games);
            Form4 f = new Form4(this);

            f.Show();
            this.Close();
        }

        private void textscor_TextChanged(object sender, EventArgs e)
        {

        }
        void sound2()
        {
            SoundPlayer sound = new SoundPlayer("mixkit-arcade-game-explosion-2759.wav");
            sound.Play();
        }
        void tist()
        {

            level = scor / 3;
            textLevel.Text = "Level = " + level.ToString();
            textscor.Text = "scor = " + scor.ToString() + "";
            textTime.Text = Time.ToString();

            textName.Text = Program.pp[0].Name.ToString();

            if (Program.pp[0].Color == "Blue") BackColor = Color.Blue;
            if (Program.pp[0].Color == "Red") BackColor = Color.Red;

            if(Time==100)
            {
                timer1.Stop();
                timerFruits.Stop();
                timerReward.Stop();
                timerTrop.Stop();
                MessageBox.Show("Sorry, Time is UP , try again");
                
            }

            // level1();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            textTime.Text = "Duration = " + duriton--.ToString();
            if (duriton < 0)
                timer1.Stop();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form5 f = new Form5();
          
            games.Score = scor;
            games.Level = level;
            games.Duration = Time;
            Program.gg.Add(games);
            f.Show();
            // this.Close();

        }

        private void timerFruits_Tick_1(object sender, EventArgs e)
        {
          move();
          tist();

        }

        private void timerTrop_Tick_1(object sender, EventArgs e)
        {
            if (scor > 6) {
                moveTrop();
               // move_Not(picturbanana,picturefic,picturstar);
               // move_Not(pictureOrange, picturepom, pictureTime);
                

            }


           
        }

        private void timerReward_Tick_1(object sender, EventArgs e)
        {
            if (scor > 9)
            {
                move_Reward();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
         MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Call method to save file...
            }
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Close();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Time++;
            
        }
    }
}
