﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDashboard
{
    public partial class vendorManage : Form
    {
        public vendorManage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vendorDBDataSet);

        }

        private void vendorManage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorDBDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.vendorDBDataSet.Table);

        }
    }
}
