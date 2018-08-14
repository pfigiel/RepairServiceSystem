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
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        public Request(DataLayer.Request request)
        {
            TextBoxObjectNumber.Text = request.nr_obj.ToString();
            TextBoxPersonelId.Text = request.id_pers.ToString();
            TextBoxDescription.Text = request.descr;
            TextBoxResult.Text = request.result;
            DateTimePickerStart.Value = request.dt_reg;
            DateTimePickerEnd.Value = request.dt_fin_cancel;
            switch(request.status)
            {
                case "OPEN":
                    RadioButtonOpen.Checked = true;
                    break;
                case "IN_PROGRESS":
                    RadioButtonOpen.Checked = true;
                    break;
                case "CANCELLED":
                    RadioButtonOpen.Checked = true;
                    break;
                case "FINISHED":
                    RadioButtonOpen.Checked = true;
                    break;
            }
        }

        public Request(string mode)
        {
            switch(mode)
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
                    break;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonShowActivities_Click(object sender, EventArgs e)
        {
            var activities = new Activities("MANAGER");
            activities.ShowDialog();
        }

        private void ButtonAddActivity_Click(object sender, EventArgs e)
        {
            var activity = new Activity();
            activity.ShowDialog();
        }
    }
}
