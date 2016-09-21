namespace DotNetFinalProject
{
    partial class UpdateForm
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SubRadioButton = new System.Windows.Forms.RadioButton();
            this.MainRadioButton = new System.Windows.Forms.RadioButton();
            this.UpdateValueTextBox = new System.Windows.Forms.TextBox();
            this.HomePictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton_PictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainFieldsComboBox = new System.Windows.Forms.ComboBox();
            this.SubFieldsComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(512, 88);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Visible = false;
            // 
            // SubRadioButton
            // 
            this.SubRadioButton.AutoSize = true;
            this.SubRadioButton.Location = new System.Drawing.Point(201, 56);
            this.SubRadioButton.Name = "SubRadioButton";
            this.SubRadioButton.Size = new System.Drawing.Size(69, 17);
            this.SubRadioButton.TabIndex = 16;
            this.SubRadioButton.Text = "Sub Field";
            this.SubRadioButton.UseVisualStyleBackColor = true;
            this.SubRadioButton.CheckedChanged += new System.EventHandler(this.CheckedRadioButton);
            // 
            // MainRadioButton
            // 
            this.MainRadioButton.AutoSize = true;
            this.MainRadioButton.Location = new System.Drawing.Point(57, 56);
            this.MainRadioButton.Name = "MainRadioButton";
            this.MainRadioButton.Size = new System.Drawing.Size(73, 17);
            this.MainRadioButton.TabIndex = 15;
            this.MainRadioButton.Text = "Main Field";
            this.MainRadioButton.UseVisualStyleBackColor = true;
            this.MainRadioButton.CheckedChanged += new System.EventHandler(this.CheckedRadioButton);
            // 
            // UpdateValueTextBox
            // 
            this.UpdateValueTextBox.Location = new System.Drawing.Point(338, 91);
            this.UpdateValueTextBox.Name = "UpdateValueTextBox";
            this.UpdateValueTextBox.Size = new System.Drawing.Size(149, 20);
            this.UpdateValueTextBox.TabIndex = 14;
            this.UpdateValueTextBox.Visible = false;
            // 
            // HomePictureBox1
            // 
            this.HomePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.HomePictureBox1.Image = global::DotNetFinalProject.Properties.Resources.home_32;
            this.HomePictureBox1.Location = new System.Drawing.Point(753, 9);
            this.HomePictureBox1.Name = "HomePictureBox1";
            this.HomePictureBox1.Size = new System.Drawing.Size(32, 32);
            this.HomePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HomePictureBox1.TabIndex = 12;
            this.HomePictureBox1.TabStop = false;
            this.HomePictureBox1.Click += new System.EventHandler(this.HomePictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lupa Planta", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(48, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Update Fields / Sub Fields Section";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExitButton_PictureBox2
            // 
            this.ExitButton_PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton_PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton_PictureBox2.Image = global::DotNetFinalProject.Properties.Resources.cancel_32;
            this.ExitButton_PictureBox2.Location = new System.Drawing.Point(806, 9);
            this.ExitButton_PictureBox2.Name = "ExitButton_PictureBox2";
            this.ExitButton_PictureBox2.Size = new System.Drawing.Size(32, 32);
            this.ExitButton_PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitButton_PictureBox2.TabIndex = 11;
            this.ExitButton_PictureBox2.TabStop = false;
            this.ExitButton_PictureBox2.Click += new System.EventHandler(this.ExitButton_PictureBox2_Click);
            // 
            // MainFieldsComboBox
            // 
            this.MainFieldsComboBox.FormattingEnabled = true;
            this.MainFieldsComboBox.Location = new System.Drawing.Point(36, 91);
            this.MainFieldsComboBox.Name = "MainFieldsComboBox";
            this.MainFieldsComboBox.Size = new System.Drawing.Size(121, 21);
            this.MainFieldsComboBox.TabIndex = 19;
            this.MainFieldsComboBox.Visible = false;
            // 
            // SubFieldsComboBox
            // 
            this.SubFieldsComboBox.FormattingEnabled = true;
            this.SubFieldsComboBox.Location = new System.Drawing.Point(181, 91);
            this.SubFieldsComboBox.Name = "SubFieldsComboBox";
            this.SubFieldsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SubFieldsComboBox.TabIndex = 20;
            this.SubFieldsComboBox.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 330);
            this.dataGridView1.TabIndex = 18;
            // 
            // UpdateValueLabel
            // 
            this.UpdateValueLabel.AutoSize = true;
            this.UpdateValueLabel.Location = new System.Drawing.Point(382, 74);
            this.UpdateValueLabel.Name = "UpdateValueLabel";
            this.UpdateValueLabel.Size = new System.Drawing.Size(72, 13);
            this.UpdateValueLabel.TabIndex = 23;
            this.UpdateValueLabel.Text = "Update Value";
            this.UpdateValueLabel.Visible = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DotNetFinalProject.Properties.Resources.light_blue_abstract_best;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.UpdateValueLabel);
            this.Controls.Add(this.SubFieldsComboBox);
            this.Controls.Add(this.MainFieldsComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SubRadioButton);
            this.Controls.Add(this.MainRadioButton);
            this.Controls.Add(this.UpdateValueTextBox);
            this.Controls.Add(this.HomePictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton_PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.RadioButton SubRadioButton;
        private System.Windows.Forms.RadioButton MainRadioButton;
        private System.Windows.Forms.TextBox UpdateValueTextBox;
        private System.Windows.Forms.PictureBox HomePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ExitButton_PictureBox2;
        private System.Windows.Forms.ComboBox MainFieldsComboBox;
        private System.Windows.Forms.ComboBox SubFieldsComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label UpdateValueLabel;
    }
}