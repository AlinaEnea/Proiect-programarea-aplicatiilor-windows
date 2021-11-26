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
    public partial class AddMedicForm : Form
    {
       //List <Student>studenti;
        Medic medic;
        public string mod = string.Empty;
        public AddMedicForm()
        {
            InitializeComponent();
        }

        public AddMedicForm(Medic medic)
        {
            InitializeComponent();
            this.medic = medic;
        
        }
        //public AddMedicForm(List<Medic> medici)
        //{
        //    InitializeComponent();
        //    this.medici = medici;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this.Hide();
          //  Medic medic=null;
            epMedicNume.SetError(txtNume, string.Empty);
            epMedicPrenume.SetError(txtPrenume, string.Empty);
            epMedicCodCabinet.SetError(txtCodCabinet, string.Empty);
            try
            {
                if (txtNume.Text =="")
                    throw new Exception("Nume");
                if (txtPrenume.Text =="")
                    throw new Exception("Prenume");
                if (!int.TryParse(txtCodCabinet.Text, out int value))
                {
                    throw new FormatException("CabinetString");
                }

                if (int.TryParse(txtCodCabinet.Text, out int value1) && value1 < 0)
                {
                    throw new FormatException("CabinetNegativ");
                }


                medic.Nume = txtNume.Text;
                medic.Prenume = txtPrenume.Text;
                medic.DataNasterii = DateTime.Parse(dateTimePicker.Value.ToString());
                medic.CodCabinet = int.Parse(txtCodCabinet.Text);

                //string nume = txtNume.Text;
                //    string prenume = txtPrenume.Text;
                //    DateTime dataNasterii = DateTime.Parse(dateTimePicker.Value.ToString());
                //    int codCabinet = int.Parse(txtCodCabinet.Text);

                //    medic= new Medic(nume, prenume, dataNasterii);




                this.Close();
            }
            catch (FormatException formex)
            {
                if (formex.Message.Equals("CabinetString"))
                {
                    epMedicCodCabinet.SetError(txtCodCabinet, "Cabinetul are un numar!");
                }
                if (formex.Message.Equals("CabinetNegativ"))
                {
                    epMedicCodCabinet.SetError(txtCodCabinet, "Numarul cabinetului nu trebuie sa fie negativ!");
                }

            }

            catch (Exception ex)
            {
                if(ex.Message.Equals("Nume"))
                    epMedicNume.SetError(txtNume, "Camp obligatoriu!");
                if (ex.Message.Equals("Prenume"))
                    epMedicPrenume.SetError(txtPrenume, "Camp obligatoriu!");
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }


        private void AddMedicForm_Load_1(object sender, EventArgs e)
        {
            if (mod.Equals("modificare"))
            {

                txtNume.Text = medic.Nume;
                txtPrenume.Text = medic.Prenume;
                dateTimePicker.Text = medic.DataNasterii.ToString();
                txtCodCabinet.Text = medic.CodCabinet.ToString();


            }
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodCabinet_Click(object sender, EventArgs e)
        {

        }

        private void txtCodCabinet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
