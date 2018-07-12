using DataLayer;
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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            string userRole = BusinessLayer.AccountsFacade.AuthenticateUser(TextBoxLogin.Text, TextBoxPassword.Text);
            switch(userRole)
            {
                case "ADMIN":
                    var form = new AdminView();
                    form.Location = Location;
                    form.StartPosition = FormStartPosition.Manual;
                    form.FormClosing += delegate { Close(); };
                    form.Show();
                    Hide();
                    break;
                case "":
                    TextBoxLogin.Text = "User not found";
                    break;
            }
        }
    }
}
