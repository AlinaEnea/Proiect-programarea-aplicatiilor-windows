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
    public partial class SituatieCabinet : Form
    {
        List<Medic> listMedici;
        List<Inregistrare> listaVechime;
        List<Reteta> listaReteta;
        List<Pacient> listaPacienti;

        int[] vectorCodMedici;
        double[] vectorMediiVechime;
        int nrElemente = 0;
        const int marg = 10;
        public SituatieCabinet()
        {
            InitializeComponent();
        }

        public SituatieCabinet(List<Medic>medici,List<Inregistrare>vechime,List<Reteta>retete,
            List<Pacient>nrCabinet)
        {
            InitializeComponent();
            this.listMedici = medici;
            this.listaReteta = retete;
            this.listaVechime = vechime;
            this.listaPacienti = nrCabinet;
            vectorCodMedici = new int[medici.Count];
            vectorMediiVechime = new double[medici.Count];

            HideAll();

        }

       

        private void HideAll()
        {
            columnMedieChart.Hide();
            
        }

        private void SituatieCabinetMedical_Load(object sender, EventArgs e)
        {

        }

        

        private void Vechime_Medie(object sender, EventArgs e)
        {
            foreach (Medic medic in listMedici)
            {
                vectorCodMedici[nrElemente] = medic.CodMedic;
                double sumaVechime = 0;
                double sumaNrConsultatii = 0;
                foreach (Inregistrare vechime in listaVechime)
                {
                    if (medic.CodMedic == vechime.CodMedic)
                    {
                        sumaNrConsultatii += vechime.Vechime * vechime.NrConsultatii;
                        sumaVechime += vechime.NrConsultatii;
                    }
                }
                vectorMediiVechime[nrElemente] = sumaNrConsultatii / sumaVechime;
                nrElemente++;
            }

            columnMedieChart.Show();
            for (int i = 0; i < nrElemente; i++)
            {
                this.columnMedieChart.Series["Vechimea medie obtinuta de fiecare medic este : "].Points
                    .AddXY(vectorCodMedici[i], vectorMediiVechime[i]);
            }

            //for (int i = 0; i < vectorMediiVechime.Length; i++)
            //    Console.WriteLine( "Vechime medie: {0:0.00}",
            //vectorMediiVechime[i]);
        }

        private void printeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Data:" + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 270));
          
        }

        private void Grafic_Vechime(object sender, EventArgs e)
        {
            GraficConsultatii form = new GraficConsultatii(listMedici, listaVechime, listaPacienti);
            form.ShowDialog();
        }
    }
}
