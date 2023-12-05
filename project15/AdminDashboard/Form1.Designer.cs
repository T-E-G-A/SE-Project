namespace AdminDashboard
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.consultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultantDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultantDBDataSet = new AdminDashboard.ConsultantDBDataSet();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFullName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.consultTableAdapter = new AdminDashboard.ConsultantDBDataSetTableAdapters.ConsultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(51, 93);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Phone Number:";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultBindingSource, "PhoneNumber", true));
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Hint = "";
            this.txtPhoneNumber.Location = new System.Drawing.Point(204, 89);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.Size = new System.Drawing.Size(202, 23);
            this.txtPhoneNumber.TabIndex = 0;
            this.txtPhoneNumber.UseSystemPasswordChar = false;
            // 
            // consultBindingSource
            // 
            this.consultBindingSource.DataMember = "Consult";
            this.consultBindingSource.DataSource = this.consultantDBDataSetBindingSource;
            // 
            // consultantDBDataSetBindingSource
            // 
            this.consultantDBDataSetBindingSource.DataSource = this.consultantDBDataSet;
            this.consultantDBDataSetBindingSource.Position = 0;
            // 
            // consultantDBDataSet
            // 
            this.consultantDBDataSet.DataSetName = "ConsultantDBDataSet";
            this.consultantDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(51, 124);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Full name:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(51, 157);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Email";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(51, 188);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Address";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(51, 224);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Search";
            // 
            // txtFullName
            // 
            this.txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultBindingSource, "FullName", true));
            this.txtFullName.Depth = 0;
            this.txtFullName.Hint = "";
            this.txtFullName.Location = new System.Drawing.Point(204, 124);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.Size = new System.Drawing.Size(202, 23);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.UseSystemPasswordChar = false;
            this.txtFullName.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultBindingSource, "Email", true));
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(204, 157);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(202, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultBindingSource, "Address", true));
            this.txtAddress.Depth = 0;
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(204, 188);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(202, 23);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(204, 224);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(202, 23);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(552, 435);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(46, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumberDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.consultBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(22, 271);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(621, 157);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            this.dataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(482, 435);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(64, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Location = new System.Drawing.Point(435, 435);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(41, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Depth = 0;
            this.btnNew.Location = new System.Drawing.Point(387, 435);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.Primary = false;
            this.btnNew.Size = new System.Drawing.Size(42, 36);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // consultTableAdapter
            // 
            this.consultTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 510);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Consultant Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFullName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialFlatButton btnNew;
        private System.Windows.Forms.BindingSource consultantDBDataSetBindingSource;
        private ConsultantDBDataSet consultantDBDataSet;
        private System.Windows.Forms.BindingSource consultBindingSource;
        private ConsultantDBDataSetTableAdapters.ConsultTableAdapter consultTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}