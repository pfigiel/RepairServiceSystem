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
    public partial class Activity : Form
    {
        public Activity()
        {
            InitializeComponent();
        }

        public Activity(int requestId, string activityType, int personelId, int sequenceNumber, string description, string status, DateTime dateStart, DateTime dateFinCancel)
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
