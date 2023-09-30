﻿using Pz0429_Library.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pz0429_Library.UIForms
{
    public partial class frmMainAdmin : Form
    {
        bool dataChange = false;
        DialogResult mainExitResult = DialogResult.None;
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = dsGender.Tables[0];
            Array arr = Enum.GetValues(typeof(Gender));
            DataRow row;

            foreach(Gender g in arr)
            {
                row = dt.NewRow();
                row["gender"] = g.ToString();
                dt.Rows.Add(row);
            }

            // TODO: This line of code loads data into the 'dsGetAllUsersData.spGetAllUsersData' table. You can move, or remove it, as needed.
            this.spGetAllUsersDataTableAdapter.Fill(this.dsGetAllUsersData.spGetAllUsersData);

        }

        private void spGetAllUsersDataBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvUsersInfo.Rows)
            {
                row.Selected = false;
                foreach(DataGridViewCell cell in row.Cells)
                    if(cell.Value != null && cell.Value.ToString().Contains(tbValueToSearch.Text))
                    {
                        row.Selected = true;
                        break;
                    }
            }
        }

        private void dgvUsersInfo_Filter(object sender, EventArgs e)
        {
            (dgvUsersInfo.DataSource as BindingSource).Filter =
                $"firstName like '%{tbFirstName.Text}%' and lastName like '%{tbLastName.Text}%'";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow userRow = dsGetAllUsersData.Tables[0].NewRow();
            userRow["login"] = "";
            userRow["password"] = "";
            dsGetAllUsersData.Tables[0].Rows.Add(userRow);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete Row?",
                "Delete row dialog box", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(dialogResult == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgvUsersInfo.SelectedRows)
                    dgvUsersInfo.Rows.Remove(row);
            }
        }

        private void dgvUsersInfo_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete Row?",
                "Delete row dialog box", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.spGetAllUsersDataTableAdapter.Adapter.Update(dsGetAllUsersData);
                dataChange = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ///
            
        }

        private void dgvUsersInfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataChange = dataChange || dgvUsersInfo.IsCurrentCellDirty;
            
        }

        private void dgvUsersInfo_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataChange = true;
        }

        private void dgvUsersInfo_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataChange = true;
        }

        private void frmMainAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dataChange)
            {
                mainExitResult = MessageBox.Show("Save your changes to database?",
                    "Save changes before exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);

                switch(mainExitResult)
                {
                    case DialogResult.Yes:
                        //save button click
                        break;
                    case DialogResult.No:
                        e.Cancel = false;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void frmMainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }

        private void dgvUsersInfo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            string cName = dgv.Columns[e.ColumnIndex].HeaderText;

            string cellValue = e.FormattedValue.ToString().Trim();
            String msg = null;

            switch (cName)
            {
                case "login":
                    Validator.ValidLogin(cellValue, out msg);
                    break;
                case "password":
                    Validator.ValidPassword(cellValue, out msg);
                    break;
                case "firstname":
                case "lastname":
                    ///////
                    break;

            }

            dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = msg;
        }

        private void dgvUsersInfo_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
