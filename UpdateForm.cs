using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetFinalProject
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void ExitButton_PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePictureBox1_Click(object sender, EventArgs e)
        {
            AdminMainManu adm1 = new AdminMainManu();
            adm1.Show();
            Close();
        }

        private void CheckedRadioButton(object sender, EventArgs e)
        {
            if (MainRadioButton.Checked)
            {
                /*
                    code to change DATAGRIDVEW to FieldsInHighTech Table
                */

                MainFieldsComboBox.Visible = true;
                SubFieldsComboBox.Visible = false;
            }

            else
            {

                /*
                    code to change DATAGRIDVEW to SubFieldsInHighTech Table
                */
                SubFieldsComboBox.Visible = true;            
                MainFieldsComboBox.Visible = false;
            }
            UpdateValueLabel.Visible = true;
            UpdateValueTextBox.Visible = true;
            UpdateButton.Visible = true;
        }
    }
}
