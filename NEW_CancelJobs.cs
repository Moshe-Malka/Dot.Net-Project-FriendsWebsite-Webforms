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
using System.Configuration;

namespace DotNetFinalProject
{
    public partial class NEW_CancelJobs : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ToString();
        SqlConnection SqlConnection = new SqlConnection(constring);
        SqlCommand SqlCommand;

        public NEW_CancelJobs()
        {
            InitializeComponent();
            BindJobGrid();
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
        
        private void BindJobGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Jobs ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            jobsDataGridView.DataSource = dt;
                            jobsDataGridView.Sort(jobsDataGridView.Columns[0], ListSortDirection.Ascending);

                        }
                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            SqlCommand = new SqlCommand();
            SqlConnection.Open();
            string queryString = "SELECT * FROM Jobs WHERE JobId = @id";
            SqlCommand = new SqlCommand(queryString, SqlConnection);
            SqlCommand.Parameters.AddWithValue("@id", CancelJobIDTextBox.Text);
            SqlDataReader reader = SqlCommand.ExecuteReader();

            if (!reader.HasRows)
            {
                string message = "Job Id is Incorrect / Table is Empty";
                MessageBox.Show(message);
                CancelJobIDTextBox.Clear();               
            }
            else
            {
                reader.Close();
                queryString = "UPDATE FieldsInHighTech SET ActiveJob=0 WHERE JobId = @id";
                SqlCommand = new SqlCommand(queryString, SqlConnection);
                SqlCommand.Parameters.AddWithValue("@id", CancelJobIDTextBox.Text);

                SqlDataReader reader2 = SqlCommand.ExecuteReader();

                CancelJobIDTextBox.Clear();
                BindJobGrid();
                reader2.Close();
            }
            SqlConnection.Close();
        }
    }
}
