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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

           


          label3.Text = (from num in Data.Profiles select num.All_games.Count).Sum().ToString();

            label5.Text = Data.Profiles.Count.ToString();

            label9.Text= (from a in Data.Profiles select (from b in a.All_games select b.Score).Max()).Max().ToString();
            label7.Text= (from a in Data.Profiles select (from b in a.All_games select b.Score).Min()).Min().ToString();
            label13.Text = (from a in Data.Profiles select (from b in a.All_games select b.Duration).Max()).Max().ToString();
            label11.Text= (from a in Data.Profiles select (from b in a.All_games select b.Duration).Min()).Min().ToString();
            label17.Text= (from a in Data.Profiles select (from b in a.All_games select b.Duration).Sum()).Sum().ToString();



        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
