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

namespace RepairServicesSystem
{
    public partial class SelectUser : Form
    {
        public int UserID { get; set; }

        public SelectUser()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DataViewUsers.DataSource = SelectUserFacade.GetUsersDataTable
                (TextBoxFirstName.Text, TextBoxLastName.Text);
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
