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
using System_obsługi_napraw;

namespace RepairServicesSystem
{
    public partial class Activities : Form
    {
        private Personel personel;
        private Modes mode;
        private int reqId;
        private Dictionary<string, string> statusDict;

        public Activities(Modes mode, int id)
        {
            InitializeComponent();
            this.mode = mode;
            reqId = id;

            switch(mode)
            {
                case Modes.WORKER:
                    ButtonBack.Enabled = false;
                    ButtonAdd.Enabled = false;
                    break;
                case Modes.VIEW_ONLY:
                    ButtonAdd.Enabled = false;
                    TextBoxRequestId.Text = reqId.ToString();
                    TextBoxRequestId.Enabled = false;
                    DataViewActivities.DataSource = ActivitiesFacade.GetActivitiesDataTable(0, reqId, 0, "", "");
                    break;
                default: break;
            }
        }

        public Activities(Personel personel)
        {
            InitializeComponent();
            this.personel = personel;
            ButtonBack.Enabled = false;

            if(personel.role.Equals("WORKER"))
            {
                ButtonAdd.Enabled = false;
                ButtonBack.Enabled = false;
                TextBoxPersonelId.Text = personel.id_pers.ToString();
                TextBoxPersonelId.Enabled = false;

            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
            foreach(string activityType in ActivityTypeFacade.GetActivityTypes())
            {
                ComboBoxActivityType.Items.Add(activityType);
            }
            ComboBoxStatus.Items.AddRange(new string[] { "IN PROGRESS", "FINISHED", "CANCELLED", "OPEN" });
            statusDict = new Dictionary<string, string>();
            statusDict.Add("IN PROGRESS", "INPR");
            statusDict.Add("FINISHED", "FINI");
            statusDict.Add("CANCELLED", "CANC");
            statusDict.Add("OPEN", "OPEN");
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var activity = new Activity();
            activity.ShowDialog();
            if (personel != null && personel.role.Equals("WORKER"))
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
                if (TextBoxActivityId.Text.Any()) activityId = Int32.Parse(TextBoxActivityId.Text);
                if (TextBoxRequestId.Text.Any()) requestId = Int32.Parse(TextBoxRequestId.Text);
                if (TextBoxPersonelId.Text.Any()) personelId = Int32.Parse(TextBoxPersonelId.Text);
                if (ComboBoxStatus.Text.Any())
                {
                    status = statusDict[ComboBoxStatus.Text];
                }
            }
            catch (Exception ex) { }

            DataViewActivities.DataSource =
                    ActivitiesFacade.GetActivitiesDataTable(activityId, requestId, personelId, status, ComboBoxActivityType.Text);
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
                    var form = new Activity(Modes.EDIT, activity);
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
                    var form = new Activity(Modes.VIEW_ONLY, activity);
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
