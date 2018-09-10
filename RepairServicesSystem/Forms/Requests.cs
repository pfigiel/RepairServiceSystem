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
        public int requestId { get; set; }
        public Requests(Mode mode)
        {
            InitializeComponent();
            this.mode = mode;
            RadioButtonAny.Checked = true;
            DataViewRequests.DataSource = RequestsFacade.GetRequests();
            if(mode == Mode.WORKER)
            {
                DisableControls();
            }
            else if(mode == Mode.MANAGER)
            {
                BackBtn.Enabled = false;
            }
        }
        private void DisableControls()
        {
            ButtonAddRequest.Enabled = false;
            ButtonEditRequest.Enabled = false;
            ButtonViewRequest.Enabled = false;
            ButtonShowActivities.Enabled = false;
            ButtonAddClient.Enabled = false;
        }
        private void ButtonAddRequest_Click(object sender, EventArgs e)
        {
            var request = new Request();
            request.ShowDialog();
            DataViewRequests.DataSource = RequestsFacade.GetRequests();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int id = 0, objectNumber = 0, personelId = 0;
            try
            {
                if(TextBoxId.Text.Any()) id = Int32.Parse(TextBoxId.Text);
                if (TextBoxObjectNumber.Text.Any()) objectNumber = Int32.Parse(TextBoxObjectNumber.Text);
                if (TextBoxPersonelId.Text.Any()) personelId = Int32.Parse(TextBoxPersonelId.Text);
            }
            catch (Exception ex) { }

            string status = "";
            if (RadioButtonOpen.Checked)
            {
                status = "OPEN";
            }
            else if (RadioButtonInProgress.Checked)
            {
                status = "INPR";
            }
            else if (RadioButtonCancelled.Checked)
            {
                status = "CANC";
            }
            else if (RadioButtonFinished.Checked)
            {
                status = "FINI";
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
                    DataViewRequests.DataSource = RequestsFacade.GetRequests();
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
                    var form = new Request("VIEW",request);
                    form.ShowDialog();
                }
            }
        }

        private void ButtonShowActivities_Click(object sender, EventArgs e)
        {
            if (DataViewRequests.CurrentRow != null)
            {
                var activities = new Activities("MANAGER", (int)DataViewRequests.CurrentRow.Cells[0].Value);
                activities.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pick request !");
            }
                
        }

        private void ButtonPersonel_Click(object sender, EventArgs e)
        {
            var form = new Users("VIEW_MANAGERS");
            form.ShowDialog();
            TextBoxPersonelId.Text = form.UserId.ToString();
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            var form = new CreateUser(mode);
            form.Show();
        }

        private void ButtonSearchObject_Click(object sender, EventArgs e)
        {
            var form = new Objects(Mode.VIEW_ONLY);
            form.ShowDialog();
            TextBoxObjectNumber.Text = (form.nr_obj.ToString());
        }

        private void Requests_Load(object sender, EventArgs e)
        {

        }

        private void DataViewRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if(DataViewRequests.CurrentRow != null)
            {
                requestId = (int)DataViewRequests.CurrentRow.Cells[0].Value;
                Close();
            }
            else
            {
                MessageBox.Show("Request not selected !");
            }
        }

        private void ButtonAddObject_Click(object sender, EventArgs e)
        {
            var form = new Objects(Mode.MANAGER);
            form.FormClosing += delegate { this.Close(); };
            form.Show();
            Hide();
        }
    }
}
