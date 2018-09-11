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
using System_obsługi_napraw;

namespace RepairServicesSystem
{
    public partial class Activity : Form
    {
        private Dictionary<string, string> activityDict;
        private DataLayer.Activity activity;
        private Modes mode;

        public Activity()
        {
            InitializeComponent();
            activityDict = new Dictionary<string, string>();
            ButtonShowRequest.Visible = false;
            foreach(string activityType in ActivityTypeFacade.GetActivityTypeNames())
            {
                ComboBoxActivityType.Items.Add(activityType);
                activityDict.Add(activityType, ActivityTypeFacade.GetActivityTypeByActivityName(activityType));
            }
        }

        public Activity(int requestId)
        {
            InitializeComponent();
            activityDict = new Dictionary<string, string>();
            foreach (string activityType in ActivityTypeFacade.GetActivityTypeNames())
            {
                ComboBoxActivityType.Items.Add(activityType);
                activityDict.Add(activityType, ActivityTypeFacade.GetActivityTypeByActivityName(activityType));
            }
            ButtonShowRequest.Visible = false;
            TextBoxReqId.Text = requestId.ToString();
        }

        public Activity(Modes mode, DataLayer.Activity activity)
        {
            InitializeComponent();
            this.mode = mode;
            this.activity = activity;
            activityDict = new Dictionary<string, string>();

            foreach (string activityType in ActivityTypeFacade.GetActivityTypeNames())
            {
                ComboBoxActivityType.Items.Add(activityType);
                activityDict.Add(activityType, ActivityTypeFacade.GetActivityTypeByActivityName(activityType));
            }

            if (mode == Modes.VIEW_ONLY)
            {
                DisablecControls();
                SetControls(activity);
            }
            else if(mode == Modes.EDIT) SetControls(activity);

            if (mode == Modes.VIEW_ONLY_NO_REQUESTS) ButtonShowRequest.Enabled = false;

            ButtonShowRequest.Visible = false;
        }

        private void DisablecControls()
        {
            ComboBoxActivityType.Enabled = false;
            TextBoxPersonelId.Enabled = false;
            TextBoxSequenceNumber.Enabled = false;
            RadioButtonOpen.Enabled = false;
            RadioButtonInProgress.Enabled = false;
            RadioButtonCancelled.Enabled = false;
            RadioButtonFinished.Enabled = false;
            TextBoxDescription.Enabled = false;
            TextBoxResult.Enabled = false;
            DateTimePickerStart.Enabled = false;
            DateTimePickerEnd.Enabled = false;
            ButtonSave.Enabled = false;
            TextBoxReqId.Enabled = false;
            ReqIdBtn.Enabled = false;
            ShowPersonelBtn.Enabled = false;

        }
        private void SetControls(DataLayer.Activity activity)
        {
            ComboBoxActivityType.Text = activity.act_type.ToString();
            TextBoxPersonelId.Text = activity.id_pers.ToString();
            TextBoxSequenceNumber.Text = activity.seq_no.ToString();
            TextBoxReqId.Text = activity.id_req.ToString();

            if (activity.status.ToString().Contains("OPEN")) RadioButtonOpen.Checked = true;
            else if(activity.status.ToString().Contains("INPR")) RadioButtonInProgress.Checked = true;
            else if (activity.status.ToString().Contains("CANC")) RadioButtonCancelled.Checked = true;
            else if (activity.status.ToString().Contains("FINI")) RadioButtonFinished.Checked = true;
            
            TextBoxDescription.Text = activity.descr;
            TextBoxResult.Text = activity.result;
            DateTimePickerStart.Value = activity.dt_reg;
            DateTimePickerEnd.Value = activity.dt_fin_cancel;
        }

        public Activity(int requestId, string activityType, int personelId, int sequenceNumber, string description, string status, DateTime dateStart, DateTime dateFinCancel)
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowRequestBtn_Click(object sender, EventArgs e)
        {
            if(activity != null)
            {
                int requestId = this.activity.id_req;
                if (RequestsFacade.FindRequest(requestId, out DataLayer.Request request))
                {
                    var form = new Request("VIEW", request);
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Activity does not exist yet!");
            }
        }

        private void ShowPersonelBtn_Click(object sender, EventArgs e)
        {
            var form = new Users(Modes.VIEW_WORKERS);
            form.ShowDialog();
            TextBoxPersonelId.Text = form.UserId.ToString();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(!ComboBoxActivityType.Text.Equals("") && !TextBoxPersonelId.Text.Equals("") 
                && !TextBoxDescription.Text.Equals("") && !TextBoxSequenceNumber.Text.Equals("") 
                && !TextBoxReqId.Text.Equals(""))
            {
                try
                {
                    DataLayer.Activity activity = new DataLayer.Activity()
                    {
                        act_type = activityDict[ComboBoxActivityType.Text],
                        id_pers = int.Parse(TextBoxPersonelId.Text),
                        descr = TextBoxDescription.Text,
                        result = TextBoxResult.Text,
                        seq_no = int.Parse(TextBoxSequenceNumber.Text),
                    };
                    activity.id_req = int.Parse(TextBoxReqId.Text);
                    activity.dt_reg = DateTimePickerStart.Value.Date;
                    activity.dt_fin_cancel = DateTimePickerEnd.Value.Date;
                    if (RadioButtonCancelled.Checked)
                    {
                        activity.status = "CANC";
                    }
                    else if (RadioButtonFinished.Checked)
                    {
                        activity.status = "FINI";
                    }
                    else if (RadioButtonInProgress.Checked)
                    {

                        activity.status = "INPR";
                    }
                    else if (RadioButtonOpen.Checked)
                    {
                        activity.status = "OPEN";
                    }
                    if (this.activity == null)
                    {
                        if (!ActivitiesFacade.AddActivity(activity))
                        {
                            MessageBox.Show("Error occurred while adding activity do DB");
                        }
                        else
                        {
                            Close();
                        }
                    }
                    else
                    {
                        activity.id_act = this.activity.id_act;
                        if (!ActivitiesFacade.UpdateActivity(activity))
                        {
                            MessageBox.Show("Error occurred while adding activity do DB");
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
                catch(Exception ex) { MessageBox.Show("Unable to add activity, incorrect data entered!"); }
            }


        }

        private void ReqIdBtn_Click(object sender, EventArgs e)
        {
            var form = new Requests(Modes.WORKER);
            form.ShowDialog();
            TextBoxReqId.Text = form.requestId.ToString();
        }

        private void TextBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
