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
    public partial class teacherlogindash : Form
    {
        public teacherlogindash()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            
        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teacherlogindash_Load(object sender, EventArgs e)
        {
            
        }

        private void userControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void add_New_Question1_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (examlogin das = new examlogin())
            {
                das.ShowDialog();
                this.Hide();
            }
        }
    }
}
