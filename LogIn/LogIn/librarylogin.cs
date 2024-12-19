using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class librarylogin : Form
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.DatabaseteacherConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public librarylogin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                pass.PasswordChar = '\0';
                checkBox2.Text = "Hide Password";
            }
            else
            {
                pass.PasswordChar = '*';
                checkBox2.Text = "Show Password";
            }
        }

        private void usernamestudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand("Select * From librarylogin Where username='" + user.Text + "' and password='" + pass.Text + "'", connect);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                library fh = new library();
                fh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Check Your Username & Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void librarylogin_Load(object sender, EventArgs e)
        {
            wrongstudent .Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (dashboard das = new dashboard())
            {
                das.ShowDialog();
                this.Hide();
            }
        }
    }
}
