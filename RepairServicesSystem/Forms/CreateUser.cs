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
        public CreateUser()
        {
            InitializeComponent();
            RadioButtonClient.Checked = true;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            BackToAdminView();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(!TextBoxFirstName.Equals("") && !TextBoxLastName.Equals("")
                && !TextBoxLogin.Equals("") && !TextBoxPassword.Equals(""))
            {
                Personel personel = new Personel()
                {
                    fname = TextBoxFirstName.Text,
                    lname = TextBoxLastName.Text,
                    login = TextBoxLogin.Text
                };
                AccountsFacade.HashPassword(TextBoxPassword.Text, out string hash, out string salt);
                personel.password_hash = hash;
                personel.password_salt = salt;
                if(RadioButtonClient.Checked)
                {
                    personel.role = "CLIENT";
                }
                else if(RadioButtonAdmin.Checked)
                {
                    personel.role = "ADMIN";
                }
                else if(RadioButtonManager.Checked)
                {
                    personel.role = "MANAGER";
                }
                else
                {
                    personel.role = "WORKER";
                }

                DataClassesDataContext dc = new DataClassesDataContext();
                dc.Personels.InsertOnSubmit(personel);
                dc.SubmitChanges();

                BackToAdminView();
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
