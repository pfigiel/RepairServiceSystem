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

namespace RepairServicesSystem
{
    public partial class CreateUser : Form
    {
        private Personel personel;

        public CreateUser()
        {
            InitializeComponent();
            RadioButtonClient.Checked = true;
        }

        public CreateUser(Personel personel)
        {
            InitializeComponent();
            this.personel = personel;
            TextBoxFirstName.Text = personel.fname;
            TextBoxLastName.Text = personel.lname;
            TextBoxLogin.Text = personel.login;
            switch(personel.role)
            {
                case "ADMIN":
                    RadioButtonAdmin.Checked = true;
                    RadioButtonClient.Enabled = false;
                    RadioButtonManager.Enabled = false;
                    RadioButtonWorker.Enabled = false;
                    break;
                case "CLIENT":
                    RadioButtonClient.Checked = true;
                    break;
                case "MANAGER":
                    RadioButtonManager.Checked = true;
                    break;
                case "WORKER":
                    RadioButtonWorker.Checked = true;
                    break;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            BackToAdminView();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(!TextBoxFirstName.Equals("") && !TextBoxLastName.Equals("") && !TextBoxLogin.Equals(""))
            {
                Personel personel = new Personel()
                {
                    fname = TextBoxFirstName.Text,
                    lname = TextBoxLastName.Text,
                    login = TextBoxLogin.Text
                };

                bool isDataValid = false;

                if (!TextBoxPassword.Text.Equals(""))
                {
                    AccountsFacade.HashPassword(TextBoxPassword.Text, out string hash, out string salt);
                    personel.password_hash = hash;
                    personel.password_salt = salt;
                    isDataValid = true;
                }
                else if (TextBoxPassword.Text.Equals("") && this.personel != null)
                {
                    personel.password_hash = this.personel.password_hash;
                    personel.password_salt = this.personel.password_salt;
                    isDataValid = true;
                }

                if (isDataValid)
                {
                    if (RadioButtonClient.Checked)
                    {
                        personel.role = "CLIENT";
                    }
                    else if (RadioButtonAdmin.Checked)
                    {
                        personel.role = "ADMIN";
                    }
                    else if (RadioButtonManager.Checked)
                    {
                        personel.role = "MANAGER";
                    }
                    else
                    {
                        personel.role = "WORKER";
                    }

                    if (personel != null)
                    {
                        AdminFacade.DeletePersonel(this.personel.id_pers);
                    }
                    AdminFacade.AddPersonel(personel);

                    BackToAdminView();
                }
            }
        }

        private void BackToAdminView()
        {
            var form = new AdminView();
            form.Location = Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { Close(); };
            form.Show();
            Hide();
        }
    }
}
