using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace WindowsFormsApp10
{
    public partial class Form3 : Form
    {
        
        string name;
        string gender;
        int age;
        string color;
      //  B pro = new B();
       // A Item = new A();
        public Form3()
        {
            InitializeComponent();
           Data.Profiles = new List<Profile>();

          


        }

        public void label1_Click(object sender, EventArgs e)
        {
           
         name=  textBox1.Text;

        }

        public void label3_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked == true)
                gender = radioButton1.Text;
            else if (radioButton2.Checked == true)
               gender = radioButton2.Text;
        }
        public void textBox2_TextChanged(object sender, EventArgs e)
        {
           
          age= int.Parse(textBox2.Text);

        }

        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                BackColor = Color.Blue;
               color = "Blue";
            }
               

        }

        public void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                BackColor = Color.Yellow;
                color = "Yellow";
            }
                
        }

        public void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                BackColor = Color.Red;
                color = "Red";
            }
               
        }

        public void button1_Click(object sender, EventArgs e)
        {

           // Item.Addprofile(pro);

            Profile player = new Profile();
            player.Name = textBox1.Text;
            if (radioButton1.Checked == true)
                player.Gender = radioButton1.Text;
            else
                player.Gender = radioButton2.Text;
            player.Age = int.Parse(textBox2.Text);
            player.Color = color;
            Program.count1 += 1;
            
            player.All_games = new List<Game>();

            Game g = new Game();
            g.Score = 1;
            g.Level = 1;
            g.Duration= 17;
            Program.pp.Add(player);
            player.All_games.Add(g);
            Data.Profiles.Add(player);
            Form2 save = new Form2();
            save.Visible = true;
          //  this.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
