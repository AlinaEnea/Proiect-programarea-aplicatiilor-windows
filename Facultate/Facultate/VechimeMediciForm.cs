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
    public partial class VechimeMediciForm : Form
    {
       
        List<Inregistrare> listaVechime;
        List<Reteta> listaRetete;
        List<Medic> listaMedici;
        List<Pacient> listaNrCabinet;



        public VechimeMediciForm()
        {
            InitializeComponent();
           
        }

        public VechimeMediciForm(List<Medic> medici, List<Reteta> retete, List<Inregistrare> vechime,List<Pacient> nrCabinet)
        {
            InitializeComponent();
            this.listaMedici = medici;
            this.listaVechime = vechime;
            this.listaRetete = retete;
            this.listaNrCabinet = nrCabinet;

            listViewVechimeMedici.View = View.Details;
            listViewVechimeMedici.Columns.Add("Cod", 50);
            listViewVechimeMedici.Columns.Add("Nume", 80);
            listViewVechimeMedici.Columns.Add("Prenume", 80);
            listViewVechimeMedici.Columns.Add("Reteta", 80);
            listViewVechimeMedici.Columns.Add("Vechime", 50);
            listViewVechimeMedici.Columns.Add("NrCabinet", 70);
            listViewVechimeMedici.Columns.Add("Promovat", 70);
            this.Controls.Add(listViewVechimeMedici);
            PopuleazaListViewVechime(listaVechime, listaMedici, listaRetete);
            foreach(Reteta reteta in listaRetete)
            {
                Console.WriteLine(reteta.ToString());
            }

        }

        public void PopuleazaListViewVechime(List<Inregistrare> listaVechime,List<Medic> listaMedici,List<Reteta> listaRetete)
        {
            //listViewNote.Items.Clear();

            foreach (Inregistrare inregistrare in listaVechime)
            {
                ListViewItem rand = new ListViewItem();
                rand.Text = inregistrare.CodInreg.ToString();
                foreach (Medic medic in listaMedici)
                {
                    if (inregistrare.CodMedic == medic.CodMedic)
                    {
                        rand.SubItems.Add(medic.Nume);
                        rand.SubItems.Add(medic.Prenume);
                        break;
                    }

                }

                foreach (Reteta reteta in listaRetete)
                {
                    if (inregistrare.CodReteta == reteta.CodReteta)
                    {
                        rand.SubItems.Add(reteta.Medicamente);
                        break;
                    }
                }
                rand.SubItems.Add(inregistrare.Vechime.ToString());
                rand.SubItems.Add(inregistrare.NrConsultatii.ToString());
                rand.SubItems.Add(inregistrare.Activ.ToString());

                listViewVechimeMedici.Items.Add(rand);
                rand.Tag = inregistrare;
            }
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal form = new FormPrincipal(listaMedici,listaRetete,listaNrCabinet,listaVechime);
            form.ShowDialog();
            this.Close();
        }

        private void listViewNote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NoteStudentiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
