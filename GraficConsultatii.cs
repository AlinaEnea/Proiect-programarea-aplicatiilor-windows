using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Cabinet_Medical

{
    public partial class GraficConsultatii : Form
    {
        List<Medic> listMedici;
        List<Inregistrare> listaVechime;
        List<Pacient> listaPacienti;

        const int margine = 10;

        int[] vectorCodMedici; /*vectorCodStudenti;  */
        double[] vectorMedii;//vectorStudenti

        bool incarcareDate = false;
        double[] vectorMediiVechime;//vectorMediiAni
        double[] vectorMediiNrConsultatii;//vectorMediiAniFacultate
        int nrElemente = 0;
        int nrMedii = 0; 

        Color color = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        public GraficConsultatii()
        {
            InitializeComponent();
        }

        public GraficConsultatii(List<Medic> medici, List<Inregistrare>vechime,List<Pacient>nrCabinet)
        {
            InitializeComponent();
            this.listMedici = medici;
            this.listaVechime = vechime;
            this.listaPacienti = nrCabinet;
            vectorCodMedici = new int[medici.Count];
            vectorMediiVechime = new double[vechime.Count];
           
            vectorMediiVechime = new double[vechime.Count];
            vectorMediiNrConsultatii = new double[3];
            
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
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

            for (int i = 0; i < vectorMediiVechime.Length; i++)
                Console.WriteLine("Vechime medie medic: {0:0.00}",
            vectorMediiVechime[i]);

            try
            {
                foreach (Medic vechime in listMedici)
                {
                    double sumaMedii = 0;
                    double nrMedici = 0;
                    foreach (Medic medic in listMedici)
                    {
                        if (vechime.CodMedic == medic.CodMedic)
                        {
                            sumaMedii += vectorMediiVechime[medic.CodMedic - 1];
                            nrMedici += 1;
                        }
                    }
                    vectorMediiVechime[nrMedii] = sumaMedii / nrMedici;
                    nrMedii++;
                    incarcareDate = true;

                }
                Console.WriteLine("VECHIMEA MEDIE A MEDICILOR:");
                for (int i = 0; i < vectorMediiVechime.Length; i++)
                    Console.WriteLine("Medie ani: {0:0.00}",
                vectorMediiVechime[i]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //   Invalidate();
            panel1.Invalidate();

        }

        //vectorMediiAni[nrMedii] 
        //nrMedi
        private void GraficConsultatii_Paint(object sender, PaintEventArgs e)
        {
            if(incarcareDate)
            {
                Graphics graphics = e.Graphics;
                Rectangle rectangle = new Rectangle(this.ClientRectangle.X+margine, this.ClientRectangle.Y+4*margine,
                    this.ClientRectangle.Width-2*margine, this.ClientRectangle.Height-5*margine);

                Pen pen = new Pen(Color.Purple, 3);
                graphics.DrawRectangle(pen, rectangle);

                //variabile de lucru locale
                double latime = rectangle.Width / nrMedii / 3;
                double distanta = (rectangle.Width - nrMedii * latime) / (nrMedii + 1);
                double elemMaxim = vectorMediiVechime.Max();

                Brush brush = new SolidBrush(color);
                Rectangle[] rectangles = new Rectangle[nrMedii];
                for(int i=0;i<nrMedii;i++)
                {
                    //x, y, latime, inaltime
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                       (int)(rectangle.Location.Y + rectangle.Height - vectorMediiVechime[i] / elemMaxim * rectangle.Height),
                       (int)latime,
                       (int)(vectorMediiVechime[i] / elemMaxim * rectangle.Height));

                    graphics.DrawString(vectorMediiVechime[i].ToString("0.00"),font, brush
                   , new Point((int)(rectangles[i].Location.X+latime/2), 
                   (int)(rectangles[i].Location.Y - font.Height)));
                }

              graphics.FillRectangles(brush, rectangles);


                for (int i = 0; i < nrMedii - 1; i++)
                {
                    graphics.DrawLine(pen, new Point((int)(rectangles[i].Location.X + latime / 2),
                             (int)(rectangles[i].Location.Y)),
                        new Point((int)(rectangles[i+1].Location.X + latime / 2), (int)(rectangles[i+1].Location.Y)));


                }
            }
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                color = dialog.Color;
                
            }
            // Invalidate();
            panel1.Invalidate();
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                font = dialog.Font;
            Invalidate();
        }

        private void save(Control control, string denumire)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bitmap, new Rectangle(control.ClientRectangle.X,
                control.ClientRectangle.Y, control.ClientRectangle.Width,
                control.ClientRectangle.Height));
            bitmap.Save(denumire);
            bitmap.Dispose();
        }
        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(panel1, "graficMedii.bmp");
            MessageBox.Show("S-a salvat!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (incarcareDate)
            {
                Graphics graphics = e.Graphics;
                Rectangle rectangle = new Rectangle(panel1.ClientRectangle.X + margine, panel1.ClientRectangle.Y + 2 * margine,
                   panel1.ClientRectangle.Width - 2 * margine, panel1.ClientRectangle.Height - 3 * margine);

                Pen pen = new Pen(Color.Red, 3);
                graphics.DrawRectangle(pen, rectangle);

                //variabile de lucru locale
                double latime = rectangle.Width / nrMedii / 3;
                double distanta = (rectangle.Width - nrMedii * latime) / (nrMedii + 1);
                double elemMaxim = vectorMediiVechime.Max();

                Brush brush = new SolidBrush(color);
                Rectangle[] rectangles = new Rectangle[nrMedii];
                for (int i = 0; i < nrMedii; i++)
                {
                    //x, y, latime, inaltime
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                       (int)(rectangle.Location.Y + rectangle.Height - vectorMediiVechime[i] / elemMaxim * rectangle.Height),
                       (int)latime,
                       (int)(vectorMediiVechime[i] / elemMaxim * rectangle.Height));

                    graphics.DrawString(vectorMediiVechime[i].ToString("0.00"), font, brush
                   , new Point((int)(rectangles[i].Location.X + latime / 2),
                   (int)(rectangles[i].Location.Y - font.Height)));
                }

                graphics.FillRectangles(brush, rectangles);


            }
        }
        private void Desenare(object sender, PrintPageEventArgs e)
        {
            if (incarcareDate)
            {
                Graphics graphics = e.Graphics;
                Rectangle rectangle = new Rectangle(e.PageBounds.X + margine, e.PageBounds.Y + 2 * margine,
                   e.PageBounds.Width - 2 * margine, e.PageBounds.Height - 3 * margine);

                Pen pen = new Pen(Color.Red, 3);
                graphics.DrawRectangle(pen, rectangle);

                //variabile de lucru locale
                double latime = rectangle.Width / nrMedii / 3;
                double distanta = (rectangle.Width - nrMedii * latime) / (nrMedii + 1);
                double elemMaxim = vectorMediiVechime.Max();

                Brush brush = new SolidBrush(color);
                Rectangle[] rectangles = new Rectangle[nrMedii];
                for (int i = 0; i < nrMedii; i++)
                {
                    //x, y, latime, inaltime
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                       (int)(rectangle.Location.Y + rectangle.Height - vectorMediiVechime[i] / elemMaxim * rectangle.Height),
                       (int)latime,
                       (int)(vectorMediiVechime[i] / elemMaxim * rectangle.Height));

                    graphics.DrawString(vectorMediiVechime[i].ToString("0.00"), font, brush
                   , new Point((int)(rectangles[i].Location.X + latime / 2),
                   (int)(rectangles[i].Location.Y - font.Height)));
                }

                graphics.FillRectangles(brush, rectangles);


                //for (int i = 0; i < nrMedii - 1; i++)
                //{
                //    graphics.DrawLine(pen, new Point((int)(rectangles[i].Location.X + latime / 2),
                //             (int)(rectangles[i].Location.Y)),
                //        new Point((int)(rectangles[i + 1].Location.X + latime / 2), (int)(rectangles[i + 1].Location.Y)));


                //}
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument print = new PrintDocument();
            print.PrintPage += new PrintPageEventHandler(Desenare);
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = print;
            dialog.ShowDialog();
           
        }

        private void GraficConsultatii_Load(object sender, EventArgs e)
        {

        }
    }
}
