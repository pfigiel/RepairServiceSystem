using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using static System_obsługi_napraw.Modes;

namespace RepairServicesSystem
{
    public partial class Users : Form
    {
        private Mode mode;
        public int UserId { get; set; }

        public Users(Mode mode)
        {
            InitializeComponent();
            this.mode = mode;
            switch (this.mode)
            {
                case Mode.MANAGER:
                    DataViewUsers.DataSource = AdminFacade.GetClientsDataTable();
                    ButtonAddUser.Enabled = false;
                    ButtonEditUser.Enabled = false;
                    ButtonFindUser.Enabled = false;
                    ButtonDeleteUser.Enabled = false;
                    break;
                case Mode.ADMIN:
                    DataViewUsers.DataSource = AdminFacade.GetPersonelDataTable();
                    break;
                case Mode.WORKER:
                    DataViewUsers.DataSource = AdminFacade.GetClientsDataTable();
                    ButtonAddUser.Enabled = false;
                    ButtonEditUser.Enabled = false;
                    ButtonFindUser.Enabled = false;
                    ButtonDeleteUser.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        public Users(String mode)
        {
            InitializeComponent();
            this.mode = Mode.MANAGER;
            if(mode == "VIEW")
            {
                DataViewUsers.DataSource = AdminFacade.GetPersonelDataTable();
                ButtonAddUser.Enabled = false;
                ButtonEditUser.Enabled = false;
                ButtonFindUser.Enabled = false;
                ButtonDeleteUser.Enabled = false;
            }
        }
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            var form = new CreateUser(mode);
            form.Location = Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { Close(); };
            form.Show();
            Hide();
        }

        private void ButtonEditUser_Click(object sender, EventArgs e)
        {
            int userID = (int)DataViewUsers.CurrentRow.Cells[0].Value;
            if(AdminFacade.FindPersonel(userID, out Personel personel))
            {
                var form = new CreateUser(personel);
                form.Location = Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { Close(); };
                form.Show();
                Hide();
            }
        }

        private void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            int userID = (int)DataViewUsers.CurrentRow.Cells[0].Value;
            AdminFacade.FindPersonel(userID, out Personel personel);
            if (!personel.role.Equals("ADMIN"))
            {
                AdminFacade.DeletePersonel(userID);
            }
            DataViewUsers.DataSource = AdminFacade.GetPersonelDataTable();
        }

        private void ButtonFindUser_Click(object sender, EventArgs e)
        {
            var form = new SelectUser(mode);
            form.Location = Location;
            form.ShowDialog();
            for(int i = 0; i < DataViewUsers.Rows.Count; i++)
            {
                if((int)DataViewUsers.Rows[i].Cells[0].Value == form.UserID)
                {
                    DataViewUsers.CurrentCell = DataViewUsers.Rows[i].Cells[0];
                    break;
                }
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            UserId = (int)DataViewUsers.CurrentRow.Cells[0].Value;
            Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void DataViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
