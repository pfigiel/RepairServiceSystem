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
using static System_obsługi_napraw.Modes;

namespace RepairServicesSystem
{
    public partial class Object : Form
    {
        private Modes mode;
        private DataLayer.Object obj;

        public Object()
        {
            InitializeComponent();
            ButtonAddRequest.Visible = false;
            ButtonShowRequest.Visible = false;
            foreach (string objectTypeName in ObjectTypeFacade.GetObjectTypes())
            {
                ComboBoxObjectType.Items.Add(objectTypeName);
            }
        }
        public Object(Modes mode)
        {
            InitializeComponent();
            this.mode = mode;
            ButtonAddRequest.Visible = false;
            ButtonShowRequest.Visible = false;
            foreach (string objectTypeName in ObjectTypeFacade.GetObjectTypes())
            {
                ComboBoxObjectType.Items.Add(objectTypeName);
            }
        }
        public Object(Modes mode, DataLayer.Object obj)
        {
            InitializeComponent();
            this.mode = mode;
            this.obj = obj;
            SetControls(obj);
            ButtonAddRequest.Visible = false;
            ButtonShowRequest.Visible = false;
            foreach (string objectTypeName in ObjectTypeFacade.GetObjectTypes())
            {
                ComboBoxObjectType.Items.Add(objectTypeName);
            }
            if(mode == VIEW_ONLY)
            {
                DisableControls();
            }
        }

        private void SetControls(DataLayer.Object obj)
        {
            TextBoxName.Text = obj.name.ToString();
            TextBoxClientId.Text = obj.id_cli.ToString();
            ComboBoxObjectType.Text = ObjectTypeFacade.GetObjectNameByObjectType(obj.code_type);
        }
        private void DisableControls()
        {
            TextBoxName.Enabled = false;
            TextBoxClientId.Enabled = false;
            ButtonSearchClient.Enabled = false;
            ButtonSave.Enabled = false;
            ComboBoxObjectType.Enabled = false;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!TextBoxClientId.Text.Equals("") && !TextBoxName.Text.Equals(""))
            {
                DataLayer.Object obj = new DataLayer.Object()
                {
                    id_cli = int.Parse(TextBoxClientId.Text),
                    name = TextBoxName.Text,
                    code_type = ObjectTypeFacade.GetObjectTypeByObjectName(ComboBoxObjectType.Text)
                };
                if (this.obj != null)
                {
                    obj.nr_obj = this.obj.nr_obj;
                    ObjectFacade.UpdateObject(obj);
                }
                else
                {
                    ObjectFacade.AddObject(obj);
                }
                Close();
            }
        }

        private void ButtonSearchClient_Click(object sender, EventArgs e)
        {
            var form = new Users(MANAGER);
            form.ShowDialog();
            TextBoxClientId.Text = form.UserId.ToString();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAddRequest_Click(object sender, EventArgs e)
        {
            var form = new Request();
            form.ShowDialog();
        }

        private void ButtonShowRequest_Click(object sender, EventArgs e)
        {
            var form = new Requests(MANAGER);
            form.ShowDialog();
        }

      
    }
}
