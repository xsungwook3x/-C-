using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void form1_Road(object sender, EventArgs e)
        {
            label1.Text = "Welcome Message!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "You Clicked on OK!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
