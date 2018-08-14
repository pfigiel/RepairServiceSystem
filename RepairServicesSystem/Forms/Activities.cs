using BusinessLayer;
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
        private string userType;

        public Activities(string userType)
        {
            InitializeComponent();
            this.userType = userType;
            ActivitiesFacade.GetActivitiesDataTable(0, 0, 0, "", "");
            if(userType.Equals("WORKER"))
            {
                ButtonBack.Enabled = false;
            }
            RefreshDataView();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var activity = new Activity();
            activity.ShowDialog();
        }

        public void RefreshDataView()
        {
            int activityId = 0, requestId = 0, personelId = 0;
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
            }
            catch (Exception ex) { }

            DataViewActivities.DataSource =
                    ActivitiesFacade.GetActivitiesDataTable(activityId, requestId, personelId, TextBoxStatus.Text, TextBoxActivityType.Text);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
