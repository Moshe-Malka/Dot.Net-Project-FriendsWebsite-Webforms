namespace DotNetFinalProject
{
    partial class NEW_CloseAccounts
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
            this.myDatabaseDataSet = new DotNetFinalProject.MyDatabaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new DotNetFinalProject.MyDatabaseDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new DotNetFinalProject.MyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.HomePictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton_PictureBox2 = new System.Windows.Forms.PictureBox();
            this.CloseAccountBtn = new System.Windows.Forms.Button();
            this.EmailToCancelTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompaniesContactsTableAdapter = null;
            this.tableAdapterManager.CompaniesTableAdapter = null;
            this.tableAdapterManager.EmploymentTableAdapter = null;
            this.tableAdapterManager.FieldsInHighTechTableAdapter = null;
            this.tableAdapterManager.JobsTableAdapter = null;
            this.tableAdapterManager.RecommendationsTableAdapter = null;
            this.tableAdapterManager.SubFieldsInHighTechTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DotNetFinalProject.MyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(0, 211);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.Size = new System.Drawing.Size(955, 346);
            this.usersDataGridView.TabIndex = 1;
            this.usersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lupa Planta", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(340, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 50);
            this.label1.TabIndex = 24;
            this.label1.Text = "Close Accounts";
            // 
            // HomePictureBox1
            // 
            this.HomePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.HomePictureBox1.Image = global::DotNetFinalProject.Properties.Resources.home_32;
            this.HomePictureBox1.Location = new System.Drawing.Point(901, 5);
            this.HomePictureBox1.Name = "HomePictureBox1";
            this.HomePictureBox1.Size = new System.Drawing.Size(32, 32);
            this.HomePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HomePictureBox1.TabIndex = 26;
            this.HomePictureBox1.TabStop = false;
            this.HomePictureBox1.Click += new System.EventHandler(this.HomePictureBox1_Click);
            // 
            // ExitButton_PictureBox2
            // 
            this.ExitButton_PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton_PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton_PictureBox2.Image = global::DotNetFinalProject.Properties.Resources.cancel_32;
            this.ExitButton_PictureBox2.Location = new System.Drawing.Point(950, 5);
            this.ExitButton_PictureBox2.Name = "ExitButton_PictureBox2";
            this.ExitButton_PictureBox2.Size = new System.Drawing.Size(32, 32);
            this.ExitButton_PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitButton_PictureBox2.TabIndex = 25;
            this.ExitButton_PictureBox2.TabStop = false;
            this.ExitButton_PictureBox2.Click += new System.EventHandler(this.ExitButton_PictureBox2_Click);
            // 
            // CloseAccountBtn
            // 
            this.CloseAccountBtn.Location = new System.Drawing.Point(387, 90);
            this.CloseAccountBtn.Name = "CloseAccountBtn";
            this.CloseAccountBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseAccountBtn.TabIndex = 27;
            this.CloseAccountBtn.Text = "Close";
            this.CloseAccountBtn.UseVisualStyleBackColor = true;
            this.CloseAccountBtn.Click += new System.EventHandler(this.CloseAccountBtn_Click);
            // 
            // EmailToCancelTextBox
            // 
            this.EmailToCancelTextBox.Location = new System.Drawing.Point(167, 93);
            this.EmailToCancelTextBox.Name = "EmailToCancelTextBox";
            this.EmailToCancelTextBox.Size = new System.Drawing.Size(204, 20);
            this.EmailToCancelTextBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Email of User :";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(468, 90);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 30;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // NEW_CloseAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DotNetFinalProject.Properties.Resources.light_blue_abstract_best;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 569);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailToCancelTextBox);
            this.Controls.Add(this.CloseAccountBtn);
            this.Controls.Add(this.HomePictureBox1);
            this.Controls.Add(this.ExitButton_PictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NEW_CloseAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW_CloseAccounts";
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MyDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private MyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HomePictureBox1;
        private System.Windows.Forms.PictureBox ExitButton_PictureBox2;
        private System.Windows.Forms.Button CloseAccountBtn;
        private System.Windows.Forms.TextBox EmailToCancelTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenBtn;
    }
}