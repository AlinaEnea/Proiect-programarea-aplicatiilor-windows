using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Medical
{
    public partial class AddVechimeMediciForm : Form
    {
        Inregistrare inregistrare;
        List<Medic> listaMedici = new List<Medic>();
        List<Reteta> listaRetete = new List<Reteta>();
        public string mod = string.Empty;

        public AddVechimeMediciForm()
        {
            InitializeComponent();
        }

        public AddVechimeMediciForm(Inregistrare inregistrare)
        {
            InitializeComponent();
            this.inregistrare = inregistrare;
        }

        public AddVechimeMediciForm(List<Medic>listaMedici)
        {
            InitializeComponent();
            this.listaMedici = listaMedici;
        }

        public AddVechimeMediciForm(List<Reteta>listaRetete)
        {
            InitializeComponent();
            this.listaRetete = listaRetete;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            epCodReteta.SetError(txtCodReteta, string.Empty);
            epCodMedic.SetError(txtCodMedic, string.Empty);
            epVechime.SetError(txtVechime, string.Empty);
            epNrConsultatii.SetError(txtNrConsultatii, string.Empty);

            try
            {
                if(!int.TryParse(txtCodReteta.Text,out int value))
                {
                    throw new FormatException("CodRetetaFormat");
                }

                if (!int.TryParse(txtCodMedic.Text, out int value1))
                {
                    throw new FormatException("CodMedicFormat");
                }

                if (!int.TryParse(txtVechime.Text, out int value2))
                {
                    throw new FormatException("VechimeFormat");
                }

                if (!int.TryParse(txtNrConsultatii.Text, out int value3))
                {
                    throw new FormatException("NrConsultatiiFormat");
                }
                inregistrare.CodReteta =int.Parse(txtCodReteta.Text);
                inregistrare.CodMedic = int.Parse(txtCodMedic.Text);
                inregistrare.Vechime = int.Parse(txtVechime.Text);
                inregistrare.NrConsultatii = int.Parse(txtNrConsultatii.Text);


                if (ckbActiv.Checked)
                    inregistrare.Activ = true;
                else
                    inregistrare.Activ = false;

                this.Close();
            }
            catch(FormatException formex)
            {
                if (formex.Message.Equals("CodRetetaFormat"))
                    epCodReteta.SetError(txtCodReteta, "Codul retetei este un numar");
                if (formex.Message.Equals("CodMedicFormat"))
                    epCodMedic.SetError(txtCodMedic, "Codul Medicului este un numar");
                if (formex.Message.Equals("VechimeFormat"))
                    epVechime.SetError(txtVechime, "Vechimea medicului este un numar");
                if (formex.Message.Equals("NrConsultatiiFormat"))
                    epNrConsultatii.SetError(txtNrConsultatii, "Numarul de consultatii este un numar");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodMedic_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVechimeForm_Load(object sender, EventArgs e)
        {

        }

        private void txtCodReteta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVechime_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbActiv_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
