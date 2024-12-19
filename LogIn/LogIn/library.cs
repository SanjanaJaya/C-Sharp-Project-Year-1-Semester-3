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
using System.IO;
using System.Net;

namespace LogIn
{
    public partial class library : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Project\LogIn\LogIn\Databaseteacher.mdf;Integrated Security=True");


        public library()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime today = DateTime.Today;
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Project\LogIn\LogIn\Databaseteacher.mdf;Integrated Security=True"))
                    {
                        connect.Open();
                        string insertData = "INSERT INTO librarynew (bookname, borname, stid) VALUES (@bookname, @borname, @stid)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookname", textBox1.Text.Trim());
                            cmd.Parameters.AddWithValue("@borname", textBox2.Text.Trim());
                            cmd.Parameters.AddWithValue("@stid", textBox3.Text.Trim());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            LoadDataIntoDataGridView();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadDataIntoDataGridView()
        {
            try
            {
              
                connect.Open();

             
                string query = "SELECT stid, bookname, borname FROM librarynew";

             
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



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            using (dashboard das = new dashboard())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void clearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void brname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void library_Load(object sender, EventArgs e)
        {

            try
            {
                
                connect.Open();

             
                string query = "SELECT stid, bookname, borname FROM librarynew";

              
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are You Sure You Want To Delete This Data", "Message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int rowIndex = dataGridView1.SelectedRows[0].Index;
                        int stid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                     
                        using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Project\LogIn\LogIn\Databaseteacher.mdf;Integrated Security=True"))
                        {
                            connect.Open();

                            string deleteQuery = "DELETE FROM librarynew WHERE stid = @stid";

                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                            {
                                cmd.Parameters.AddWithValue("@stid", stid);

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