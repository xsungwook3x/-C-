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

        private void Form1_Load(object sender, EventArgs e)
        {
            message.Text = "Welcome Message!";
        }


        private void okBTN_Click(object sender, EventArgs e)
        {
            message.Text = "You Clicked on OK!";
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
