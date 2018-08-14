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

namespace RepairServicesSystem
{
    public partial class Objects : Form
    {
        private Mode mode;

        public Objects(Mode mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        private void ButtonSearchClient_Click(object sender, EventArgs e)
        {
            var form = new Users(mode);
            form.ShowDialog();
            TextBoxClientId.Text = form.UserId.ToString();
        }

        private void ButtonAddObject_Click(object sender, EventArgs e)
        {
            var form = new Object();
            form.ShowDialog();
        }
    }
}
