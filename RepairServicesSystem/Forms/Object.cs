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
    public partial class Object : Form
    {
        private Mode mode;
        private DataLayer.Object obj;
        public Object()
        {
            InitializeComponent();
        }
        public Object(Mode mode)
        {
            InitializeComponent();
            this.mode = mode;
        }
        public Object(Mode mode,DataLayer.Object obj)
        {
            InitializeComponent();
            this.mode = mode;
            this.obj = obj;
            TextBoxName.Text = obj.name.ToString();
            TextBoxNumberObj.Text = obj.nr_obj.ToString();
            TextBoxClientId.Text = obj.id_cli.ToString();
            if(obj.code_type.ToString().Contains("OPN"))
            {
                RBOPN.Checked = true;
            }
            else if(obj.code_type.ToString().Contains("FIN "))
            {
                RBFIN.Checked = true;
            }
            else if (obj.code_type.ToString().Contains("PRO "))
            {
                RBPRO.Checked = true;
            }
            else if (obj.code_type.ToString().Contains("CAN "))
            {
                RBCAN.Checked = true;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!TextBoxClientId.Text.Equals("") && !TextBoxName.Text.Equals("") && !TextBoxNumberObj.Equals(""))
            {
                DataLayer.Object obj = new DataLayer.Object()
                {
                    id_cli = int.Parse(TextBoxClientId.Text),
                    name = TextBoxName.Text,
                    nr_obj = int.Parse(TextBoxNumberObj.Text)
                };
                if (RBCAN.Checked)
                {
                    obj.code_type = "CAN";
                }
                else if (RBFIN.Checked)
                {
                    obj.code_type = "FIN";
                }
                else if (RBOPN.Checked)
                {
                    obj.code_type = "OPN";
                }
                else if (RBPRO.Checked)
                {
                    obj.code_type = "PRO";
                }
                if (this.obj != null)
                {
                    //ObjectFacade.DeleteObject(this.obj.nr_obj);
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
            var form = new Users(Mode.MANAGER);
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
            var form = new Requests(Mode.MANAGER);
            form.ShowDialog();
        }
    }
}
