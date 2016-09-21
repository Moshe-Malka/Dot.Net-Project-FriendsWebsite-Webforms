namespace DotNetFinalProject
{
    partial class SetMainOrSubFields
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
            this.HomePictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton_PictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MainFieldsRadioButton = new System.Windows.Forms.RadioButton();
            this.SubFieldsRadioButton = new System.Windows.Forms.RadioButton();
            this.MainFieldTextBox = new System.Windows.Forms.TextBox();
            this.SetMainFieldBtn = new System.Windows.Forms.Button();
            this.SetSubFieldBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SubValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MainIDComboBox = new System.Windows.Forms.ComboBox();
            this.fieldsInHighTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabaseDataSet = new DotNetFinalProject.MyDatabaseDataSet();
            this.fieldsInHighTechTableAdapter = new DotNetFinalProject.MyDatabaseDataSetTableAdapters.FieldsInHighTechTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsInHighTechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lupa Planta", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 50);
            this.label1.TabIndex = 25;
            this.label1.Text = "Set Main / Sub Fields";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(975, 370);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Main Value To Set : ";
            // 
            // MainFieldsRadioButton
            // 
            this.MainFieldsRadioButton.AutoSize = true;
            this.MainFieldsRadioButton.Location = new System.Drawing.Point(191, 77);
            this.MainFieldsRadioButton.Name = "MainFieldsRadioButton";
            this.MainFieldsRadioButton.Size = new System.Drawing.Size(78, 17);
            this.MainFieldsRadioButton.TabIndex = 28;
            this.MainFieldsRadioButton.Text = "Main Fields";
            this.MainFieldsRadioButton.UseVisualStyleBackColor = true;
            this.MainFieldsRadioButton.CheckedChanged += new System.EventHandler(this.chkChanged);
            // 
            // SubFieldsRadioButton
            // 
            this.SubFieldsRadioButton.AutoSize = true;
            this.SubFieldsRadioButton.Location = new System.Drawing.Point(651, 77);
            this.SubFieldsRadioButton.Name = "SubFieldsRadioButton";
            this.SubFieldsRadioButton.Size = new System.Drawing.Size(74, 17);
            this.SubFieldsRadioButton.TabIndex = 29;
            this.SubFieldsRadioButton.Text = "Sub Fields";
            this.SubFieldsRadioButton.UseVisualStyleBackColor = true;
            this.SubFieldsRadioButton.CheckedChanged += new System.EventHandler(this.chkChanged);
            // 
            // MainFieldTextBox
            // 
            this.MainFieldTextBox.Location = new System.Drawing.Point(164, 115);
            this.MainFieldTextBox.Name = "MainFieldTextBox";
            this.MainFieldTextBox.Size = new System.Drawing.Size(147, 20);
            this.MainFieldTextBox.TabIndex = 30;
            // 
            // SetMainFieldBtn
            // 
            this.SetMainFieldBtn.Location = new System.Drawing.Point(327, 118);
            this.SetMainFieldBtn.Name = "SetMainFieldBtn";
            this.SetMainFieldBtn.Size = new System.Drawing.Size(85, 43);
            this.SetMainFieldBtn.TabIndex = 31;
            this.SetMainFieldBtn.Text = "Set";
            this.SetMainFieldBtn.UseVisualStyleBackColor = true;
            this.SetMainFieldBtn.Click += new System.EventHandler(this.SetMainFieldBtn_Click);
            // 
            // SetSubFieldBtn
            // 
            this.SetSubFieldBtn.Location = new System.Drawing.Point(751, 118);
            this.SetSubFieldBtn.Name = "SetSubFieldBtn";
            this.SetSubFieldBtn.Size = new System.Drawing.Size(85, 43);
            this.SetSubFieldBtn.TabIndex = 36;
            this.SetSubFieldBtn.Text = "Set";
            this.SetSubFieldBtn.UseVisualStyleBackColor = true;
            this.SetSubFieldBtn.Click += new System.EventHandler(this.SetSubFieldBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Main Field Name :";
            // 
            // SubValueTextBox
            // 
            this.SubValueTextBox.Location = new System.Drawing.Point(558, 141);
            this.SubValueTextBox.Name = "SubValueTextBox";
            this.SubValueTextBox.Size = new System.Drawing.Size(174, 20);
            this.SubValueTextBox.TabIndex = 38;
            this.SubValueTextBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Sub Value To Set : ";
            this.label3.Visible = false;
            // 
            // MainIDComboBox
            // 
            this.MainIDComboBox.DataSource = this.fieldsInHighTechBindingSource;
            this.MainIDComboBox.DisplayMember = "FieldName";
            this.MainIDComboBox.Enabled = false;
            this.MainIDComboBox.FormattingEnabled = true;
            this.MainIDComboBox.Location = new System.Drawing.Point(558, 110);
            this.MainIDComboBox.Name = "MainIDComboBox";
            this.MainIDComboBox.Size = new System.Drawing.Size(174, 21);
            this.MainIDComboBox.TabIndex = 39;
            this.MainIDComboBox.ValueMember = "Field_Id";
            // 
            // fieldsInHighTechBindingSource
            // 
            this.fieldsInHighTechBindingSource.DataMember = "FieldsInHighTech";
            this.fieldsInHighTechBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldsInHighTechTableAdapter
            // 
            this.fieldsInHighTechTableAdapter.ClearBeforeFill = true;
            // 
            // SetMainOrSubFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DotNetFinalProject.Properties.Resources.light_blue_abstract_best;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 569);
            this.Controls.Add(this.MainIDComboBox);
            this.Controls.Add(this.SubValueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SetSubFieldBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SetMainFieldBtn);
            this.Controls.Add(this.MainFieldTextBox);
            this.Controls.Add(this.SubFieldsRadioButton);
            this.Controls.Add(this.MainFieldsRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomePictureBox1);
            this.Controls.Add(this.ExitButton_PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetMainOrSubFields";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetMainOrSubFields";
            this.Load += new System.EventHandler(this.SetMainOrSubFields_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsInHighTechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HomePictureBox1;
        private System.Windows.Forms.PictureBox ExitButton_PictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton MainFieldsRadioButton;
        private System.Windows.Forms.RadioButton SubFieldsRadioButton;
        private System.Windows.Forms.TextBox MainFieldTextBox;
        private System.Windows.Forms.Button SetMainFieldBtn;
        private System.Windows.Forms.Button SetSubFieldBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MainIDComboBox;
        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource fieldsInHighTechBindingSource;
        private MyDatabaseDataSetTableAdapters.FieldsInHighTechTableAdapter fieldsInHighTechTableAdapter;
    }
}