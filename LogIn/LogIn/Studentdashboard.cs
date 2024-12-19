using LogIn.Teacher_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class Studentdashboard : Form
    {
        public Studentdashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (examlogin das = new examlogin())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void Studentdashboard_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            
        }
    }
}
