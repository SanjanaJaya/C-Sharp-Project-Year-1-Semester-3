using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;

namespace LogIn
{
    public partial class examlogin : Form
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.DatabaseteacherConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public examlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                student.Visible = true;
                teacher.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                teacher.Visible = true;
                student.Visible = false;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void examlogin_Load(object sender, EventArgs e)
        {
            
            this.tblteacherTableAdapter.Fill(this.databaseteacherDataSet.tblteacher);
            
            teacher.Visible = false;
            student.Visible = false;
            wronglabel.Visible = false;
            wrongstudent.Visible = false;

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                teacherloginpass.PasswordChar = '\0';
                checkBox1.Text = "Hide Password";
            }
            else
            {
                teacherloginpass.PasswordChar = '*';
                checkBox1.Text = "Show Password";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand("Select * From tblteacher Where username='" + usernameteacher.Text + "' and password='" + teacherloginpass.Text + "'", connect);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                teacherlogindash fh = new teacherlogindash();
                fh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Check Your Username & Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wronglabel_Click(object sender, EventArgs e)
        {

        }

        private void studentlogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand("Select * From tblstudent Where username='" + studentusername.Text + "' and password='" + studentloginpass.Text + "'", connect);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                Studentdashboard fh = new Studentdashboard();
                fh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Check Your Username & Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                studentloginpass.PasswordChar = '\0';
                checkBox2.Text = "Hide Password";
            }
            else
            {
                studentloginpass.PasswordChar = '*';
                checkBox2.Text = "Show Password";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void studentregister_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            using (dashboard das = new dashboard())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (dashboard das = new dashboard())
            {
                das.ShowDialog();
                this.Hide();
            }
        }
    }
}                   
                
            
        
    

