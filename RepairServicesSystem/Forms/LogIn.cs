using BusinessLayer;
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
using System_obsługi_napraw;
using static System_obsługi_napraw.Modes;

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
            Personel personel = AccountsFacade.AuthenticateUser(TextBoxLogin.Text, TextBoxPassword.Text);
            switch(personel.role)
            {
                case "ADMIN":
                    var adminView = new Users(ADMIN);
                    adminView.Location = Location;
                    adminView.StartPosition = FormStartPosition.Manual;
                    adminView.FormClosing += delegate { Close(); };
                    adminView.Show();
                    Hide();
                    break;
                case "WORKER":
                    var activities = new Activities(personel);
                    activities.Location = Location;
                    activities.StartPosition = FormStartPosition.Manual;
                    activities.FormClosing += delegate { Close(); };
                    activities.Show();
                    Hide();
                    break;
                case "MANAGER":
                    var requests = new Requests(MANAGER);
                    requests.Location = Location;
                    requests.StartPosition = FormStartPosition.Manual;
                    requests.FormClosing += delegate { Close(); };
                    requests.Show();
                    Hide();
                    break;
                case "NONE":
                    MessageBox.Show("Authentication failed - username or password incorrect!");
                    break;
            }
        }
    }
}
