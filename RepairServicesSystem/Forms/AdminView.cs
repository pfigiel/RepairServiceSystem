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

namespace RepairServicesSystem
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
            DataViewUsers.DataSource = AdminFacade.GetPersonelDataTable();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            var form = new CreateUser();
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
    }
}
