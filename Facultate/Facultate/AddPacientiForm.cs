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
    public partial class AddPacientiForm : Form
    {
        Pacient pacient;
        public string mod = String.Empty;

        public AddPacientiForm()
        {
            InitializeComponent();
        }

        public AddPacientiForm(Pacient pacient)
        {
            InitializeComponent();
            this.pacient = pacient;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            epCodPacient.SetError(txtCodPacient, string.Empty);
            epNrCabinet.SetError(cbNrCabinet, string.Empty);
             epStatut.SetError(cbStatut, string.Empty);
            epMediu.SetError(cbMediu, string.Empty);
            try
            {
                if (!int.TryParse(txtCodPacient.Text, out int value))
                    throw new FormatException("CodPacientString");
                if (!int.TryParse(cbNrCabinet.Text, out int value1))
                    throw new FormatException("NrCabinetString");
                if (txtCodPacient.Text == "")
                    throw new Exception("CodPacient");
                if (cbNrCabinet.Text == "")
                    throw new Exception("NrCabinet");
                if (cbStatut.Text == "")
                    throw new Exception("Statut");
                if (cbMediu.Text == "")
                    throw new Exception("Mediu");

                //anStudiu = new AnStudiu(int.Parse(txtCodAn.Text), 
                //    int.Parse(cbAnStud.Text), cbSpecializare.Text, cbFrecventa.Text);
                pacient.CodPacient = int.Parse(txtCodPacient.Text);
                pacient.NrCabinet = int.Parse(cbNrCabinet.Text);
                pacient.Statut = cbStatut.Text;
                pacient.Mediu = cbMediu.Text;
                this.Close();
            }
            catch(FormatException formex)
            {
                if (formex.Message.Equals("CodPacientString"))
                    epCodPacient.SetError(txtCodPacient, "Codul pacientului trebuie sa fie un numar!");
                if (formex.Message.Equals("NrCabinetString"))
                    epNrCabinet.SetError(cbNrCabinet, "Numarul cabineteului trebuie sa fie un numar!");
            }
            catch(Exception ex)
            {
                if (ex.Message.Equals("CodPacient"))
                    epCodPacient.SetError(txtCodPacient, "Camp obligatoriu!");
                if (ex.Message.Equals("NrCabinet"))
                    epNrCabinet.SetError(cbNrCabinet, "Camp obligatoriu!");
                if (ex.Message.Equals("Statut"))
                    epStatut.SetError(cbStatut, "Camp obligatoriu!");
                if (ex.Message.Equals("Mediu"))
                    epMediu.SetError(cbMediu, "Camp obligatoriu!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPacientiForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCodPacient_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbNrCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbStatut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMediu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
