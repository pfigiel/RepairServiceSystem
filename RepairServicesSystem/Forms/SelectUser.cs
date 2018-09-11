using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System_obsługi_napraw.Modes;

namespace RepairServicesSystem
{
    public partial class SelectUser : Form
    {
        public int UserID { get; set; }
        private Mode mode;

        public SelectUser(Mode mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (mode == Mode.ADMIN)
                DataViewUsers.DataSource = UsersFacade.FindUser
                    (TextBoxFirstName.Text, TextBoxLastName.Text);
            else
            {
                DataViewUsers.DataSource = UsersFacade.GetClientsDataTable
                    (TextBoxFirstName.Text, TextBoxLastName.Text);
            }
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            UserID = (int)DataViewUsers.CurrentRow.Cells[0].Value;
            Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
