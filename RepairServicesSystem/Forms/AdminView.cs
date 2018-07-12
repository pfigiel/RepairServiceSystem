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
    }
}
