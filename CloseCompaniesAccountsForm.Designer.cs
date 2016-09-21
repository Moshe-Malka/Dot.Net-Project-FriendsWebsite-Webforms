namespace DotNetFinalProject
{
    partial class CloseCompaniesAccountsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyIDToCloseTextBox = new System.Windows.Forms.TextBox();
            this.CloseCompanyButton = new System.Windows.Forms.Button();
            this.HomePictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton_PictureBox2 = new System.Windows.Forms.PictureBox();
            this.OpenCompanyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lupa Planta", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(147, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 50);
            this.label1.TabIndex = 25;
            this.label1.Text = "Close Companies Accounts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(940, 385);
            this.dataGridView1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Company ID  : ";
            // 
            // CompanyIDToCloseTextBox
            // 
            this.CompanyIDToCloseTextBox.Location = new System.Drawing.Point(113, 109);
            this.CompanyIDToCloseTextBox.Name = "CompanyIDToCloseTextBox";
            this.CompanyIDToCloseTextBox.Size = new System.Drawing.Size(196, 20);
            this.CompanyIDToCloseTextBox.TabIndex = 28;
            // 
            // CloseCompanyButton
            // 
            this.CloseCompanyButton.Location = new System.Drawing.Point(324, 106);
            this.CloseCompanyButton.Name = "CloseCompanyButton";
            this.CloseCompanyButton.Size = new System.Drawing.Size(117, 23);
            this.CloseCompanyButton.TabIndex = 29;
            this.CloseCompanyButton.Text = "Close";
            this.CloseCompanyButton.UseVisualStyleBackColor = true;
            this.CloseCompanyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // HomePictureBox1
            // 
            this.HomePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.HomePictureBox1.Image = global::DotNetFinalProject.Properties.Resources.home_32;
            this.HomePictureBox1.Location = new System.Drawing.Point(898, 3);
            this.HomePictureBox1.Name = "HomePictureBox1";
            this.HomePictureBox1.Size = new System.Drawing.Size(32, 32);
            this.HomePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HomePictureBox1.TabIndex = 31;
            this.HomePictureBox1.TabStop = false;
            this.HomePictureBox1.Click += new System.EventHandler(this.HomePictureBox1_Click);
            // 
            // ExitButton_PictureBox2
            // 
            this.ExitButton_PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton_PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton_PictureBox2.Image = global::DotNetFinalProject.Properties.Resources.cancel_32;
            this.ExitButton_PictureBox2.Location = new System.Drawing.Point(945, 3);
            this.ExitButton_PictureBox2.Name = "ExitButton_PictureBox2";
            this.ExitButton_PictureBox2.Size = new System.Drawing.Size(32, 32);
            this.ExitButton_PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitButton_PictureBox2.TabIndex = 32;
            this.ExitButton_PictureBox2.TabStop = false;
            this.ExitButton_PictureBox2.Click += new System.EventHandler(this.ExitButton_PictureBox2_Click);
            // 
            // OpenCompanyButton
            // 
            this.OpenCompanyButton.Location = new System.Drawing.Point(447, 106);
            this.OpenCompanyButton.Name = "OpenCompanyButton";
            this.OpenCompanyButton.Size = new System.Drawing.Size(117, 23);
            this.OpenCompanyButton.TabIndex = 36;
            this.OpenCompanyButton.Text = "Open";
            this.OpenCompanyButton.UseVisualStyleBackColor = true;
            this.OpenCompanyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // CloseCompaniesAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DotNetFinalProject.Properties.Resources.light_blue_abstract_best;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 569);
            this.Controls.Add(this.OpenCompanyButton);
            this.Controls.Add(this.ExitButton_PictureBox2);
            this.Controls.Add(this.HomePictureBox1);
            this.Controls.Add(this.CloseCompanyButton);
            this.Controls.Add(this.CompanyIDToCloseTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CloseCompaniesAccountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloseCompaniesAccountsForm";
            this.Load += new System.EventHandler(this.CloseCompaniesAccountsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CompanyIDToCloseTextBox;
        private System.Windows.Forms.Button CloseCompanyButton;
        private System.Windows.Forms.PictureBox HomePictureBox1;
        private System.Windows.Forms.PictureBox ExitButton_PictureBox2;
        private System.Windows.Forms.Button OpenCompanyButton;
    }
}