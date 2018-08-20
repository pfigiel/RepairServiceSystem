﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
namespace RepairServicesSystem
{
    public partial class Activity : Form
    {
        private DataLayer.Activity activity;
        string mode;
        public Activity()
        {
            InitializeComponent();
        }
        public Activity(String mode,DataLayer.Activity activity)
        {
            InitializeComponent();
            this.mode = mode;
            this.activity = activity;
            if (mode == "VIEW")
            {
                DisablecControls();
                SetControls(activity);
            }
            else if(mode == "EDIT")
            {
                SetControls(activity);
            }
        }
        private void DisablecControls()
        {
            //ShowRequestBtn.Enabled = false;
            TextBoxActivityType.Enabled = false;
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
            TextBoxActivityType.Text = activity.act_type.ToString();
            TextBoxPersonelId.Text = activity.id_pers.ToString();
            TextBoxSequenceNumber.Text = activity.seq_no.ToString();
            TextBoxReqId.Text = activity.id_req.ToString();
            if(activity.status.ToString().Contains("OPEN"))
            {
                RadioButtonOpen.Checked = true;
            }
            else if(activity.status.ToString().Contains("INPR"))
            {
                RadioButtonInProgress.Checked = true;
            }
            else if (activity.status.ToString().Contains("CANC"))
            {
                RadioButtonCancelled.Checked = true;
            }
            else if (activity.status.ToString().Contains("FINI"))
            {
                RadioButtonFinished.Checked = true;
            }
            /*switch (activity.status)
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
            }*/
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
            if(this.activity != null)
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
            var form = new Users("VIEW");
            form.ShowDialog();
            TextBoxPersonelId.Text = form.UserId.ToString();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(!TextBoxActivityType.Text.Equals("") && !TextBoxPersonelId.Text.Equals("") 
                && !TextBoxDescription.Text.Equals("") && !TextBoxSequenceNumber.Text.Equals("") 
                && !TextBoxResult.Text.Equals("") && !TextBoxReqId.Text.Equals(""))
            {
                DataLayer.Activity activity = new DataLayer.Activity()
                {
                    act_type = TextBoxActivityType.Text,
                    id_pers = int.Parse(TextBoxPersonelId.Text),
                    descr = TextBoxDescription.Text,
                    result = TextBoxResult.Text,
                    seq_no = int.Parse(TextBoxSequenceNumber.Text)
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
                if(this.activity == null)
                {
                    if(!ActivitiesFacade.AddActivity(activity))
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
                    if(!ActivitiesFacade.UpdateActivity(activity))
                    {
                        MessageBox.Show("Error occurred while adding activity do DB");
                    }
                    else
                    {
                        Close();
                    }
                }
            }


        }

        private void ReqIdBtn_Click(object sender, EventArgs e)
        {
            var form = new Requests(System_obsługi_napraw.Modes.Mode.WORKER);
            form.ShowDialog();
            TextBoxReqId.Text = form.requestId.ToString();
        }

        private void TextBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
