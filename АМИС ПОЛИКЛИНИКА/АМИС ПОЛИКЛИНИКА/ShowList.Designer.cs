namespace АМИС_ПОЛИКЛИНИКА
{
    partial class ShowList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPatientDoctorBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet = new АМИС_ПОЛИКЛИНИКА.ClinicDataSet();
            this.fKPatientDoctorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fKPatientDoctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKPatientDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new АМИС_ПОЛИКЛИНИКА.ClinicDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new АМИС_ПОЛИКЛИНИКА.ClinicDataSetTableAdapters.TableAdapterManager();
            this.doctorTableAdapter = new АМИС_ПОЛИКЛИНИКА.ClinicDataSetTableAdapters.DoctorTableAdapter();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPatientDoctorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cardTableAdapter = new АМИС_ПОЛИКЛИНИКА.ClinicDataSetTableAdapters.CardTableAdapter();
            this.fKPatientCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPatientCardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKPatientCardBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKPatientCardBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientDoctorBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientDoctorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientDoctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientDoctorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientCardBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientCardBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientCardBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dbDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.drDataGridViewTextBoxColumn,
            this.cardidDataGridViewTextBoxColumn,
            this.docidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKPatientDoctorBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(27, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(533, 248);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Ф.И.О.";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.FillWeight = 40F;
            this.genderDataGridViewTextBoxColumn.HeaderText = "пол";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 4;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 40;
            // 
            // dbDataGridViewTextBoxColumn
            // 
            this.dbDataGridViewTextBoxColumn.DataPropertyName = "db";
            this.dbDataGridViewTextBoxColumn.HeaderText = "Дата Рождения";
            this.dbDataGridViewTextBoxColumn.Name = "dbDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // drDataGridViewTextBoxColumn
            // 
            this.drDataGridViewTextBoxColumn.DataPropertyName = "dr";
            this.drDataGridViewTextBoxColumn.HeaderText = "Дата Регистрации";
            this.drDataGridViewTextBoxColumn.Name = "drDataGridViewTextBoxColumn";
            // 
            // cardidDataGridViewTextBoxColumn
            // 
            this.cardidDataGridViewTextBoxColumn.DataPropertyName = "cardid";
            this.cardidDataGridViewTextBoxColumn.HeaderText = "№ карты";
            this.cardidDataGridViewTextBoxColumn.Name = "cardidDataGridViewTextBoxColumn";
            // 
            // docidDataGridViewTextBoxColumn
            // 
            this.docidDataGridViewTextBoxColumn.DataPropertyName = "docid";
            this.docidDataGridViewTextBoxColumn.HeaderText = "docid";
            this.docidDataGridViewTextBoxColumn.Name = "docidDataGridViewTextBoxColumn";
            this.docidDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKPatientDoctorBindingSource4
            // 
            this.fKPatientDoctorBindingSource4.DataMember = "FK_Patient_Doctor";
            this.fKPatientDoctorBindingSource4.DataSource = this.doctorBindingSource;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.clinicDataSet;
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "ClinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKPatientDoctorBindingSource3
            // 
            this.fKPatientDoctorBindingSource3.DataMember = "FK_Patient_Doctor";
            this.fKPatientDoctorBindingSource3.DataSource = this.doctorBindingSource;
            // 
            // fKPatientDoctorBindingSource1
            // 
            this.fKPatientDoctorBindingSource1.DataMember = "FK_Patient_Doctor";
            this.fKPatientDoctorBindingSource1.DataSource = this.doctorBindingSource;
            // 
            // fKPatientDoctorBindingSource
            // 
            this.fKPatientDoctorBindingSource.DataMember = "FK_Patient_Doctor";
            this.fKPatientDoctorBindingSource.DataSource = this.doctorBindingSource;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.clinicDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddrListTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.CardTableAdapter = null;
            this.tableAdapterManager.DoctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.UpdateOrder = АМИС_ПОЛИКЛИНИКА.ClinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "Doctor";
            this.doctorBindingSource1.DataSource = this.clinicDataSet;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DataSource = this.doctorBindingSource;
            this.doctorComboBox.DisplayMember = "fio";
            this.doctorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(27, 63);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(300, 33);
            this.doctorComboBox.TabIndex = 35;
            this.doctorComboBox.ValueMember = "id";
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Найдите себя в списке:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Записанные к вам на прием пациенты:";
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataMember = "Card";
            this.cardBindingSource.DataSource = this.clinicDataSet;
            // 
            // fKPatientDoctorBindingSource2
            // 
            this.fKPatientDoctorBindingSource2.DataMember = "FK_Patient_Doctor";
            this.fKPatientDoctorBindingSource2.DataSource = this.doctorBindingSource;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.clinicDataSet;
            // 
            // cardTableAdapter
            // 
            this.cardTableAdapter.ClearBeforeFill = true;
            // 
            // fKPatientCardBindingSource
            // 
            this.fKPatientCardBindingSource.DataMember = "FK_Patient_Card";
            this.fKPatientCardBindingSource.DataSource = this.cardBindingSource;
            // 
            // fKPatientCardBindingSource1
            // 
            this.fKPatientCardBindingSource1.DataMember = "FK_Patient_Card";
            this.fKPatientCardBindingSource1.DataSource = this.cardBindingSource;
            // 
            // fKPatientCardBindingSource2
            // 
            this.fKPatientCardBindingSource2.DataMember = "FK_Patient_Card";
            this.fKPatientCardBindingSource2.DataSource = this.cardBindingSource;
            // 
            // fKPatientCardBindingSource3
            // 
            this.fKPatientCardBindingSource3.DataMember = "FK_Patient_Card";
            this.fKPatientCardBindingSource3.DataSource = this.cardBindingSource;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.SeaGreen;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.Window;
            this.exit.Location = new System.Drawing.Point(436, 430);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(124, 38);
            this.exit.TabIndex = 38;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ShowList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 489);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список записанных пациентов";
            this.Load += new System.EventHandler(this.ShowList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientDoctorBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientDoctorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientDoctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientDoctorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientCardBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientCardBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientCardBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ClinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private ClinicDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private ClinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ClinicDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource fKPatientDoctorBindingSource;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKPatientDoctorBindingSource1;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.BindingSource fKPatientDoctorBindingSource2;
        private System.Windows.Forms.BindingSource cardBindingSource;
        private ClinicDataSetTableAdapters.CardTableAdapter cardTableAdapter;
        private System.Windows.Forms.BindingSource fKPatientCardBindingSource;
        private System.Windows.Forms.BindingSource fKPatientCardBindingSource2;
        private System.Windows.Forms.BindingSource fKPatientCardBindingSource1;
        private System.Windows.Forms.BindingSource fKPatientCardBindingSource3;
        private System.Windows.Forms.BindingSource fKPatientDoctorBindingSource3;
        private System.Windows.Forms.BindingSource fKPatientDoctorBindingSource4;
        private System.Windows.Forms.Button exit;
    }
}