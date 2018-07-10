using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_obsługi_napraw
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            // TODO: sprawdzić hash hasła z wpisem w bazie, boolean success infomuje o znalezieniu
            bool success = true;
            if(success)
            {
                // TODO: odczytać typ konta dla znalezionego użytkownika z bazy
                string accountType = "temp";
                switch(accountType)
                {
                    case "temp":

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
