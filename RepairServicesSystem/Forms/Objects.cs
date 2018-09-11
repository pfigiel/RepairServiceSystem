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
    public partial class Objects : Form
    {
        private Modes mode;
        public int nr_obj { get; set; }

        public Objects(Modes mode)
        {
            InitializeComponent();

            if (mode == WORKER || mode == VIEW_ONLY)
            {
                ButtonAddObject.Enabled = false;
                ButtonEditObject.Enabled = false;
                ButtonGoToRequests.Enabled = false;
            }
            else ButtonSelectObject.Enabled = false;

            this.mode = mode;
            foreach (string objectTypeName in ObjectTypeFacade.GetObjectTypes())
            {
                ComboBoxObjectType.Items.Add(objectTypeName);
            }
            groupBox1.Visible = false;
        }

        private void ButtonSearchClient_Click(object sender, EventArgs e)
        {
            var form = new Users(mode);
            form.ShowDialog();
            TextBoxClientId.Text = form.UserId.ToString();
        }

        private void ButtonAddObject_Click(object sender, EventArgs e)
        {
            var form = new Object(mode);
            form.ShowDialog();
            DataViewObjects.DataSource = ObjectFacade.GetObjectsDataTable();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int id = 0;
            String name ="", typeName = "";
            try
            {
                if(TextBoxClientId.Text.Any()) id = int.Parse(TextBoxClientId.Text);
                name = TextBoxName.Text;
                typeName = ComboBoxObjectType.Text;
            }
            catch(Exception ex)
            {

            }
            string codeType = ObjectTypeFacade.GetObjectTypeByObjectName(typeName);
            DataViewObjects.DataSource = ObjectFacade.GetObjectsDataTable(id, name, codeType);
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
            nr_obj = (int)DataViewObjects.CurrentRow.Cells[0].Value;
        }

        private void ButtonEditObject_Click(object sender, EventArgs e)
        {
            if(DataViewObjects.CurrentRow != null)
            {
                int objId = (int)DataViewObjects.CurrentRow.Cells[0].Value;
                if(ObjectFacade.FindObject(objId,out DataLayer.Object obj))
                {
                    var form = new Object(this.mode, obj);
                    form.ShowDialog();
                    DataViewObjects.DataSource = ObjectFacade.GetObjectsDataTable();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            if (DataViewObjects.CurrentRow != null)
            {
                int objId = (int)DataViewObjects.CurrentRow.Cells[0].Value;
                if (ObjectFacade.FindObject(objId, out DataLayer.Object obj))
                {
                    var form = new Object(VIEW_ONLY, obj);
                    form.ShowDialog();
                    DataViewObjects.DataSource = ObjectFacade.GetObjectsDataTable();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Requests(mode);
            form.FormClosing += delegate { this.Close(); };
            form.Show();
            Hide();
        }

        private void AddReqBtn_Click(object sender, EventArgs e)
        {
            var form = new Request();
            form.ShowDialog();
        }

        private void ButtonSelectObject_Click(object sender, EventArgs e)
        {
            try { nr_obj = (int)DataViewObjects.CurrentRow.Cells[0].Value; }
            catch (Exception ex) { nr_obj = 0; }
            Close();
        }
    }
}
