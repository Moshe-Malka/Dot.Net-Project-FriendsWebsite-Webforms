namespace DotNetFinalProject
{
    partial class AdminMainManu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SetFormButton = new System.Windows.Forms.Button();
            this.CloseAccountsFormButton = new System.Windows.Forms.Button();
            this.CancelJobsFormButton = new System.Windows.Forms.Button();
            this.CloseCompanyAccountsFormButton = new System.Windows.Forms.Button();
            this.SetBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myDatabaseDataSet = new DotNetFinalProject.MyDatabaseDataSet();
            this.myDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new DotNetFinalProject.MyDatabaseDataSetTableAdapters.UsersTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton_PictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lupa Planta", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 74);
            this.label1.TabIndex = 15;
            this.label1.Text = "Admin Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SetFormButton
            // 
            this.SetFormButton.BackColor = System.Drawing.Color.Transparent;
            this.SetFormButton.BackgroundImage = global::DotNetFinalProject.Properties.Resources.g3;
            this.SetFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetFormButton.FlatAppearance.BorderSize = 0;
            this.SetFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SetFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetFormButton.Font = new System.Drawing.Font("Lupa Planta", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SetFormButton.Location = new System.Drawing.Point(41, 179);
            this.SetFormButton.Name = "SetFormButton";
            this.SetFormButton.Size = new System.Drawing.Size(230, 49);
            this.SetFormButton.TabIndex = 16;
            this.SetFormButton.Text = "Update Main/Sub Fields";
            this.SetFormButton.UseVisualStyleBackColor = false;
            this.SetFormButton.Click += new System.EventHandler(this.SetFormButton_Click);
            // 
            // CloseAccountsFormButton
            // 
            this.CloseAccountsFormButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseAccountsFormButton.BackgroundImage = global::DotNetFinalProject.Properties.Resources.g3;
            this.CloseAccountsFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseAccountsFormButton.FlatAppearance.BorderSize = 0;
            this.CloseAccountsFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseAccountsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAccountsFormButton.Font = new System.Drawing.Font("Lupa Planta", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CloseAccountsFormButton.Location = new System.Drawing.Point(524, 179);
            this.CloseAccountsFormButton.Name = "CloseAccountsFormButton";
            this.CloseAccountsFormButton.Size = new System.Drawing.Size(230, 49);
            this.CloseAccountsFormButton.TabIndex = 19;
            this.CloseAccountsFormButton.Text = "Close Accounts";
            this.CloseAccountsFormButton.UseVisualStyleBackColor = false;
            this.CloseAccountsFormButton.Click += new System.EventHandler(this.CloseAccountsFormButton_Click);
            // 
            // CancelJobsFormButton
            // 
            this.CancelJobsFormButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelJobsFormButton.BackgroundImage = global::DotNetFinalProject.Properties.Resources.g3;
            this.CancelJobsFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelJobsFormButton.FlatAppearance.BorderSize = 0;
            this.CancelJobsFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CancelJobsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelJobsFormButton.Font = new System.Drawing.Font("Lupa Planta", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CancelJobsFormButton.Location = new System.Drawing.Point(524, 87);
            this.CancelJobsFormButton.Name = "CancelJobsFormButton";
            this.CancelJobsFormButton.Size = new System.Drawing.Size(230, 49);
            this.CancelJobsFormButton.TabIndex = 18;
            this.CancelJobsFormButton.Text = "Cancel Jobs";
            this.CancelJobsFormButton.UseVisualStyleBackColor = false;
            this.CancelJobsFormButton.Click += new System.EventHandler(this.CancelJobsFormButton_Click);
            // 
            // CloseCompanyAccountsFormButton
            // 
            this.CloseCompanyAccountsFormButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseCompanyAccountsFormButton.BackgroundImage = global::DotNetFinalProject.Properties.Resources.g3;
            this.CloseCompanyAccountsFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseCompanyAccountsFormButton.FlatAppearance.BorderSize = 0;
            this.CloseCompanyAccountsFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseCompanyAccountsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseCompanyAccountsFormButton.Font = new System.Drawing.Font("Lupa Planta", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CloseCompanyAccountsFormButton.Location = new System.Drawing.Point(288, 116);
            this.CloseCompanyAccountsFormButton.Name = "CloseCompanyAccountsFormButton";
            this.CloseCompanyAccountsFormButton.Size = new System.Drawing.Size(230, 77);
            this.CloseCompanyAccountsFormButton.TabIndex = 20;
            this.CloseCompanyAccountsFormButton.Text = "Close Company Accounts";
            this.CloseCompanyAccountsFormButton.UseVisualStyleBackColor = false;
            this.CloseCompanyAccountsFormButton.Click += new System.EventHandler(this.CloseCompanyAccountsFormButton_Click);
            // 
            // SetBtn
            // 
            this.SetBtn.BackColor = System.Drawing.Color.Transparent;
            this.SetBtn.BackgroundImage = global::DotNetFinalProject.Properties.Resources.g3;
            this.SetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetBtn.FlatAppearance.BorderSize = 0;
            this.SetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetBtn.Font = new System.Drawing.Font("Lupa Planta", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SetBtn.Location = new System.Drawing.Point(41, 87);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(230, 49);
            this.SetBtn.TabIndex = 21;
            this.SetBtn.Text = "Set Main/Sub Fields";
            this.SetBtn.UseVisualStyleBackColor = false;
            this.SetBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(427, 192);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.Visible = false;
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDatabaseDataSetBindingSource
            // 
            this.myDatabaseDataSetBindingSource.DataSource = this.myDatabaseDataSet;
            this.myDatabaseDataSetBindingSource.Position = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(485, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(299, 195);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(497, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "5 New Assigning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(162, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "5 Random Users";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DotNetFinalProject.Properties.Resources.reload;
            this.pictureBox1.Location = new System.Drawing.Point(372, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ExitButton_PictureBox2
            // 
            this.ExitButton_PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton_PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton_PictureBox2.Image = global::DotNetFinalProject.Properties.Resources.cancel_32;
            this.ExitButton_PictureBox2.Location = new System.Drawing.Point(756, 9);
            this.ExitButton_PictureBox2.Name = "ExitButton_PictureBox2";
            this.ExitButton_PictureBox2.Size = new System.Drawing.Size(32, 32);
            this.ExitButton_PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitButton_PictureBox2.TabIndex = 29;
            this.ExitButton_PictureBox2.TabStop = false;
            this.ExitButton_PictureBox2.Click += new System.EventHandler(this.ExitButton_PictureBox2_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DotNetFinalProject.Properties.Resources.reload;
            this.pictureBox2.Location = new System.Drawing.Point(722, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // AdminMainManu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DotNetFinalProject.Properties.Resources.light_blue_abstract_best;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ExitButton_PictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SetBtn);
            this.Controls.Add(this.CloseCompanyAccountsFormButton);
            this.Controls.Add(this.CloseAccountsFormButton);
            this.Controls.Add(this.CancelJobsFormButton);
            this.Controls.Add(this.SetFormButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMainManu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainManu";
            this.Load += new System.EventHandler(this.AdminMainManu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetFormButton;
        private System.Windows.Forms.Button CloseAccountsFormButton;
        private System.Windows.Forms.Button CancelJobsFormButton;
        private System.Windows.Forms.Button CloseCompanyAccountsFormButton;
        private System.Windows.Forms.Button SetBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource myDatabaseDataSetBindingSource;
        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MyDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ExitButton_PictureBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}