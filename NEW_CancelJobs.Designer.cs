namespace DotNetFinalProject
{
    partial class NEW_CancelJobs
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
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobsTableAdapter = new DotNetFinalProject.MyDatabaseDataSetTableAdapters.JobsTableAdapter();
            this.tableAdapterManager = new DotNetFinalProject.MyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.jobsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.HomePictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton_PictureBox2 = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelJobIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "Jobs";
            this.jobsBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompaniesContactsTableAdapter = null;
            this.tableAdapterManager.CompaniesTableAdapter = null;
            this.tableAdapterManager.EmploymentTableAdapter = null;
            this.tableAdapterManager.FieldsInHighTechTableAdapter = null;
            this.tableAdapterManager.JobsTableAdapter = this.jobsTableAdapter;
            this.tableAdapterManager.RecommendationsTableAdapter = null;
            this.tableAdapterManager.SubFieldsInHighTechTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DotNetFinalProject.MyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // jobsDataGridView
            // 
            this.jobsDataGridView.AllowUserToAddRows = false;
            this.jobsDataGridView.AllowUserToDeleteRows = false;
            this.jobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsDataGridView.Location = new System.Drawing.Point(17, 194);
            this.jobsDataGridView.Name = "jobsDataGridView";
            this.jobsDataGridView.ReadOnly = true;
            this.jobsDataGridView.Size = new System.Drawing.Size(945, 363);
            this.jobsDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lupa Planta", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 50);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cancel Jobs";
            // 
            // HomePictureBox1
            // 
            this.HomePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.HomePictureBox1.Image = global::DotNetFinalProject.Properties.Resources.home_32;
            this.HomePictureBox1.Location = new System.Drawing.Point(901, 5);
            this.HomePictureBox1.Name = "HomePictureBox1";
            this.HomePictureBox1.Size = new System.Drawing.Size(32, 32);
            this.HomePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HomePictureBox1.TabIndex = 24;
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
            this.ExitButton_PictureBox2.TabIndex = 23;
            this.ExitButton_PictureBox2.TabStop = false;
            this.ExitButton_PictureBox2.Click += new System.EventHandler(this.ExitButton_PictureBox2_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(330, 99);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 25;
            this.CancelBtn.Text = "Cancel Job";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Job ID To Cancel :";
            // 
            // CancelJobIDTextBox
            // 
            this.CancelJobIDTextBox.Location = new System.Drawing.Point(152, 99);
            this.CancelJobIDTextBox.Name = "CancelJobIDTextBox";
            this.CancelJobIDTextBox.Size = new System.Drawing.Size(161, 20);
            this.CancelJobIDTextBox.TabIndex = 27;
            // 
            // NEW_CancelJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DotNetFinalProject.Properties.Resources.light_blue_abstract_best;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 569);
            this.Controls.Add(this.CancelJobIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.HomePictureBox1);
            this.Controls.Add(this.ExitButton_PictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NEW_CancelJobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_CancelJobs";
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private MyDatabaseDataSetTableAdapters.JobsTableAdapter jobsTableAdapter;
        private MyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView jobsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HomePictureBox1;
        private System.Windows.Forms.PictureBox ExitButton_PictureBox2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CancelJobIDTextBox;
    }
}