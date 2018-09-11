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
using BusinessLayer;
using System_obsługi_napraw;

namespace RepairServicesSystem
{
    public partial class Request : Form
    {
        private DataLayer.Request request;
        public Request()
        {
            InitializeComponent();
            ButtonToObjects.Visible = false;
        }

        public Request(DataLayer.Request request)
        {
            InitializeComponent();
            SetControls(request);
            this.request = request;
            ButtonToObjects.Visible = false;
        }

        public Request(string mode,DataLayer.Request request)
        {
            InitializeComponent();
            ButtonToObjects.Visible = false;
            switch (mode)
            {
                case "VIEW":
                    TextBoxObjectNumber.Enabled = false;
                    TextBoxPersonelId.Enabled = false;
                    TextBoxDescription.Enabled = false;
                    TextBoxResult.Enabled = false;
                    DateTimePickerStart.Enabled = false;
                    DateTimePickerEnd.Enabled = false;
                    RadioButtonCancelled.Enabled = false;
                    RadioButtonFinished.Enabled = false;
                    RadioButtonInProgress.Enabled = false;
                    RadioButtonOpen.Enabled = false;
                    ButtonObjects.Enabled = false;
                    ButtonUsers.Enabled = false;
                    ButtonAddActivity.Enabled = false;
                    ButtonSave.Enabled = false;
                    ButtonToObjects.Enabled = false;
                    break;
            }
            SetControls(request);
            this.request = request;
        }
        private void SetControls(DataLayer.Request request)
        {
            TextBoxObjectNumber.Text = request.nr_obj.ToString();
            TextBoxPersonelId.Text = request.id_pers.ToString();
            TextBoxDescription.Text = request.descr;
            TextBoxResult.Text = request.result;
            DateTimePickerStart.Value = request.dt_reg;
            DateTimePickerEnd.Value = request.dt_fin_cancel;
            switch (request.status)
            {
                case "OPEN":
                    RadioButtonOpen.Checked = true;
                    break;
                case "INPR":
                    RadioButtonInProgress.Checked = true;
                    break;
                case "CANC":
                    RadioButtonCancelled.Checked = true;
                    break;
                case "FINI":
                    RadioButtonFinished.Checked = true;
                    break;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonShowActivities_Click(object sender, EventArgs e)
        {
            if(this.request != null)
            {
                int id = request.id_req;
                var activities = new Activities(VIEW_ONLY, id);
                activities.ShowDialog();
            }
            else
            {
                MessageBox.Show("Request does not exist yet !");
            }
        }

        private void ButtonAddActivity_Click(object sender, EventArgs e)
        {
            if(this.request == null)
            {
                MessageBox.Show("Request does not exist yet !");
            }
            else
            {
                var activity = new Activity(request.id_req);
                activity.ShowDialog();
            }
        }

        private void ButtonObjects_Click(object sender, EventArgs e)
        {
            var form = new Objects(VIEW_ONLY);
            form.ShowDialog();
            TextBoxObjectNumber.Text = (form.nr_obj.ToString());
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            var form = new Users(VIEW_MANAGERS);
            form.ShowDialog();
            TextBoxPersonelId.Text = form.UserId.ToString();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!TextBoxObjectNumber.Text.Equals("") && !TextBoxPersonelId.Text.Equals(""))
            {
                DataLayer.Request request = new DataLayer.Request()
                {
                    nr_obj = int.Parse(TextBoxObjectNumber.Text),
                    id_pers = int.Parse(TextBoxPersonelId.Text)
                };
                request.descr = TextBoxDescription.Text;
                request.result = TextBoxResult.Text;
                request.dt_reg = DateTimePickerStart.Value.Date;
                request.dt_fin_cancel = DateTimePickerEnd.Value.Date;
                if (RadioButtonCancelled.Checked)
                {
                    request.status = "CANC";
                }
                else if (RadioButtonFinished.Checked)
                {
                    request.status = "FINI";
                }
                else if (RadioButtonInProgress.Checked)
                {

                    request.status = "INPR";
                }
                else if (RadioButtonOpen.Checked)
                {
                    request.status = "OPEN";
                }

                if (this.request != null)
                {
                    // request.id_req = this.request.id_req;
                    request.id_req = this.request.id_req;
                    if(!RequestsFacade.UpdateRequest(request))
                    {
                        MessageBox.Show("Error occurred while adding request do DB");
                    }
                    else
                    {
                        Close();
                    }
                    //RequestsFacade.DeleteRequest(this.request.id_req);
                }
                else
                {
                    if (!RequestsFacade.AddRequest(request))
                    {
                        MessageBox.Show("Error occurred while adding request do DB");
                    }
                    else
                    {
                        //BackToRequests();
                        Close();
                    }
                }
            }
        }
        private void BackToRequests()
        {
            var form = new Requests(MANAGER);
            form.Location = Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { Close(); };
            form.Show();
            Hide();
        }

        private void TextBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonToObjects_Click(object sender, EventArgs e)
        {
            var form = new Objects(MANAGER);
            form.Show();
            Hide();
        }
    }
}
