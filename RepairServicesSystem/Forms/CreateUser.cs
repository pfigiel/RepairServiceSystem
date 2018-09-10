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
using static System_obsługi_napraw.Modes;

namespace RepairServicesSystem
{
    public partial class CreateUser : Form
    {
        private Personel personel;
        private Client client;
        private Mode mode;

        public CreateUser(Mode mode)
        {
            InitializeComponent();
            this.mode = mode;
            switch(this.mode)
            {
                case Mode.MANAGER:
                    RadioButtonClient.Checked = true;
                    RadioButtonAdmin.Enabled = false;
                    RadioButtonManager.Enabled = false;
                    RadioButtonWorker.Enabled = false;
                    LabelLoginName.Text = "Name";
                    LabelPasswordTelephone.Text = "Telephone";
                    break;
            }
        }

        public CreateUser(Personel personel)
        {
            InitializeComponent();
            this.personel = personel;
            TextBoxFirstName.Text = personel.fname;
            TextBoxLastName.Text = personel.lname;
            TextBoxLoginName.Text = personel.login;
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
            switch (mode)
            {
                case Mode.MANAGER:
                    Close();
                    break;
                case Mode.ADMIN:
                    BackToUsers();
                    break;
                default:
                    break;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(!TextBoxFirstName.Equals("") && !TextBoxLastName.Equals("") && !TextBoxLoginName.Equals(""))
            {
                if(RadioButtonClient.Checked)
                {
                    Client client = new Client()
                    {
                        fname = TextBoxFirstName.Text,
                        lname = TextBoxLastName.Text,
                        name = TextBoxLoginName.Text,
                        telephone = TextBoxPasswordTelephone.Text
                    };
                    if(this.client != null)
                    {
                        ClientFacade.DeleteClient(this.client.id_cli);
                    }
                    ClientFacade.AddClient(client);
                }
                else
                {
                    Personel personel = new Personel()
                    {
                        fname = TextBoxFirstName.Text,
                        lname = TextBoxLastName.Text,
                        login = TextBoxLoginName.Text
                    };
                    bool isDataValid = false;
                    if (!TextBoxPasswordTelephone.Text.Equals(""))
                    {
                        AccountsFacade.HashPassword(TextBoxPasswordTelephone.Text, out string hash, out string salt);
                        personel.password_hash = hash;
                        personel.password_salt = salt;
                        isDataValid = true;
                    }
                    else if (TextBoxPasswordTelephone.Text.Equals("") && this.personel != null)
                    {
                        personel.password_hash = this.personel.password_hash;
                        personel.password_salt = this.personel.password_salt;
                        isDataValid = true;
                    }
                    if (isDataValid)
                    {
                        if (RadioButtonAdmin.Checked)
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

                        if (this.personel != null)
                        {
                            AdminFacade.DeletePersonel(this.personel.id_pers);
                        }
                        if (AdminFacade.FindPersonel(personel.id_pers, out Personel pers))
                        {
                            AdminFacade.updateUser(personel);
                        }
                        else
                        {
                            AdminFacade.AddPersonel(personel);
                        }
                    }
                }
                Close();
            }
        }

        private void BackToUsers()
        {
            var form = new Users(mode);
            form.Location = Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { Close(); };
            form.Show();
            Hide();
        }
    }
}
