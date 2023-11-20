namespace WindowsFormsApp2
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label referenceNumberLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label softwarenameLabel;
            System.Windows.Forms.Label companyWebsiteLabel;
            System.Windows.Forms.Label softwareTypeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label companyEstablishedLabel;
            System.Windows.Forms.Label locationCountriesLabel;
            System.Windows.Forms.Label locationCitiesLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label employeeCountLabel;
            System.Windows.Forms.Label internalProfessionalServicesLabel;
            System.Windows.Forms.Label lastDemoDateLabel;
            System.Windows.Forms.Label lastReviewedDateLabel;
            System.Windows.Forms.Label businessAreasLabel;
            System.Windows.Forms.Label modulesLabel;
            System.Windows.Forms.Label clientTypesLabel;
            System.Windows.Forms.Label cloudTypeLabel;
            System.Windows.Forms.Label additionalInformationLabel;
            System.Windows.Forms.Label documentAttachedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database1DataSet = new WindowsFormsApp2.Database1DataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApp2.Database1DataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.Database1DataSetTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.referenceNumberTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.softwarenameTextBox = new System.Windows.Forms.TextBox();
            this.companyWebsiteTextBox = new System.Windows.Forms.TextBox();
            this.softwareTypeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.companyEstablishedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationCountriesTextBox = new System.Windows.Forms.TextBox();
            this.locationCitiesTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.employeeCountTextBox = new System.Windows.Forms.TextBox();
            this.internalProfessionalServicesCheckBox = new System.Windows.Forms.CheckBox();
            this.lastDemoDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastReviewedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.businessAreasTextBox = new System.Windows.Forms.TextBox();
            this.modulesTextBox = new System.Windows.Forms.TextBox();
            this.clientTypesTextBox = new System.Windows.Forms.TextBox();
            this.cloudTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.additionalInformationTextBox = new System.Windows.Forms.TextBox();
            this.documentAttachedCheckBox = new System.Windows.Forms.CheckBox();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            referenceNumberLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            softwarenameLabel = new System.Windows.Forms.Label();
            companyWebsiteLabel = new System.Windows.Forms.Label();
            softwareTypeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            companyEstablishedLabel = new System.Windows.Forms.Label();
            locationCountriesLabel = new System.Windows.Forms.Label();
            locationCitiesLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            employeeCountLabel = new System.Windows.Forms.Label();
            internalProfessionalServicesLabel = new System.Windows.Forms.Label();
            lastDemoDateLabel = new System.Windows.Forms.Label();
            lastReviewedDateLabel = new System.Windows.Forms.Label();
            businessAreasLabel = new System.Windows.Forms.Label();
            modulesLabel = new System.Windows.Forms.Label();
            clientTypesLabel = new System.Windows.Forms.Label();
            cloudTypeLabel = new System.Windows.Forms.Label();
            additionalInformationLabel = new System.Windows.Forms.Label();
            documentAttachedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 25);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // referenceNumberLabel
            // 
            referenceNumberLabel.AutoSize = true;
            referenceNumberLabel.Location = new System.Drawing.Point(12, 51);
            referenceNumberLabel.Name = "referenceNumberLabel";
            referenceNumberLabel.Size = new System.Drawing.Size(95, 13);
            referenceNumberLabel.TabIndex = 3;
            referenceNumberLabel.Text = "reference Number:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(12, 77);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(84, 13);
            companyNameLabel.TabIndex = 5;
            companyNameLabel.Text = "company Name:";
            // 
            // softwarenameLabel
            // 
            softwarenameLabel.AutoSize = true;
            softwarenameLabel.Location = new System.Drawing.Point(12, 103);
            softwarenameLabel.Name = "softwarenameLabel";
            softwarenameLabel.Size = new System.Drawing.Size(76, 13);
            softwarenameLabel.TabIndex = 7;
            softwarenameLabel.Text = "softwarename:";
            // 
            // companyWebsiteLabel
            // 
            companyWebsiteLabel.AutoSize = true;
            companyWebsiteLabel.Location = new System.Drawing.Point(12, 129);
            companyWebsiteLabel.Name = "companyWebsiteLabel";
            companyWebsiteLabel.Size = new System.Drawing.Size(95, 13);
            companyWebsiteLabel.TabIndex = 9;
            companyWebsiteLabel.Text = "company Website:";
            // 
            // softwareTypeLabel
            // 
            softwareTypeLabel.AutoSize = true;
            softwareTypeLabel.Location = new System.Drawing.Point(12, 155);
            softwareTypeLabel.Name = "softwareTypeLabel";
            softwareTypeLabel.Size = new System.Drawing.Size(77, 13);
            softwareTypeLabel.TabIndex = 11;
            softwareTypeLabel.Text = "software Type:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 181);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "description:";
            // 
            // companyEstablishedLabel
            // 
            companyEstablishedLabel.AutoSize = true;
            companyEstablishedLabel.Location = new System.Drawing.Point(12, 208);
            companyEstablishedLabel.Name = "companyEstablishedLabel";
            companyEstablishedLabel.Size = new System.Drawing.Size(110, 13);
            companyEstablishedLabel.TabIndex = 15;
            companyEstablishedLabel.Text = "company Established:";
            // 
            // locationCountriesLabel
            // 
            locationCountriesLabel.AutoSize = true;
            locationCountriesLabel.Location = new System.Drawing.Point(12, 233);
            locationCountriesLabel.Name = "locationCountriesLabel";
            locationCountriesLabel.Size = new System.Drawing.Size(94, 13);
            locationCountriesLabel.TabIndex = 17;
            locationCountriesLabel.Text = "location Countries:";
            // 
            // locationCitiesLabel
            // 
            locationCitiesLabel.AutoSize = true;
            locationCitiesLabel.Location = new System.Drawing.Point(12, 259);
            locationCitiesLabel.Name = "locationCitiesLabel";
            locationCitiesLabel.Size = new System.Drawing.Size(75, 13);
            locationCitiesLabel.TabIndex = 19;
            locationCitiesLabel.Text = "location Cities:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(12, 285);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(80, 13);
            phoneNumberLabel.TabIndex = 21;
            phoneNumberLabel.Text = "phone Number:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 311);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 23;
            addressLabel.Text = "address:";
            // 
            // employeeCountLabel
            // 
            employeeCountLabel.AutoSize = true;
            employeeCountLabel.Location = new System.Drawing.Point(12, 337);
            employeeCountLabel.Name = "employeeCountLabel";
            employeeCountLabel.Size = new System.Drawing.Size(86, 13);
            employeeCountLabel.TabIndex = 25;
            employeeCountLabel.Text = "employee Count:";
            // 
            // internalProfessionalServicesLabel
            // 
            internalProfessionalServicesLabel.AutoSize = true;
            internalProfessionalServicesLabel.Location = new System.Drawing.Point(12, 365);
            internalProfessionalServicesLabel.Name = "internalProfessionalServicesLabel";
            internalProfessionalServicesLabel.Size = new System.Drawing.Size(148, 13);
            internalProfessionalServicesLabel.TabIndex = 27;
            internalProfessionalServicesLabel.Text = "internal Professional Services:";
            // 
            // lastDemoDateLabel
            // 
            lastDemoDateLabel.AutoSize = true;
            lastDemoDateLabel.Location = new System.Drawing.Point(12, 394);
            lastDemoDateLabel.Name = "lastDemoDateLabel";
            lastDemoDateLabel.Size = new System.Drawing.Size(83, 13);
            lastDemoDateLabel.TabIndex = 29;
            lastDemoDateLabel.Text = "last Demo Date:";
            // 
            // lastReviewedDateLabel
            // 
            lastReviewedDateLabel.AutoSize = true;
            lastReviewedDateLabel.Location = new System.Drawing.Point(12, 420);
            lastReviewedDateLabel.Name = "lastReviewedDateLabel";
            lastReviewedDateLabel.Size = new System.Drawing.Size(103, 13);
            lastReviewedDateLabel.TabIndex = 31;
            lastReviewedDateLabel.Text = "last Reviewed Date:";
            // 
            // businessAreasLabel
            // 
            businessAreasLabel.AutoSize = true;
            businessAreasLabel.Location = new System.Drawing.Point(12, 445);
            businessAreasLabel.Name = "businessAreasLabel";
            businessAreasLabel.Size = new System.Drawing.Size(81, 13);
            businessAreasLabel.TabIndex = 33;
            businessAreasLabel.Text = "business Areas:";
            // 
            // modulesLabel
            // 
            modulesLabel.AutoSize = true;
            modulesLabel.Location = new System.Drawing.Point(12, 471);
            modulesLabel.Name = "modulesLabel";
            modulesLabel.Size = new System.Drawing.Size(49, 13);
            modulesLabel.TabIndex = 35;
            modulesLabel.Text = "modules:";
            // 
            // clientTypesLabel
            // 
            clientTypesLabel.AutoSize = true;
            clientTypesLabel.Location = new System.Drawing.Point(12, 497);
            clientTypesLabel.Name = "clientTypesLabel";
            clientTypesLabel.Size = new System.Drawing.Size(67, 13);
            clientTypesLabel.TabIndex = 37;
            clientTypesLabel.Text = "client Types:";
            // 
            // cloudTypeLabel
            // 
            cloudTypeLabel.AutoSize = true;
            cloudTypeLabel.Location = new System.Drawing.Point(12, 525);
            cloudTypeLabel.Name = "cloudTypeLabel";
            cloudTypeLabel.Size = new System.Drawing.Size(63, 13);
            cloudTypeLabel.TabIndex = 39;
            cloudTypeLabel.Text = "cloud Type:";
            // 
            // additionalInformationLabel
            // 
            additionalInformationLabel.AutoSize = true;
            additionalInformationLabel.Location = new System.Drawing.Point(12, 553);
            additionalInformationLabel.Name = "additionalInformationLabel";
            additionalInformationLabel.Size = new System.Drawing.Size(110, 13);
            additionalInformationLabel.TabIndex = 41;
            additionalInformationLabel.Text = "additional Information:";
            // 
            // documentAttachedLabel
            // 
            documentAttachedLabel.AutoSize = true;
            documentAttachedLabel.Location = new System.Drawing.Point(12, 581);
            documentAttachedLabel.Name = "documentAttachedLabel";
            documentAttachedLabel.Size = new System.Drawing.Size(103, 13);
            documentAttachedLabel.TabIndex = 43;
            documentAttachedLabel.Text = "document Attached:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.database1DataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(2076, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(166, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // referenceNumberTextBox
            // 
            this.referenceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "referenceNumber", true));
            this.referenceNumberTextBox.Location = new System.Drawing.Point(166, 48);
            this.referenceNumberTextBox.Name = "referenceNumberTextBox";
            this.referenceNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.referenceNumberTextBox.TabIndex = 4;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "companyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(166, 74);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.companyNameTextBox.TabIndex = 6;
            // 
            // softwarenameTextBox
            // 
            this.softwarenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "softwarename", true));
            this.softwarenameTextBox.Location = new System.Drawing.Point(166, 100);
            this.softwarenameTextBox.Name = "softwarenameTextBox";
            this.softwarenameTextBox.Size = new System.Drawing.Size(200, 20);
            this.softwarenameTextBox.TabIndex = 8;
            // 
            // companyWebsiteTextBox
            // 
            this.companyWebsiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "companyWebsite", true));
            this.companyWebsiteTextBox.Location = new System.Drawing.Point(166, 126);
            this.companyWebsiteTextBox.Name = "companyWebsiteTextBox";
            this.companyWebsiteTextBox.Size = new System.Drawing.Size(200, 20);
            this.companyWebsiteTextBox.TabIndex = 10;
            // 
            // softwareTypeTextBox
            // 
            this.softwareTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "softwareType", true));
            this.softwareTypeTextBox.Location = new System.Drawing.Point(166, 152);
            this.softwareTypeTextBox.Name = "softwareTypeTextBox";
            this.softwareTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.softwareTypeTextBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(166, 178);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 14;
            // 
            // companyEstablishedDateTimePicker
            // 
            this.companyEstablishedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customersBindingSource, "companyEstablished", true));
            this.companyEstablishedDateTimePicker.Location = new System.Drawing.Point(166, 204);
            this.companyEstablishedDateTimePicker.Name = "companyEstablishedDateTimePicker";
            this.companyEstablishedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.companyEstablishedDateTimePicker.TabIndex = 16;
            // 
            // locationCountriesTextBox
            // 
            this.locationCountriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "locationCountries", true));
            this.locationCountriesTextBox.Location = new System.Drawing.Point(166, 230);
            this.locationCountriesTextBox.Multiline = true;
            this.locationCountriesTextBox.Name = "locationCountriesTextBox";
            this.locationCountriesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.locationCountriesTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationCountriesTextBox.TabIndex = 18;
            // 
            // locationCitiesTextBox
            // 
            this.locationCitiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "locationCities", true));
            this.locationCitiesTextBox.Location = new System.Drawing.Point(166, 256);
            this.locationCitiesTextBox.Name = "locationCitiesTextBox";
            this.locationCitiesTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationCitiesTextBox.TabIndex = 20;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(166, 282);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 22;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(166, 308);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 24;
            // 
            // employeeCountTextBox
            // 
            this.employeeCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "employeeCount", true));
            this.employeeCountTextBox.Location = new System.Drawing.Point(166, 334);
            this.employeeCountTextBox.Name = "employeeCountTextBox";
            this.employeeCountTextBox.Size = new System.Drawing.Size(200, 20);
            this.employeeCountTextBox.TabIndex = 26;
            // 
            // internalProfessionalServicesCheckBox
            // 
            this.internalProfessionalServicesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customersBindingSource, "internalProfessionalServices", true));
            this.internalProfessionalServicesCheckBox.Location = new System.Drawing.Point(166, 360);
            this.internalProfessionalServicesCheckBox.Name = "internalProfessionalServicesCheckBox";
            this.internalProfessionalServicesCheckBox.Size = new System.Drawing.Size(200, 24);
            this.internalProfessionalServicesCheckBox.TabIndex = 28;
            this.internalProfessionalServicesCheckBox.Text = "??";
            this.internalProfessionalServicesCheckBox.UseVisualStyleBackColor = true;
            this.internalProfessionalServicesCheckBox.CheckedChanged += new System.EventHandler(this.internalProfessionalServicesCheckBox_CheckedChanged);
            // 
            // lastDemoDateDateTimePicker
            // 
            this.lastDemoDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customersBindingSource, "lastDemoDate", true));
            this.lastDemoDateDateTimePicker.Location = new System.Drawing.Point(166, 390);
            this.lastDemoDateDateTimePicker.Name = "lastDemoDateDateTimePicker";
            this.lastDemoDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastDemoDateDateTimePicker.TabIndex = 30;
            // 
            // lastReviewedDateDateTimePicker
            // 
            this.lastReviewedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customersBindingSource, "lastReviewedDate", true));
            this.lastReviewedDateDateTimePicker.Location = new System.Drawing.Point(166, 416);
            this.lastReviewedDateDateTimePicker.Name = "lastReviewedDateDateTimePicker";
            this.lastReviewedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastReviewedDateDateTimePicker.TabIndex = 32;
            // 
            // businessAreasTextBox
            // 
            this.businessAreasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "businessAreas", true));
            this.businessAreasTextBox.Location = new System.Drawing.Point(166, 442);
            this.businessAreasTextBox.Name = "businessAreasTextBox";
            this.businessAreasTextBox.Size = new System.Drawing.Size(200, 20);
            this.businessAreasTextBox.TabIndex = 34;
            // 
            // modulesTextBox
            // 
            this.modulesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "modules", true));
            this.modulesTextBox.Location = new System.Drawing.Point(166, 468);
            this.modulesTextBox.Name = "modulesTextBox";
            this.modulesTextBox.Size = new System.Drawing.Size(200, 20);
            this.modulesTextBox.TabIndex = 36;
            // 
            // clientTypesTextBox
            // 
            this.clientTypesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "clientTypes", true));
            this.clientTypesTextBox.Location = new System.Drawing.Point(166, 494);
            this.clientTypesTextBox.Name = "clientTypesTextBox";
            this.clientTypesTextBox.Size = new System.Drawing.Size(200, 20);
            this.clientTypesTextBox.TabIndex = 38;
            // 
            // cloudTypeCheckBox
            // 
            this.cloudTypeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customersBindingSource, "cloudType", true));
            this.cloudTypeCheckBox.Location = new System.Drawing.Point(166, 520);
            this.cloudTypeCheckBox.Name = "cloudTypeCheckBox";
            this.cloudTypeCheckBox.Size = new System.Drawing.Size(200, 24);
            this.cloudTypeCheckBox.TabIndex = 40;
            this.cloudTypeCheckBox.Text = "checkBox1";
            this.cloudTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // additionalInformationTextBox
            // 
            this.additionalInformationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "additionalInformation", true));
            this.additionalInformationTextBox.Location = new System.Drawing.Point(166, 550);
            this.additionalInformationTextBox.Name = "additionalInformationTextBox";
            this.additionalInformationTextBox.Size = new System.Drawing.Size(200, 20);
            this.additionalInformationTextBox.TabIndex = 42;
            // 
            // documentAttachedCheckBox
            // 
            this.documentAttachedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customersBindingSource, "documentAttached", true));
            this.documentAttachedCheckBox.Location = new System.Drawing.Point(166, 576);
            this.documentAttachedCheckBox.Name = "documentAttachedCheckBox";
            this.documentAttachedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.documentAttachedCheckBox.TabIndex = 44;
            this.documentAttachedCheckBox.Text = "checkBox1";
            this.documentAttachedCheckBox.UseVisualStyleBackColor = true;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewCheckBoxColumn3});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(15, 606);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 20;
            this.customersDataGridView.Size = new System.Drawing.Size(2049, 335);
            this.customersDataGridView.TabIndex = 45;
            this.customersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "referenceNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "referenceNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "companyName";
            this.dataGridViewTextBoxColumn3.HeaderText = "companyName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "softwarename";
            this.dataGridViewTextBoxColumn4.HeaderText = "softwarename";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "companyWebsite";
            this.dataGridViewTextBoxColumn5.HeaderText = "companyWebsite";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "softwareType";
            this.dataGridViewTextBoxColumn6.HeaderText = "softwareType";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn7.HeaderText = "description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "companyEstablished";
            this.dataGridViewTextBoxColumn8.HeaderText = "companyEstablished";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "locationCountries";
            this.dataGridViewTextBoxColumn9.HeaderText = "locationCountries";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "locationCities";
            this.dataGridViewTextBoxColumn10.HeaderText = "locationCities";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "phoneNumber";
            this.dataGridViewTextBoxColumn11.HeaderText = "phoneNumber";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn12.HeaderText = "address";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "employeeCount";
            this.dataGridViewTextBoxColumn13.HeaderText = "employeeCount";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "internalProfessionalServices";
            this.dataGridViewCheckBoxColumn1.HeaderText = "internalProfessionalServices";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "lastDemoDate";
            this.dataGridViewTextBoxColumn14.HeaderText = "lastDemoDate";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "lastReviewedDate";
            this.dataGridViewTextBoxColumn15.HeaderText = "lastReviewedDate";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "businessAreas";
            this.dataGridViewTextBoxColumn16.HeaderText = "businessAreas";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "modules";
            this.dataGridViewTextBoxColumn17.HeaderText = "modules";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "clientTypes";
            this.dataGridViewTextBoxColumn18.HeaderText = "clientTypes";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "cloudType";
            this.dataGridViewCheckBoxColumn2.HeaderText = "cloudType";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "additionalInformation";
            this.dataGridViewTextBoxColumn19.HeaderText = "additionalInformation";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "documentAttached";
            this.dataGridViewCheckBoxColumn3.HeaderText = "documentAttached";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 1008);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(referenceNumberLabel);
            this.Controls.Add(this.referenceNumberTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(softwarenameLabel);
            this.Controls.Add(this.softwarenameTextBox);
            this.Controls.Add(companyWebsiteLabel);
            this.Controls.Add(this.companyWebsiteTextBox);
            this.Controls.Add(softwareTypeLabel);
            this.Controls.Add(this.softwareTypeTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(companyEstablishedLabel);
            this.Controls.Add(this.companyEstablishedDateTimePicker);
            this.Controls.Add(locationCountriesLabel);
            this.Controls.Add(this.locationCountriesTextBox);
            this.Controls.Add(locationCitiesLabel);
            this.Controls.Add(this.locationCitiesTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(employeeCountLabel);
            this.Controls.Add(this.employeeCountTextBox);
            this.Controls.Add(internalProfessionalServicesLabel);
            this.Controls.Add(this.internalProfessionalServicesCheckBox);
            this.Controls.Add(lastDemoDateLabel);
            this.Controls.Add(this.lastDemoDateDateTimePicker);
            this.Controls.Add(lastReviewedDateLabel);
            this.Controls.Add(this.lastReviewedDateDateTimePicker);
            this.Controls.Add(businessAreasLabel);
            this.Controls.Add(this.businessAreasTextBox);
            this.Controls.Add(modulesLabel);
            this.Controls.Add(this.modulesTextBox);
            this.Controls.Add(clientTypesLabel);
            this.Controls.Add(this.clientTypesTextBox);
            this.Controls.Add(cloudTypeLabel);
            this.Controls.Add(this.cloudTypeCheckBox);
            this.Controls.Add(additionalInformationLabel);
            this.Controls.Add(this.additionalInformationTextBox);
            this.Controls.Add(documentAttachedLabel);
            this.Controls.Add(this.documentAttachedCheckBox);
            this.Controls.Add(this.customersBindingNavigator);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "localDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Database1DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox referenceNumberTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox softwarenameTextBox;
        private System.Windows.Forms.TextBox companyWebsiteTextBox;
        private System.Windows.Forms.TextBox softwareTypeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker companyEstablishedDateTimePicker;
        private System.Windows.Forms.TextBox locationCountriesTextBox;
        private System.Windows.Forms.TextBox locationCitiesTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox employeeCountTextBox;
        private System.Windows.Forms.CheckBox internalProfessionalServicesCheckBox;
        private System.Windows.Forms.DateTimePicker lastDemoDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker lastReviewedDateDateTimePicker;
        private System.Windows.Forms.TextBox businessAreasTextBox;
        private System.Windows.Forms.TextBox modulesTextBox;
        private System.Windows.Forms.TextBox clientTypesTextBox;
        private System.Windows.Forms.CheckBox cloudTypeCheckBox;
        private System.Windows.Forms.TextBox additionalInformationTextBox;
        private System.Windows.Forms.CheckBox documentAttachedCheckBox;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
    }
}

