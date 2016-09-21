using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DotNetFinalProject
{
    public partial class NEW_UpdateFields : Form
    {

        static string constring = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ToString();
        SqlConnection SqlConnection = new SqlConnection(constring);
        SqlCommand SqlCommand = null;


        public NEW_UpdateFields()
        {
            InitializeComponent();
            BindMainGrid();
            BindSubGrid();
        }

        private void ExitButton_PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            AdminMainManu adm = new AdminMainManu();
            adm.Show();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (MainRadioButton.Checked)
            {
                label2.Visible = true;
                label3.Visible = true;
                ValueToUpdate_Main.Visible = true;
                NewValue_Main.Visible = true;
                MainBtn.Visible = true;
                dataGridView1.Visible = true;

                label4.Visible = false;
                label5.Visible = false;
                ValueToUpdate_Sub.Visible = false;
                NewValue_Sub.Visible = false;
                SubBtn.Visible = false;
                dataGridView2.Visible = false;
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                ValueToUpdate_Main.Visible = false;
                NewValue_Main.Visible = false;
                MainBtn.Visible = false;
                dataGridView1.Visible = false;

                label4.Visible = true;
                label5.Visible = true;
                ValueToUpdate_Sub.Visible = true;
                NewValue_Sub.Visible = true;
                SubBtn.Visible = true;
                dataGridView2.Visible = true;
            }
        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            string queryString = "SELECT * FROM FieldsInHighTech WHERE FieldName = @name";
            SqlCommand = new SqlCommand(queryString, SqlConnection);
            SqlCommand.Parameters.AddWithValue("@name", ValueToUpdate_Main.Text);
            SqlDataReader reader = SqlCommand.ExecuteReader();

            if (!reader.HasRows)
            {
                string message = "Field is not in Table / Table is Empty";
                MessageBox.Show(message);
                ValueToUpdate_Main.Clear();
                NewValue_Main.Clear();
            }
            else
            {
                reader.Close();
                queryString = "UPDATE FieldsInHighTech SET FieldName = @newname WHERE FieldName = @name ";
                SqlCommand = new SqlCommand(queryString, SqlConnection);
                SqlCommand.Parameters.AddWithValue("@name", ValueToUpdate_Main.Text);
                SqlCommand.Parameters.AddWithValue("@newname", NewValue_Main.Text);

                SqlDataReader reader2 = SqlCommand.ExecuteReader();

                ValueToUpdate_Main.Clear();
                NewValue_Main.Clear();
                BindMainGrid();
                reader2.Close();
            }

            SqlConnection.Close();

        }

        private void BindMainGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM FieldsInHighTech ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

                        }
                    }
                }
            }
        }

        private void BindSubGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SubFieldsInHighTech ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView2.DataSource = dt;
                            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

                        }
                    }
                }
            }
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {

            SqlCommand = new SqlCommand();
            SqlConnection.Open();
            string queryString = "SELECT * FROM SubFieldsInHighTech WHERE SubFieldName = @name";
            SqlCommand = new SqlCommand(queryString, SqlConnection);
            SqlCommand.Parameters.AddWithValue("@name", ValueToUpdate_Sub.Text);
            SqlDataReader reader = SqlCommand.ExecuteReader();

            if (!reader.HasRows)
            {
                string message = "Sub Field is not in Table";
                MessageBox.Show(message);
                ValueToUpdate_Sub.Clear();
                NewValue_Sub.Clear();
            }
            else
            {
                reader.Close();
                queryString = "UPDATE SubFieldsInHighTech SET SubFieldName = @newname WHERE SubFieldName = @name";
                SqlCommand = new SqlCommand(queryString, SqlConnection);
                SqlCommand.Parameters.AddWithValue("@name", ValueToUpdate_Sub.Text);
                SqlCommand.Parameters.AddWithValue("@newname", NewValue_Sub.Text);

                SqlDataReader reader2 = SqlCommand.ExecuteReader();

                ValueToUpdate_Sub.Clear();
                NewValue_Sub.Clear();
                BindSubGrid();
                reader2.Close();
            }

            SqlConnection.Close();

        }

        private void GetCellContent(object sender, DataGridViewCellEventArgs e)
        {
                NewValue_Main.Text = dataGridView1.SelectedCells[0].Value.ToString();
                ValueToUpdate_Main.Text = dataGridView1.SelectedCells[0].Value.ToString();           
        }

        private void GetSubContent(object sender, DataGridViewCellEventArgs e)
        {
            NewValue_Sub.Text = dataGridView2.SelectedCells[0].Value.ToString();
            ValueToUpdate_Sub.Text = dataGridView2.SelectedCells[0].Value.ToString();
        }
    }
}

