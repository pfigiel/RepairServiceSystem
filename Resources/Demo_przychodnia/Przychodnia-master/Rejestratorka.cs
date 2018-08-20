using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;

namespace Przychodnia
{
    public partial class Rejestratorka : Form

    {

        Patient patientSearchCriteria;

        public Rejestratorka()
        {
            InitializeComponent();
            var results = BizzLayer.RegistrationFacade.GetPatients();
            textBox1.Text = results.First().FirstName;
        }

        private void viewPatients ()
        {
            // var result = RegistrationFacade.GetPatients(null);

            // budowa kryteriów
            patientSearchCriteria = new Patient();
            patientSearchCriteria.LastName = textBox1.Text;

            // ładowanie obiektu dataGridView
            dataGridView1.Columns.Clear();
            // dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = RegistrationFacade.GetPatients(patientSearchCriteria);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewPatients();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Rejestratorka_Load(object sender, EventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Brak pacjentów");
                return;
            }

            
            patientSearchCriteria = new Patient();
            patientSearchCriteria.IdPatient = (int) ( dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value); 



            if  (patientSearchCriteria.IdPatient == 0)
            {
                MessageBox.Show("Wybierz pacjenta");
                return;
            }
            else
            {
                MessageBox.Show(String.Format("Wybrano pacjenta o identyfikatorze {0}", patientSearchCriteria.IdPatient));

            }
            EdycjaPacjenta frmEdycjaPacjenta = new EdycjaPacjenta(patientSearchCriteria.IdPatient);
            DialogResult res =  frmEdycjaPacjenta.ShowDialog(this);
            // button1_Click(null, null); :) :)
            if (res == DialogResult.OK)
                viewPatients();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowVisists_Click(object sender, EventArgs e)
        {
            dataGridViewVisits.DataSource = DoctorFacade.GetVisits(null);
   
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
