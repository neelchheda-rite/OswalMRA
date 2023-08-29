using OswalMRA.COMMON.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OswalMRA.Views {
    public partial class frmUserPage : Form {
        public frmUserPage()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataTableUser.ReadOnly = true;
        }
        private void InitializeDataGridView()
        {
            dataTableUser.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn id = new()
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "ID"
            };

            DataGridViewTextBoxColumn name = new()
            {
                DataPropertyName = "name",
                Name = "name",
                HeaderText = "Name"
            };

            DataGridViewTextBoxColumn role = new()
            {
                DataPropertyName = "role",
                Name = "role",
                HeaderText = "Role"
            };

            

            DataGridViewButtonColumn edit = new()
            {
                HeaderText = "Action",
                Text = "Edit",
                Name = "edit",
                DataPropertyName = "Edit"
            };
            edit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            edit.DefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 75;
            edit.FlatStyle = FlatStyle.Flat;
            edit.CellTemplate.Style.ForeColor = Color.FromArgb(105, 190, 40);
            edit.CellTemplate.Style.SelectionForeColor = Color.FromArgb(105, 190, 40);
            edit.CellTemplate.Style.SelectionBackColor = edit.CellTemplate.Style.BackColor;
            edit.ToolTipText = "";

            DataGridViewButtonColumn delete = new()
            {
                HeaderText = "Action",
                Text = "Delete",
                Name = "delete",
                DataPropertyName = "Delete"
            };
            delete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            delete.DefaultCellStyle.Padding = new Padding(0);
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 75;
            delete.FlatStyle = FlatStyle.Flat;
            delete.CellTemplate.Style.ForeColor = Color.FromArgb(229, 79, 63);
            delete.CellTemplate.Style.SelectionForeColor = Color.FromArgb(229, 79, 63);
            delete.CellTemplate.Style.SelectionBackColor = delete.CellTemplate.Style.BackColor;
            delete.ToolTipText = "";

            dataTableUser.Columns.AddRange(new DataGridViewColumn[] {id, name, role, edit, delete });
            dataTableUser.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            PopulateMouldData();
        }
        private void PopulateMouldData()
        {
            var users = new List<User>
            {
                new User { ID = 1, Name= "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 1, Name = "user1", Role = "Admin" },
                new User { ID = 2, Name = "user2", Role = "Supervisor" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
                new User { ID = 3, Name = "user3", Role = "Worker" },
            };
            dataTableUser.DataSource = users;
        }

        private void dataTableUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataTableUser.Columns["Delete"].Index)
                {

                    frmToast frmToast = new("Deleted successfully", "Error");
                    frmToast.ShowAtBottomCenter();
                } else if (e.ColumnIndex == dataTableUser.Columns["Edit"].Index)
                {

                    frmToast frmToast = new("Edited successfully", "Success");
                    frmToast.ShowAtBottomCenter();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            singleMsgBox singleMsgBox = new("Add New User", "", "Add", "Cancel");
            DialogResult dialogResult = singleMsgBox.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                frmToast frmToast = new("User added successfully", "Success");
                frmToast.ShowAtBottomCenter();
            }
        }
    }
}
