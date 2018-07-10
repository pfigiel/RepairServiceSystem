using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer;

namespace Przychodnia
{
    public partial class EdycjaPacjenta : Form
    {
        public EdycjaPacjenta()
        {
            InitializeComponent();
        }

        private int patientId;
        private Patient searchCrit;
        //private Patient PatientDTO;

        public EdycjaPacjenta(int Id):this ()
        {
            patientId = Id;
        }


        private void viewPatient()
        {

           Patient searchCrit  = new Patient () ;
           searchCrit.IdPatient = patientId ;
           IQueryable<Patient> patList = RegistrationFacade.GetPatients(searchCrit);
           Patient patientDTO = patList.SingleOrDefault();
           textBox4.Text = patientDTO.FirstName;
           textBox1.Text = patientDTO.LastName;
        }

        private void validatePatient()
        {

        }

        private void EdycjaPacjenta_Load(object sender, EventArgs e)
        {
            viewPatient();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validatePatient();
            Patient patientDTO = new Patient();
            patientDTO.IdPatient = patientId;
            patientDTO.FirstName = textBox4.Text;
            patientDTO.LastName = textBox1.Text;
            RegistrationFacade.UpdatePatientData(patientDTO);
            // viewPatient();
            //(Form)this.Parent.
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EdycjaPacjenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
