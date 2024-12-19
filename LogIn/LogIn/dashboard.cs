using LibraryManagementSystem;
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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (examlogin das = new examlogin())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (librarylogin das = new librarylogin())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (staffemployedetails das = new staffemployedetails())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (@class das = new @class())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (studentdetails das = new studentdetails())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (teacherdetails das = new teacherdetails())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (staffemployedetails das = new staffemployedetails())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
