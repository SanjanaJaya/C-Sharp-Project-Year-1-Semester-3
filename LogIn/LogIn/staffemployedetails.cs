﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace LogIn
{
    public partial class staffemployedetails : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Project\LogIn\LogIn\Databaseteacher.mdf;Integrated Security=True");

        public staffemployedetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            using (dashboard das = new dashboard())
            {
                das.ShowDialog();
                this.Hide();
            }
        }

        private void staffemployedetails_Load(object sender, EventArgs e)
        {
            this.staffdetailsTableAdapter.Fill(this.databaseteacherDataSet8.staffdetails);
            {

                try
                {

                    connect.Open();


                    string query = "SELECT staffid, name, position, age FROM staffdetails";


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

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(staffname.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime today = DateTime.Today;
                    connect.Open();
                    string insertData = "INSERT INTO staffdetails (staffid, name, position, age) VALUES (@staffid, @name, @position, @age)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@staffid", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", staffname.Text.Trim());
                        cmd.Parameters.AddWithValue("@position", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@age", textBox2.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                   
                    string query = "SELECT staffid, name, position, age FROM staffdetails";
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
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            staffname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
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
                        int staffid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                  
                        using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Project\LogIn\LogIn\Databaseteacher.mdf;Integrated Security=True"))
                        {
                            connect.Open();

                            string deleteQuery = "DELETE FROM staffdetails WHERE staffid = @staffid";

                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                            {
                                cmd.Parameters.AddWithValue("@staffid", staffid);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

