using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaytron_Password
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            main ff = new main();
            ff.Show();
            this.Hide();
            timer1.Stop();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ArdaDDemir");


        }
    }
}
