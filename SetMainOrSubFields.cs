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
    public partial class SetMainOrSubFields : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(constring);
        SqlCommand cmd = null;

        public SetMainOrSubFields()
        {
            InitializeComponent();
        }

        private void SetMainOrSubFields_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseDataSet.FieldsInHighTech' table. You can move, or remove it, as needed.
            this.fieldsInHighTechTableAdapter.Fill(this.myDatabaseDataSet.FieldsInHighTech);

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

        private void chkChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (MainFieldsRadioButton.Checked)
            {
                BindMainFields();

                label2.Visible = true;
                MainFieldTextBox.Visible = true;
                SetMainFieldBtn.Visible = true;

                label5.Visible = false;
                label3.Visible = false;
                MainIDComboBox.Enabled = false;
                MainIDComboBox.Visible = false;
                SubValueTextBox.Visible = false;
                SetSubFieldBtn.Visible = false;
            }
            else
            {
                BindSubFields();
                MainIDComboBox.Update();
                label5.Visible = true;
                label3.Visible = true;
                MainIDComboBox.Visible = true;
                MainIDComboBox.Enabled = true;
                SubValueTextBox.Visible = true;
                SetSubFieldBtn.Visible = true;

                label2.Visible = false;
                MainFieldTextBox.Visible = false;
                SetMainFieldBtn.Visible = false;
            }
        }

        private void BindSubFields()
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
                            dataGridView1.DataSource = dt;
                            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                        }
                    }
                }
            }
        }

        private void BindMainFields()
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

        private void SetMainFieldBtn_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO FieldsInHighTech VALUES(@value2,@bool)";
            cmd = new SqlCommand(queryString, conn);
            cmd.Parameters.AddWithValue("@value2", MainFieldTextBox.Text);
            cmd.Parameters.AddWithValue("@bool", 1);
            conn.Open();

            cmd.ExecuteNonQuery();

            BindMainFields();
            conn.Close();

        }

        private void SetSubFieldBtn_Click(object sender, EventArgs e)
        {
            conn.Close();
            string queryString2 = "INSERT INTO SubFieldsInHighTech VALUES(@value1,@value3,1)";
            cmd = new SqlCommand(queryString2, conn);
            cmd.Parameters.AddWithValue("@value1", MainIDComboBox.SelectedValue);
            cmd.Parameters.AddWithValue("@value3", SubValueTextBox.Text);
            conn.Open();

            cmd.ExecuteNonQuery();

            BindSubFields();
            conn.Close();

        }
    }
}
