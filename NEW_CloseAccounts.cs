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
    public partial class NEW_CloseAccounts : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ToString();
        SqlConnection SqlConnection = new SqlConnection(constring);
        SqlCommand SqlCommand = new SqlCommand();

        public NEW_CloseAccounts()
        {
            InitializeComponent();
            BindAccountGrid();
        }
        
        private void ExitButton_PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void HomePictureBox1_Click(object sender, EventArgs e)
        {
            AdminMainManu adm = new AdminMainManu();
            adm.Show();
            Hide();
        }
        private void BindAccountGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            usersDataGridView.DataSource = dt;
                            usersDataGridView.Sort(usersDataGridView.Columns[0], ListSortDirection.Ascending);

                        }
                    }
                }
            }
        }
        private void CloseAccountBtn_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            string queryString = "SELECT * FROM Users WHERE Email = @email";
            SqlCommand = new SqlCommand(queryString, SqlConnection);
            SqlCommand.Parameters.AddWithValue("@email", EmailToCancelTextBox.Text);
            SqlDataReader reader = SqlCommand.ExecuteReader();

            if (!reader.HasRows)
            {
                string message = "Field is not in Table / Table is Empty";
                MessageBox.Show(message);
                EmailToCancelTextBox.Clear();
            }
            else
            {
                reader.Close();
                queryString = "UPDATE Users SET Active_User = 0 WHERE Email = @email";
                SqlCommand = new SqlCommand(queryString, SqlConnection);
                SqlCommand.Parameters.AddWithValue("@email", EmailToCancelTextBox.Text);
                
                SqlDataReader reader2 = SqlCommand.ExecuteReader();
                BindAccountGrid();

                EmailToCancelTextBox.Clear();
                reader2.Close();
            }
            SqlConnection.Close();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            string queryString = "SELECT * FROM Users WHERE Email = @email";
            SqlCommand = new SqlCommand(queryString, SqlConnection);
            SqlCommand.Parameters.AddWithValue("@email", EmailToCancelTextBox.Text);
            SqlDataReader reader = SqlCommand.ExecuteReader();

            if (!reader.HasRows)
            {
                string message = "User Not In Table !";
                MessageBox.Show(message);
                EmailToCancelTextBox.Clear();
            }
            else
            {
                reader.Close();
                queryString = "UPDATE Users SET Active_User = 1 WHERE Email = @email";
                SqlCommand = new SqlCommand(queryString, SqlConnection);
                SqlCommand.Parameters.AddWithValue("@email", EmailToCancelTextBox.Text);

                SqlDataReader reader2 = SqlCommand.ExecuteReader();
                BindAccountGrid();

                EmailToCancelTextBox.Clear();
                reader2.Close();
            }
            SqlConnection.Close();
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
