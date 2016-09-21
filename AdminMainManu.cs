using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DotNetFinalProject
{
    public partial class AdminMainManu : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(constring);
        SqlCommand cmd = null;

        public AdminMainManu()
        {
            InitializeComponent();
        }

        private void ExitButton_PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetFormButton_Click(object sender, EventArgs e)
        {
            NEW_UpdateFields s1 = new NEW_UpdateFields();
            s1.Show();
            Hide();
        }

        private void UpdateFormButton_Click(object sender, EventArgs e)
        {
            UpdateFieldsForm u1 = new UpdateFieldsForm();
            u1.Show();
            Hide();
        }

        private void CancelJobsFormButton_Click(object sender, EventArgs e)
        {
            NEW_CancelJobs c2 = new NEW_CancelJobs();
            c2.Show();
            Hide();        
        }

        private void CloseAccountsFormButton_Click(object sender, EventArgs e)
        {
            NEW_CloseAccounts ca = new NEW_CloseAccounts();
            ca.Show();
            Hide();            
        }

        private void CloseCompanyAccountsFormButton_Click(object sender, EventArgs e)
        {
            CloseCompaniesAccountsForm cca = new CloseCompaniesAccountsForm();
            cca.Show();
            Hide();
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {
            SetMainOrSubFields s = new SetMainOrSubFields();
            s.Show();
            Hide();
        }

        private void AdminMainManu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseDataSet.Users' table. You can move, or remove it, as needed.
            FillGridAssigning();
            FillGridRandomUsers();
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;

        }

        private void FillGridRandomUsers()
        {
            string query = "SELECT TOP 5 * FROM Users ORDER BY NEWID()";
            cmd = new SqlCommand(query, conn);

            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                using (DataTable dt = new DataTable())
                {
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void FillGridAssigning()
        {
            string query = "SELECT TOP 5 * FROM Hasama ORDER BY TimeOfHasama DESC";
            cmd = new SqlCommand(query, conn);

            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                using (DataTable dt = new DataTable())
                {
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
            }
        }

        private void ExitButton_PictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FillGridRandomUsers();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            FillGridAssigning();

        }

        private void ExitButton_PictureBox2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
