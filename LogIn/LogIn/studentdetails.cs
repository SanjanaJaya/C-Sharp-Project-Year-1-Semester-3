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
    public partial class studentdetails : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Project\LogIn\LogIn\Databaseteacher.mdf;Integrated Security=True");

        public studentdetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentid.Text) || string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(grade.Text) || string.IsNullOrWhiteSpace(gender.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime today = DateTime.Today;
                    connect.Open();
                    string insertData = "INSERT INTO students (studentid, name, grade, gender) VALUES (@studentid, @name, @grade, @gender)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@studentid", studentid.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", name.Text.Trim());
                        cmd.Parameters.AddWithValue("@grade", grade.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", gender.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                   
                    string query = "SELECT studentid, name, grade, gender FROM students";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            using (dashboard das = new dashboard())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void studentdetails_Load(object sender, EventArgs e)
        {
    
            this.studentsTableAdapter.Fill(this.databaseteacherDataSet8.students);
            {

                try
                {
                
                    connect.Open();

             
                    string query = "SELECT studentid, name, grade, gender FROM students";

              
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);

                 
                    DataSet dataset = new DataSet();

            
                    adapter.Fill(dataset);

               
                    dataGridView1.DataSource = dataset.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
               
                    connect.Close();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studentid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            grade.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            gender.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete This Data", "Message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int rowIndex = dataGridView1.SelectedRows[0].Index;
                            int studentid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                           
                            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Project\LogIn\LogIn\Databaseteacher.mdf;Integrated Security=True"))
                            {
                                connect.Open();

                                string deleteQuery = "DELETE FROM students WHERE studentid = @studentid";

                                using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                                {
                                    cmd.Parameters.AddWithValue("@studentid", studentid);

                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Record deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                     
                                        dataGridView1.Rows.RemoveAt(rowIndex);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Record not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}