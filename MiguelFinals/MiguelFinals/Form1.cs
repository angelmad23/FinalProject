using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiguelFinals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            login1.Show();
            login1.BringToFront();

            register1.Hide();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            register1.Show();
            register1.BringToFront();

            login1.Hide();

        }

        private void register1_Load(object sender, EventArgs e)
        {

        }
    }
}
