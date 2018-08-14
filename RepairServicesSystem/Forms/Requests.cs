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
using static System_obsługi_napraw.Modes;

namespace RepairServicesSystem
{
    public partial class Requests : Form
    {
        private Mode mode;

        public Requests()
        {
            InitializeComponent();
            mode = Mode.MANAGER;
            RadioButtonAny.Checked = true;
        }

        private void ButtonAddRequest_Click(object sender, EventArgs e)
        {
            var request = new Request();
            request.ShowDialog();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int id = 0, objectNumber = 0, personelId = 0;
            try
            {
                id = Int32.Parse(TextBoxId.Text);
                objectNumber = Int32.Parse(TextBoxObjectNumber.Text);
                personelId = Int32.Parse(TextBoxPersonelId.Text);
            }
            catch (Exception ex) { }

            string status = "";
            if (RadioButtonOpen.Checked)
            {
                status = "OPEN";
            }
            else if (RadioButtonInProgress.Checked)
            {
                status = "IN_PROGRESS";
            }
            else if (RadioButtonCancelled.Checked)
            {
                status = "CANCELLED";
            }
            else if (RadioButtonFinished.Checked)
            {
                status = "FINISHED";
            }

            DataViewRequests.DataSource = RequestsFacade.GetRequestsDataTable(id, objectNumber, personelId, TextBoxResult.Text, status);
        }

        private void ButtonEditRequest_Click(object sender, EventArgs e)
        {
            if (DataViewRequests.CurrentRow != null)
            {
                int requestId = (int)DataViewRequests.CurrentRow.Cells[0].Value;
                if (RequestsFacade.FindRequest(requestId, out DataLayer.Request request))
                {
                    var form = new Request(request);
                    form.ShowDialog();
                }
            }
        }

        private void ButtonViewRequest_Click(object sender, EventArgs e)
        {
            if (DataViewRequests.CurrentRow != null)
            {
                int requestId = (int)DataViewRequests.CurrentRow.Cells[0].Value;
                if (RequestsFacade.FindRequest(requestId, out DataLayer.Request request))
                {
                    var form = new Request("VIEW");
                    form.ShowDialog();
                }
            }
        }

        private void ButtonShowActivities_Click(object sender, EventArgs e)
        {
            var activities = new Activities("MANAGER");
            activities.ShowDialog();
        }

        private void ButtonPersonel_Click(object sender, EventArgs e)
        {
            var form = new Users(Mode.MANAGER);
            form.ShowDialog();
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            var form = new CreateUser(mode);
            form.Show();
        }

        private void ButtonSearchObject_Click(object sender, EventArgs e)
        {
            var form = new Objects(mode);
            form.ShowDialog();
        }
    }
}
