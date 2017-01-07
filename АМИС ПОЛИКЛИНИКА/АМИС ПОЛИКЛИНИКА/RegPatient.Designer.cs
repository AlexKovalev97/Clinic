namespace АМИС_ПОЛИКЛИНИКА
{
    partial class RegPatient
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegPatient));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clinicDataSet = new АМИС_ПОЛИКЛИНИКА.ClinicDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new АМИС_ПОЛИКЛИНИКА.ClinicDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new АМИС_ПОЛИКЛИНИКА.ClinicDataSetTableAdapters.TableAdapterManager();
            this.addrListTableAdapter = new АМИС_ПОЛИКЛИНИКА.ClinicDataSetTableAdapters.AddrListTableAdapter();
            this.patientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.dbDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.drDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addrListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addrListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addrListListBox = new System.Windows.Forms.ListBox();
            this.fKPatientAddrListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.docidTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cardidTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.exit = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).BeginInit();
            this.patientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addrListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addrListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addrListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientAddrListBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label7.ForeColor = System.Drawing.Color.SeaGreen;
            label7.Location = new System.Drawing.Point(12, 66);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(73, 20);
            label7.TabIndex = 3;
            label7.Text = "Ф.И.О.:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            genderLabel.ForeColor = System.Drawing.Color.SeaGreen;
            genderLabel.Location = new System.Drawing.Point(12, 36);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(51, 20);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "Пол:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.ForeColor = System.Drawing.Color.SeaGreen;
            label6.Location = new System.Drawing.Point(12, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(30, 20);
            label6.TabIndex = 1;
            label6.Text = "id:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.ForeColor = System.Drawing.Color.SeaGreen;
            label5.Location = new System.Drawing.Point(12, 124);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(73, 20);
            label5.TabIndex = 9;
            label5.Text = "Адрес:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.ForeColor = System.Drawing.Color.SeaGreen;
            label4.Location = new System.Drawing.Point(25, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(186, 20);
            label4.TabIndex = 11;
            label4.Text = "Дата регистрации:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.Color.SeaGreen;
            label3.Location = new System.Drawing.Point(12, 97);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(160, 20);
            label3.TabIndex = 7;
            label3.Text = "Дата рождения:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.ForeColor = System.Drawing.Color.SeaGreen;
            label8.Location = new System.Drawing.Point(4, 177);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(413, 25);
            label8.TabIndex = 51;
            label8.Text = "Пациенты, закрепленные за участком:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.ForeColor = System.Drawing.Color.SeaGreen;
            label9.Location = new System.Drawing.Point(25, 213);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(212, 20);
            label9.TabIndex = 49;
            label9.Text = "id участкового врача:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label10.ForeColor = System.Drawing.Color.SeaGreen;
            label10.Location = new System.Drawing.Point(25, 238);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(94, 20);
            label10.TabIndex = 51;
            label10.Text = "№ карты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(17, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Участок:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Личные данные:";
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "ClinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.AddrListTableAdapter = this.addrListTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.CardTableAdapter = null;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.UpdateOrder = АМИС_ПОЛИКЛИНИКА.ClinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addrListTableAdapter
            // 
            this.addrListTableAdapter.ClearBeforeFill = true;
            // 
            // patientBindingNavigator
            // 
            this.patientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientBindingNavigator.BindingSource = this.patientBindingSource;
            this.patientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.patientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.patientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patientBindingNavigatorSaveItem});
            this.patientBindingNavigator.Location = new System.Drawing.Point(29, 262);
            this.patientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientBindingNavigator.Name = "patientBindingNavigator";
            this.patientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientBindingNavigator.Size = new System.Drawing.Size(305, 27);
            this.patientBindingNavigator.TabIndex = 35;
            this.patientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // patientBindingNavigatorSaveItem
            // 
            this.patientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientBindingNavigatorSaveItem.Image")));
            this.patientBindingNavigatorSaveItem.Name = "patientBindingNavigatorSaveItem";
            this.patientBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.patientBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.patientBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(48, 9);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(46, 22);
            this.idTextBox.TabIndex = 36;
            // 
            // fioTextBox
            // 
            this.fioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "fio", true));
            this.fioTextBox.Location = new System.Drawing.Point(91, 66);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(200, 22);
            this.fioTextBox.TabIndex = 38;
            // 
            // dbDateTimePicker
            // 
            this.dbDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "db", true));
            this.dbDateTimePicker.Location = new System.Drawing.Point(178, 94);
            this.dbDateTimePicker.Name = "dbDateTimePicker";
            this.dbDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dbDateTimePicker.TabIndex = 42;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(91, 124);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 22);
            this.addressTextBox.TabIndex = 44;
            // 
            // drDateTimePicker
            // 
            this.drDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "dr", true));
            this.drDateTimePicker.Location = new System.Drawing.Point(206, 190);
            this.drDateTimePicker.Name = "drDateTimePicker";
            this.drDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.drDateTimePicker.TabIndex = 46;
            // 
            // addrListBindingSource
            // 
            this.addrListBindingSource.DataMember = "AddrList";
            this.addrListBindingSource.DataSource = this.clinicDataSet;
            // 
            // addrListDataGridView
            // 
            this.addrListDataGridView.AutoGenerateColumns = false;
            this.addrListDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.addrListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addrListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.addrListDataGridView.DataSource = this.addrListBindingSource;
            this.addrListDataGridView.Location = new System.Drawing.Point(28, 3);
            this.addrListDataGridView.Name = "addrListDataGridView";
            this.addrListDataGridView.RowTemplate.Height = 24;
            this.addrListDataGridView.Size = new System.Drawing.Size(294, 171);
            this.addrListDataGridView.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "docid";
            this.dataGridViewTextBoxColumn3.HeaderText = "id участкового врача";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // addrListBindingSource1
            // 
            this.addrListBindingSource1.DataMember = "AddrList";
            this.addrListBindingSource1.DataSource = this.clinicDataSet;
            // 
            // addrListListBox
            // 
            this.addrListListBox.DataSource = this.fKPatientAddrListBindingSource;
            this.addrListListBox.DisplayMember = "fio";
            this.addrListListBox.FormattingEnabled = true;
            this.addrListListBox.ItemHeight = 16;
            this.addrListListBox.Location = new System.Drawing.Point(26, 205);
            this.addrListListBox.Name = "addrListListBox";
            this.addrListListBox.Size = new System.Drawing.Size(295, 100);
            this.addrListListBox.TabIndex = 46;
            this.addrListListBox.ValueMember = "address";
            // 
            // fKPatientAddrListBindingSource
            // 
            this.fKPatientAddrListBindingSource.DataMember = "FK_Patient_AddrList";
            this.fKPatientAddrListBindingSource.DataSource = this.addrListBindingSource;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(69, 37);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(48, 22);
            this.genderTextBox.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.genderTextBox);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(genderLabel);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.dbDateTimePicker);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.fioTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 153);
            this.panel1.TabIndex = 50;
            // 
            // docidTextBox
            // 
            this.docidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "docid", true));
            this.docidTextBox.Location = new System.Drawing.Point(232, 213);
            this.docidTextBox.Name = "docidTextBox";
            this.docidTextBox.Size = new System.Drawing.Size(61, 22);
            this.docidTextBox.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addrListDataGridView);
            this.panel2.Controls.Add(this.addrListListBox);
            this.panel2.Controls.Add(label8);
            this.panel2.Location = new System.Drawing.Point(12, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 317);
            this.panel2.TabIndex = 52;
            // 
            // cardidTextBox
            // 
            this.cardidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "cardid", true));
            this.cardidTextBox.Location = new System.Drawing.Point(124, 238);
            this.cardidTextBox.Name = "cardidTextBox";
            this.cardidTextBox.Size = new System.Drawing.Size(61, 22);
            this.cardidTextBox.TabIndex = 50;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.SeaGreen;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.Window;
            this.exit.Location = new System.Drawing.Point(367, 679);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(99, 38);
            this.exit.TabIndex = 53;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // RegPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 728);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.docidTextBox);
            this.Controls.Add(label4);
            this.Controls.Add(label9);
            this.Controls.Add(this.cardidTextBox);
            this.Controls.Add(label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drDateTimePicker);
            this.Controls.Add(this.patientBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация пациента";
            this.Load += new System.EventHandler(this.RegPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).EndInit();
            this.patientBindingNavigator.ResumeLayout(false);
            this.patientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addrListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addrListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addrListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientAddrListBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ClinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private ClinicDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private ClinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton patientBindingNavigatorSaveItem;
        private ClinicDataSetTableAdapters.AddrListTableAdapter addrListTableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.DateTimePicker dbDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker drDateTimePicker;
        private System.Windows.Forms.BindingSource addrListBindingSource;
        private System.Windows.Forms.DataGridView addrListDataGridView;
        private System.Windows.Forms.BindingSource addrListBindingSource1;
        private System.Windows.Forms.ListBox addrListListBox;
        private System.Windows.Forms.BindingSource fKPatientAddrListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox docidTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox cardidTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button exit;
    }
}