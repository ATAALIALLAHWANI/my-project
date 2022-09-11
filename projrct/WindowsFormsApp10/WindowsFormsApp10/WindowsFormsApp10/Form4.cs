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
    public partial class Form4 : Form
    {
        public Form4(Form1 ff1)
        {
            Form1 f;
            
           Profile obj = new Profile();

            InitializeComponent();
             f = ff1;

            int count11=0;
            label7.Text = dateTimePicker1.Value.ToString();
            // label6.Text = Data.Profiles[0].Name;
           
           label6.Text = Program.pp[count11].Name;

            //label9.Text = f.scor.ToString();
            label9.Text = Program.gg[0].Score.ToString();
            label10.Text = Program.gg[0].Level.ToString();
            label8.Text = Program.gg[0].Duration.ToString();
            label14.Text = f.counter.ToString();


           
               
            
          



        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
