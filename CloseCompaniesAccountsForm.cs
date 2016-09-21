using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetFinalProject
{
    public partial class CloseCompaniesAccountsForm : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ToString();
        SqlConnection SqlConnection = new SqlConnection(constring);
        SqlCommand SqlCommand = new SqlCommand();

        public CloseCompaniesAccountsForm()
        {
            InitializeComponent();
            BindCompaniesGrid();
        }

        private void BindCompaniesGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Employers ", con))
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

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            string queryString = "SELECT * FROM Employers WHERE CompanyId = @CompanyId";
            SqlCommand = new SqlCommand(queryString, SqlConnection);
            SqlCommand.Parameters.AddWithValue("@CompanyId", CompanyIDToCloseTextBox.Text);
            SqlDataReader reader = SqlCommand.ExecuteReader();           

            if (!reader.HasRows)
            {
                string message = "Field is not in Table / Table is Empty";
                MessageBox.Show(message);
                CompanyIDToCloseTextBox.Clear();
            }
            else
            {
                reader.Close();
                Button btn = sender as Button;
                if (btn.Name.Equals("CloseCompanyButton"))
                {
                    queryString = "UPDATE Employers SET Company_Active = 0 WHERE CompanyId = @CompanyId";
                    SqlCommand = new SqlCommand(queryString, SqlConnection);
                    SqlCommand.Parameters.AddWithValue("@CompanyId", CompanyIDToCloseTextBox.Text);

                    SqlDataReader reader2 = SqlCommand.ExecuteReader();
                    BindCompaniesGrid();

                    CompanyIDToCloseTextBox.Clear();
                    reader2.Close();
                }
                else
                {
                    queryString = "UPDATE Employers SET Company_Active = 1 WHERE CompanyId = @CompanyId";
                    SqlCommand = new SqlCommand(queryString, SqlConnection);
                    SqlCommand.Parameters.AddWithValue("@CompanyId", CompanyIDToCloseTextBox.Text);

                    SqlDataReader reader2 = SqlCommand.ExecuteReader();
                    BindCompaniesGrid();

                    CompanyIDToCloseTextBox.Clear();
                    reader2.Close();
                }  
            }
            SqlConnection.Close();
        }

        private void CloseCompaniesAccountsForm_Load(object sender, EventArgs e)
        {

        }

        private void HomePictureBox1_Click(object sender, EventArgs e)
        {
            AdminMainManu adm = new AdminMainManu();
            adm.Show();
            Hide();
        }

        private void ExitButton_PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
