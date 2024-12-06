namespace ManagementSystem_Q1
{
    partial class Form1
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.patientNo = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.phoneNo = new System.Windows.Forms.TextBox();
            this.illness = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.TextBox();
            this.comboProvince = new System.Windows.Forms.ComboBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.comboPatientType = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.displayBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.illnessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalManagementSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eHealth_Care_Hospital_Management_SystemDataSet = new ManagementSystem_Q1.eHealth_Care_Hospital_Management_SystemDataSet();
            this.hospitalManagementSystemTableAdapter = new ManagementSystem_Q1.eHealth_Care_Hospital_Management_SystemDataSetTableAdapters.HospitalManagementSystemTableAdapter();
            this.tableAdapterManager = new ManagementSystem_Q1.eHealth_Care_Hospital_Management_SystemDataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHealth_Care_Hospital_Management_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Silver;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(1018, 24);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.Text = "eHealth Care Incorporated";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nature of Illness";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Search By Patient No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Patient Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Province";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(571, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date Of Birth";
            // 
            // patientNo
            // 
            this.patientNo.Location = new System.Drawing.Point(194, 34);
            this.patientNo.Name = "patientNo";
            this.patientNo.Size = new System.Drawing.Size(210, 22);
            this.patientNo.TabIndex = 10;
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(194, 77);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(210, 22);
            this.fullName.TabIndex = 11;
            // 
            // phoneNo
            // 
            this.phoneNo.Location = new System.Drawing.Point(194, 124);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(210, 22);
            this.phoneNo.TabIndex = 12;
            // 
            // illness
            // 
            this.illness.Location = new System.Drawing.Point(194, 172);
            this.illness.Name = "illness";
            this.illness.Size = new System.Drawing.Size(210, 22);
            this.illness.TabIndex = 13;
            // 
            // birthDate
            // 
            this.birthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalManagementSystemBindingSource, "DOB", true));
            this.birthDate.Location = new System.Drawing.Point(755, 175);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(210, 22);
            this.birthDate.TabIndex = 15;
            // 
            // comboProvince
            // 
            this.comboProvince.FormattingEnabled = true;
            this.comboProvince.Items.AddRange(new object[] {
            "Eastern Cape",
            "Free State",
            "Gauteng",
            "Kwa zuluNatal",
            "Limpopo",
            "Mpumalanga",
            "Northern Cape",
            "North West",
            "Western Cape"});
            this.comboProvince.Location = new System.Drawing.Point(755, 130);
            this.comboProvince.Name = "comboProvince";
            this.comboProvince.Size = new System.Drawing.Size(210, 24);
            this.comboProvince.TabIndex = 16;
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboGender.Location = new System.Drawing.Point(755, 83);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(210, 24);
            this.comboGender.TabIndex = 17;
            // 
            // comboPatientType
            // 
            this.comboPatientType.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboPatientType.FormattingEnabled = true;
            this.comboPatientType.Items.AddRange(new object[] {
            "Emrgency",
            "In_Patient",
            "Out_Patient"});
            this.comboPatientType.Location = new System.Drawing.Point(755, 37);
            this.comboPatientType.Name = "comboPatientType";
            this.comboPatientType.Size = new System.Drawing.Size(210, 24);
            this.comboPatientType.TabIndex = 18;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Location = new System.Drawing.Point(502, 224);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 29);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Phone  Number";
            // 
            // displayBtn
            // 
            this.displayBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.displayBtn.Location = new System.Drawing.Point(631, 224);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(93, 29);
            this.displayBtn.TabIndex = 21;
            this.displayBtn.Text = "Display All";
            this.displayBtn.UseVisualStyleBackColor = false;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchBtn.Location = new System.Drawing.Point(755, 224);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 29);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteBtn.Location = new System.Drawing.Point(890, 224);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 29);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientNoDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.patientTypeDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.illnessDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hospitalManagementSystemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 547);
            this.dataGridView1.TabIndex = 24;
            // 
            // patientNoDataGridViewTextBoxColumn
            // 
            this.patientNoDataGridViewTextBoxColumn.DataPropertyName = "PatientNo";
            this.patientNoDataGridViewTextBoxColumn.HeaderText = "PatientNo";
            this.patientNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNoDataGridViewTextBoxColumn.Name = "patientNoDataGridViewTextBoxColumn";
            this.patientNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientTypeDataGridViewTextBoxColumn
            // 
            this.patientTypeDataGridViewTextBoxColumn.DataPropertyName = "PatientType";
            this.patientTypeDataGridViewTextBoxColumn.HeaderText = "PatientType";
            this.patientTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientTypeDataGridViewTextBoxColumn.Name = "patientTypeDataGridViewTextBoxColumn";
            this.patientTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // illnessDataGridViewTextBoxColumn
            // 
            this.illnessDataGridViewTextBoxColumn.DataPropertyName = "Illness";
            this.illnessDataGridViewTextBoxColumn.HeaderText = "Illness";
            this.illnessDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.illnessDataGridViewTextBoxColumn.Name = "illnessDataGridViewTextBoxColumn";
            this.illnessDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // hospitalManagementSystemBindingSource
            // 
            this.hospitalManagementSystemBindingSource.DataMember = "HospitalManagementSystem";
            this.hospitalManagementSystemBindingSource.DataSource = this.eHealth_Care_Hospital_Management_SystemDataSet;
            // 
            // eHealth_Care_Hospital_Management_SystemDataSet
            // 
            this.eHealth_Care_Hospital_Management_SystemDataSet.DataSetName = "eHealth_Care_Hospital_Management_SystemDataSet";
            this.eHealth_Care_Hospital_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalManagementSystemTableAdapter
            // 
            this.hospitalManagementSystemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HospitalManagementSystemTableAdapter = this.hospitalManagementSystemTableAdapter;
            this.tableAdapterManager.UpdateOrder = ManagementSystem_Q1.eHealth_Care_Hospital_Management_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1010, 804);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.comboPatientType);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.comboProvince);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.illness);
            this.Controls.Add(this.phoneNo);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.patientNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "eHealth Care Hospital Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHealth_Care_Hospital_Management_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox patientNo;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox phoneNo;
        private System.Windows.Forms.TextBox illness;
        private System.Windows.Forms.TextBox birthDate;
        private System.Windows.Forms.ComboBox comboProvince;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.ComboBox comboPatientType;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private eHealth_Care_Hospital_Management_SystemDataSet eHealth_Care_Hospital_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource hospitalManagementSystemBindingSource;
        private eHealth_Care_Hospital_Management_SystemDataSetTableAdapters.HospitalManagementSystemTableAdapter hospitalManagementSystemTableAdapter;
        private eHealth_Care_Hospital_Management_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn illnessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

