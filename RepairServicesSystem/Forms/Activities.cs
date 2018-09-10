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
    public partial class Activities : Form
    {
        Personel personel;
        private string userType;
        private int reqId;

        public Activities(string userType)
        {
            InitializeComponent();
            this.userType = userType;
            DataViewActivities.DataSource = ActivitiesFacade.GetActivities();
            if (userType.Equals("WORKER"))
            {
                ButtonBack.Enabled = false;
                ButtonAdd.Enabled = false;
            }
        }
        public Activities(string userType, int id)
        {
            InitializeComponent();
            this.userType = userType;
            this.reqId = id;
            DataViewActivities.DataSource = ActivitiesFacade.GetActivitiesByRequestId(id);
            if (userType.Equals("WORKER"))
            {
                ButtonBack.Enabled = false;
                ButtonAdd.Enabled = false;
            }
            else if (userType.Equals("VIEW_ONLY"))
            {
                ButtonAdd.Enabled = false;
                ButtonBack.Enabled = false;
            }
        }

        public Activities(Personel personel)
        {
            InitializeComponent();
            DataViewActivities.DataSource = ActivitiesFacade.GetActivitiesForWorker(personel);
            ButtonBack.Enabled = false;
            if(personel.role.Equals("WORKER"))
            {
                ButtonAdd.Enabled = false;
                ButtonBack.Enabled = false;
            }
            this.personel = personel;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var activity = new Activity();
            activity.ShowDialog();
            if (personel != null)
                DataViewActivities.DataSource = ActivitiesFacade.GetActivitiesForWorker(personel);
            else
                DataViewActivities.DataSource = ActivitiesFacade.GetActivities();
        }

        public void RefreshDataView()
        {
            int activityId = 0, requestId = 0, personelId = 0;
            String status = "";
            try
            {
                if (!TextBoxActivityId.Text.Equals(""))
                {
                    activityId = Int32.Parse(TextBoxActivityId.Text);
                }
                else
                {
                    activityId = 0;
                }
                if (!TextBoxRequestId.Text.Equals(""))
                {
                    requestId = Int32.Parse(TextBoxRequestId.Text);
                }
                else
                {
                    requestId = 0;
                }
                if (!TextBoxPersonelId.Text.Equals(""))
                {
                    personelId = Int32.Parse(TextBoxPersonelId.Text);
                }
                else
                {
                    personelId = 0;
                }
                if(!TextBoxStatus.Text.Equals(""))
                {
                    if (TextBoxStatus.Text.ToString().Contains("IN PROGRESS"))
                    {
                        status = "INPR";
                    }
                    else if (TextBoxStatus.Text.ToString().Contains("FINISHED"))
                    {
                        status = "FINI";
                    }
                    else if (TextBoxStatus.Text.ToString().Contains("CANCELLED"))
                    {
                        status = "CANC";
                    }
                    else if (TextBoxStatus.Text.ToString().Contains("OPEN"))
                    {
                        status = "OPEN";
                    }
                }
            }
            catch (Exception ex) { }

            DataViewActivities.DataSource =
                    ActivitiesFacade.GetActivitiesDataTable(activityId, requestId, personelId, status, TextBoxActivityType.Text);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if(DataViewActivities.CurrentRow != null)
            {
                int activityId = (int)DataViewActivities.CurrentRow.Cells[0].Value;
                if (ActivitiesFacade.FindActivity(activityId, out DataLayer.Activity activity))
                {
                    var form = new Activity("EDIT",activity);
                    form.ShowDialog();
                    if(personel != null)
                        DataViewActivities.DataSource = ActivitiesFacade.GetActivitiesForWorker(personel);
                    else
                        DataViewActivities.DataSource = ActivitiesFacade.GetActivities();
                }

            }
            else
            {
                MessageBox.Show("Pick Acitivity !");
            }

        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            if (DataViewActivities.CurrentRow != null)
            {
                int activityId = (int)DataViewActivities.CurrentRow.Cells[0].Value;
                if (ActivitiesFacade.FindActivity(activityId, out DataLayer.Activity activity))
                {
                    var form = new Activity("VIEW", activity);
                    form.ShowDialog();
                    try
                    {
                        DataViewActivities.DataSource = ActivitiesFacade.GetActivitiesForWorker(personel);
                    }
                    catch (Exception ex) { }
                }

            }
            else
            {
                MessageBox.Show("Pick Acitivity !");
            }
        }

        private void DataViewActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
