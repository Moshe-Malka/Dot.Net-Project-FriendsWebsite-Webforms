namespace DotNetFinalProject
{
    partial class NEW_UpdateFields
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
            this.fieldsInHighTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldsInHighTechTableAdapter = new DotNetFinalProject.MyDatabaseDataSetTableAdapters.FieldsInHighTechTableAdapter();
            this.tableAdapterManager = new DotNetFinalProject.MyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.subFieldsInHighTechTableAdapter = new DotNetFinalProject.MyDatabaseDataSetTableAdapters.SubFieldsInHighTechTableAdapter();
            this.subFieldsInHighTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton_PictureBox2 = new System.Windows.Forms.PictureBox();
            this.HomePictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SubRadioButton = new System.Windows.Forms.RadioButton();
            this.MainRadioButton = new System.Windows.Forms.RadioButton();
            this.SubBtn = new System.Windows.Forms.Button();
            this.NewValue_Sub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ValueToUpdate_Sub = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MainBtn = new System.Windows.Forms.Button();
            this.NewValue_Main = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValueToUpdate_Main = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsInHighTechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFieldsInHighTechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldsInHighTechBindingSource
            // 
            this.fieldsInHighTechBindingSource.DataMember = "FieldsInHighTech";
            this.fieldsInHighTechBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // fieldsInHighTechTableAdapter
            // 
            this.fieldsInHighTechTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompaniesContactsTableAdapter = null;
            this.tableAdapterManager.CompaniesTableAdapter = null;
            this.tableAdapterManager.EmploymentTableAdapter = null;
            this.tableAdapterManager.FieldsInHighTechTableAdapter = this.fieldsInHighTechTableAdapter;
            this.tableAdapterManager.JobsTableAdapter = null;
            this.tableAdapterManager.RecommendationsTableAdapter = null;
            this.tableAdapterManager.SubFieldsInHighTechTableAdapter = this.subFieldsInHighTechTableAdapter;
            this.tableAdapterManager.UpdateOrder = DotNetFinalProject.MyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // subFieldsInHighTechTableAdapter
            // 
            this.subFieldsInHighTechTableAdapter.ClearBeforeFill = true;
            // 
            // subFieldsInHighTechBindingSource
            // 
            this.subFieldsInHighTechBindingSource.DataMember = "SubFieldsInHighTech";
            this.subFieldsInHighTechBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lupa Planta", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(244, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "Update Main / Sub Fields";
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
            this.ExitButton_PictureBox2.TabIndex = 18;
            this.ExitButton_PictureBox2.TabStop = false;
            this.ExitButton_PictureBox2.Click += new System.EventHandler(this.ExitButton_PictureBox2_Click);
            // 
            // HomePictureBox1
            // 
            this.HomePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.HomePictureBox1.Image = global::DotNetFinalProject.Properties.Resources.home_32;
            this.HomePictureBox1.Location = new System.Drawing.Point(901, 5);
            this.HomePictureBox1.Name = "HomePictureBox1";
            this.HomePictureBox1.Size = new System.Drawing.Size(32, 32);
            this.HomePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HomePictureBox1.TabIndex = 22;
            this.HomePictureBox1.TabStop = false;
            this.HomePictureBox1.Click += new System.EventHandler(this.HomePictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(409, 350);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetCellContent);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(518, 197);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(394, 350);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetSubContent);
            // 
            // SubRadioButton
            // 
            this.SubRadioButton.AutoSize = true;
            this.SubRadioButton.Location = new System.Drawing.Point(663, 58);
            this.SubRadioButton.Name = "SubRadioButton";
            this.SubRadioButton.Size = new System.Drawing.Size(74, 17);
            this.SubRadioButton.TabIndex = 26;
            this.SubRadioButton.Text = "Sub Fields";
            this.SubRadioButton.UseVisualStyleBackColor = true;
            this.SubRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // MainRadioButton
            // 
            this.MainRadioButton.AutoSize = true;
            this.MainRadioButton.Location = new System.Drawing.Point(212, 58);
            this.MainRadioButton.Name = "MainRadioButton";
            this.MainRadioButton.Size = new System.Drawing.Size(78, 17);
            this.MainRadioButton.TabIndex = 25;
            this.MainRadioButton.Text = "Main Fields";
            this.MainRadioButton.UseVisualStyleBackColor = true;
            this.MainRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // SubBtn
            // 
            this.SubBtn.Location = new System.Drawing.Point(787, 122);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(81, 35);
            this.SubBtn.TabIndex = 46;
            this.SubBtn.Text = "Update";
            this.SubBtn.UseVisualStyleBackColor = true;
            this.SubBtn.Visible = false;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // NewValue_Sub
            // 
            this.NewValue_Sub.Location = new System.Drawing.Point(663, 144);
            this.NewValue_Sub.Name = "NewValue_Sub";
            this.NewValue_Sub.Size = new System.Drawing.Size(100, 20);
            this.NewValue_Sub.TabIndex = 45;
            this.NewValue_Sub.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "New Value :";
            this.label4.Visible = false;
            // 
            // ValueToUpdate_Sub
            // 
            this.ValueToUpdate_Sub.Enabled = false;
            this.ValueToUpdate_Sub.Location = new System.Drawing.Point(663, 108);
            this.ValueToUpdate_Sub.Name = "ValueToUpdate_Sub";
            this.ValueToUpdate_Sub.Size = new System.Drawing.Size(100, 20);
            this.ValueToUpdate_Sub.TabIndex = 43;
            this.ValueToUpdate_Sub.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Value To Update :";
            this.label5.Visible = false;
            // 
            // MainBtn
            // 
            this.MainBtn.Location = new System.Drawing.Point(348, 121);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(81, 35);
            this.MainBtn.TabIndex = 51;
            this.MainBtn.Text = "Update";
            this.MainBtn.UseVisualStyleBackColor = true;
            this.MainBtn.Visible = false;
            this.MainBtn.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // NewValue_Main
            // 
            this.NewValue_Main.Location = new System.Drawing.Point(212, 140);
            this.NewValue_Main.Name = "NewValue_Main";
            this.NewValue_Main.Size = new System.Drawing.Size(100, 20);
            this.NewValue_Main.TabIndex = 50;
            this.NewValue_Main.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "New Value :";
            this.label3.Visible = false;
            // 
            // ValueToUpdate_Main
            // 
            this.ValueToUpdate_Main.Enabled = false;
            this.ValueToUpdate_Main.Location = new System.Drawing.Point(212, 104);
            this.ValueToUpdate_Main.Name = "ValueToUpdate_Main";
            this.ValueToUpdate_Main.Size = new System.Drawing.Size(100, 20);
            this.ValueToUpdate_Main.TabIndex = 48;
            this.ValueToUpdate_Main.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Value To Update :";
            this.label2.Visible = false;
            // 
            // NEW_UpdateFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DotNetFinalProject.Properties.Resources.light_blue_abstract_best;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 569);
            this.Controls.Add(this.MainBtn);
            this.Controls.Add(this.NewValue_Main);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValueToUpdate_Main);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.NewValue_Sub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ValueToUpdate_Sub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HomePictureBox1);
            this.Controls.Add(this.SubRadioButton);
            this.Controls.Add(this.MainRadioButton);
            this.Controls.Add(this.ExitButton_PictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NEW_UpdateFields";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW_SetFields";
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsInHighTechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFieldsInHighTechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource fieldsInHighTechBindingSource;
        private MyDatabaseDataSetTableAdapters.FieldsInHighTechTableAdapter fieldsInHighTechTableAdapter;
        private MyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MyDatabaseDataSetTableAdapters.SubFieldsInHighTechTableAdapter subFieldsInHighTechTableAdapter;
        private System.Windows.Forms.BindingSource subFieldsInHighTechBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ExitButton_PictureBox2;
        private System.Windows.Forms.PictureBox HomePictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton SubRadioButton;
        private System.Windows.Forms.RadioButton MainRadioButton;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.TextBox NewValue_Sub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ValueToUpdate_Sub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MainBtn;
        private System.Windows.Forms.TextBox NewValue_Main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValueToUpdate_Main;
        private System.Windows.Forms.Label label2;
    }
}