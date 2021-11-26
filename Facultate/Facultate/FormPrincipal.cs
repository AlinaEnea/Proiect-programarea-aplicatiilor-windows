using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Medical
{
    public partial class FormPrincipal : Form
    {
        
        ListView listViewMedici=new ListView();
        ListView listViewRetete=new ListView();
        ListView listViewNrCabinet = new ListView();
        ListView listViewVechime = new ListView();

        Button btnAddMedic=new Button();
        Button btnRmvMedic=new Button();

        Button btnAddReteta = new Button();
        Button btnRmvReteta = new Button();

        Button btnAddNrCabinet = new Button();
        Button btnRmvNrCabinet = new Button();

        Button btnAddVechime = new Button();
        Button btnRmvVechime = new Button();

        List<Medic> listaMedici = new List<Medic>();
        List<Reteta> listaRetete = new List<Reteta>();
        List<Pacient> listaNrCabinet = new List<Pacient>();
        List<Inregistrare> listaVechime = new List<Inregistrare>();
        public FormPrincipal()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        public FormPrincipal(List<Medic> listaMedici,List<Reteta> listaRetete,List<Pacient> listaNrCabinet,List<Inregistrare>listaVechime)
        {
            //initializare atribute
            InitializeComponent();
            
            this.listaMedici = listaMedici;
            this.listaRetete = listaRetete;
            this.listaVechime = listaVechime;
            this.listaNrCabinet = listaNrCabinet;

           
            VechimeMediciForm form = new VechimeMediciForm(listaMedici, listaRetete, listaVechime,listaNrCabinet);
            initializeazaListView(listViewMedici,500,300);
            listViewMedici.DoubleClick += listViewMedici_DoubleClick;
            listViewMedici.ContextMenuStrip = contextMenuStrip1;

            initializeazaListView(listViewRetete,350,300);
            listViewRetete.DoubleClick += ListViewRetete_DoubleClick;
            listViewRetete.SelectedIndexChanged += ListViewRetete_SelectedIndexChanged;

            initializeazaListView(listViewNrCabinet, 400, 300);
            listViewNrCabinet.DoubleClick += ListViewNrCabinet_DoubleClick;

            initializeazaListView(listViewVechime, 310, 300);
            listViewVechime.DoubleClick += ListViewVechime_DoubleClick1;


            //butoane medici
            initializeazaButoane(btnAddMedic, btnRmvMedic);
            Controls.Add(btnAddMedic);
            Controls.Add(btnRmvMedic);
            btnAddMedic.Click += btnAddMedic_Click;
            btnRmvMedic.Click += btnRmvMedic_Click;

            //butoane Retete
            initializeazaButoane(btnAddReteta, btnRmvReteta);
            Controls.Add(btnAddReteta);
            Controls.Add(btnRmvReteta);
            btnAddReteta.Click += BtnAddReteta_Click;
            btnRmvReteta.Click += BtnRmvReteta_Click;

            //butoane Numar cabinet
            initializeazaButoane(btnAddNrCabinet, btnRmvNrCabinet);
            Controls.Add(btnAddNrCabinet);
            Controls.Add(btnRmvNrCabinet);
            btnAddNrCabinet.Click += BtnAddNrCabinet_Click;
            btnRmvNrCabinet.Click += BtnRmvNrCabinet_Click;

            //butoane Note
            initializeazaButoane(btnAddVechime, btnRmvVechime);
            Controls.Add(btnAddVechime);
            Controls.Add(btnRmvVechime);
            btnAddVechime.Click += BtnAddVechime_Click;
            btnRmvVechime.Click += BtnRmvVechime_Click;


            //Adaugare coloane medici
            listViewMedici.View = View.Details;
            listViewMedici.BackColor = ColorTranslator.FromHtml("#FAFAEC");
            listViewMedici.Columns.Add("Cod", 50);
            // listViewMedici.
            listViewMedici.Columns.Add("Nume", 120);
            listViewMedici.Columns.Add("Prenume", 120);
            listViewMedici.Columns.Add("DataNasterii", 150);
            listViewMedici.Columns.Add("CodMedic", 50);


            //Adaugare coloane Retete
            listViewRetete.View = View.Details;
            listViewRetete.Columns.Add("Cod", 50);
            listViewRetete.Columns.Add("Medicamente", 150);
            listViewRetete.Columns.Add("Tip Reteta", 150);


            //Adauagare coloane Pacienti
            listViewNrCabinet.View = View.Details;
            listViewNrCabinet.Columns.Add("CodPacient", 50);
            listViewNrCabinet.Columns.Add("NrCabinet", 50);
            listViewNrCabinet.Columns.Add("Statut", 150);
            listViewNrCabinet.Columns.Add("Mediu", 150);

            //Adaugare coloane Vechime
            listViewVechime.View = View.Details;
            listViewVechime.Columns.Add("CodInreg", 50);
            listViewVechime.Columns.Add("CodReteta", 50);
            listViewVechime.Columns.Add("CodMedic", 50);
            listViewVechime.Columns.Add("Vechime", 50);
            listViewVechime.Columns.Add("NrConsultatii", 50);
            listViewVechime.Columns.Add("Activ", 60);

            PopulareListViewMedici(listaMedici);
            PopulareListViewRetete(listaRetete);
            PopulareListViewNrCabinet(listaNrCabinet);
            PopulareListViewVechime(listaVechime);
            HideAll();
        }

        private void ListViewVechime_DoubleClick1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAddVechime_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ListViewRetete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRetete.SelectedItems.Count != 0)
            {
                ListViewItem randSelectat = listViewRetete.SelectedItems[0];
                string obj = ((Reteta)randSelectat.Tag).Medicamente;
                Console.WriteLine(obj);

                if (obj != null)
                {
                    listViewRetete.DoDragDrop(obj, DragDropEffects.Copy);
                }
            }
        }

        private void BtnRmvVechime_Click(object sender, EventArgs e)
        {
            ListViewItem randSelectat = listViewVechime.SelectedItems[0];

            foreach(Inregistrare inregistrare in listaVechime)
            {
                if(inregistrare==(Inregistrare)randSelectat.Tag)
                {
                    listaVechime.Remove(inregistrare);
                    PopulareListViewVechime(listaVechime);
                    break;
                }
            }
        }

        private void BtnAddvechime_Click(object sender, EventArgs e)
        {
            Inregistrare inregistrare = new Inregistrare();
            AddVechimeMediciForm addNotaForm = new AddVechimeMediciForm(inregistrare);
            addNotaForm.mod = "adaugare";
            addNotaForm.ShowDialog();

            if(inregistrare.CodReteta>0)
            {
               
                listaVechime.Add(inregistrare);
                PopulareListViewVechime(listaVechime);
            }
        }

        private void ListViewNrCabinet_DoubleClick1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAddNrCabinet_Click(object sender, EventArgs e)
        {
            Pacient nrCabinet = new Pacient();
            AddPacientiForm formNrCabinet = new AddPacientiForm(nrCabinet);
            formNrCabinet.mod = "adaugare";
            formNrCabinet.ShowDialog();

            if (nrCabinet.CodPacient != 0)
            {
                listaNrCabinet.Add(nrCabinet);
                PopulareListViewNrCabinet(listaNrCabinet);
            }
        }

        private void BtnRmvNrCabinet_Click(object sender, EventArgs e)
        {
            
            ListViewItem randSelectat = listViewNrCabinet.SelectedItems[0];
            foreach(Pacient nr in listaNrCabinet)
            {
                if(nr==(Pacient)randSelectat.Tag)
                {
                    listaNrCabinet.Remove(nr);
                    PopulareListViewNrCabinet(listaNrCabinet);
                    break;
                }
            }
        }

      

        private void ListViewNrCabinet_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnRmvReteta_Click(object sender, EventArgs e)
        {
           
            ListViewItem randSelectat = listViewRetete.SelectedItems[0];

            foreach(Reteta reteta in listaRetete)
            {
                if(reteta == (Reteta)randSelectat.Tag)
                {
                    listaRetete.Remove(reteta);
                    PopulareListViewRetete(listaRetete);
                    break;
                }
            }


        }

        private void BtnAddReteta_Click(object sender, EventArgs e)
        {
            Reteta reteta = new Reteta();
            AddRetetaForm addReteta = new AddRetetaForm(reteta);
          
            addReteta.ShowDialog();

            if(reteta.Medicamente!="")
            {
                listaRetete.Add(reteta);
                
               
                PopulareListViewRetete(listaRetete);
            }
        }

        private void ListViewRetete_DoubleClick(object sender, EventArgs e)
        {
            Reteta reteta = (Reteta)listViewRetete.SelectedItems[0].Tag;

            AddRetetaForm addReteta = new AddRetetaForm(reteta);
            addReteta.mod = "modificare";
            addReteta.ShowDialog();


            PopulareListViewRetete(listaRetete);
        }

        public void initializeazaListView(ListView listView,int width,int height)
        {
           
            listView.FullRowSelect = true;
            listView.MultiSelect = false;
            listView.Bounds = new Rectangle(new Point(30, 30), new Size(width, height));
            listView.AutoArrange = true;
            this.Controls.Add(listView);
            listView.Top = 40;

        }
        public void initializeazaButoane(Button btnAdd, Button btnRmv)
        {
            btnAdd.Width = 100;
            btnAdd.Height = 50;
            btnAdd.Top = 200;
            btnAdd.Left = 575;
            btnAdd.Text = "Adauga";


            btnAdd.BackColor = ColorTranslator.FromHtml("#940057");
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#6C0962");
            btnAdd.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#FF78AB");

            btnRmv.Width = 100;
            btnRmv.Height = 50;
            btnRmv.Top = 100;
            btnRmv.Left = 575;
            btnRmv.Text = "Sterge";
            btnRmv.BackColor = ColorTranslator.FromHtml("#940057");
            btnRmv.FlatStyle = FlatStyle.Flat;
            btnRmv.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#6C0962");
            btnRmv.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#FF78AB");
        }
        private void HideAll()
        {
            listViewMedici.Hide();
            btnAddMedic.Hide();
            btnRmvMedic.Hide();

            listViewRetete.Hide();
            btnAddReteta.Hide();
            btnRmvReteta.Hide();

            listViewNrCabinet.Hide();
            btnAddNrCabinet.Hide();
            btnRmvNrCabinet.Hide();

            listViewVechime.Hide();
            btnAddVechime.Hide();
            btnRmvVechime.Hide();

           

        }

        public void PopulareListViewMedici(List<Medic> listMedici)
        {
            listViewMedici.Items.Clear();

            foreach(Medic medic in listMedici)
            {
                ListViewItem rand = new ListViewItem();
                rand.Text = medic.CodMedic.ToString();
                rand.SubItems.Add(medic.Nume);
                rand.SubItems.Add(medic.Prenume);
                rand.SubItems.Add(medic.DataNasterii.ToShortDateString());
                rand.SubItems.Add(medic.CodMedic.ToString());

                listViewMedici.Items.Add(rand);

                rand.Tag = medic;
            }
        }

        public void PopulareListViewRetete(List<Reteta> listaRetete)
        {
            listViewRetete.Items.Clear();

            foreach(Reteta reteta in listaRetete)
            {
                ListViewItem rand = new ListViewItem();
                rand.Text = reteta.CodReteta.ToString();
                rand.SubItems.Add(reteta.Medicamente);
                rand.SubItems.Add(reteta.Tip_Reteta);

                listViewRetete.Items.Add(rand);

                rand.Tag = reteta;
            }
                
        }

        public void PopulareListViewNrCabinet(List<Pacient> listaNrCabinet)
        {
            listViewNrCabinet.Items.Clear();

            foreach(Pacient pacient in listaNrCabinet)
            {
                ListViewItem rand = new ListViewItem();
                rand.Text = pacient.CodPacient.ToString();
                rand.SubItems.Add(pacient.NrCabinet.ToString());
                rand.SubItems.Add(pacient.Statut);
                rand.SubItems.Add(pacient.Mediu);

                listViewNrCabinet.Items.Add(rand);
                rand.Tag = pacient;
            }
        }
        private void PopulareListViewVechime(List<Inregistrare> listaVechime)
        {
            listViewVechime.Items.Clear();

            foreach(Inregistrare inregistrare in listaVechime)
            {
                ListViewItem rand = new ListViewItem();
                rand.Text = inregistrare.CodInreg.ToString();
                rand.SubItems.Add(inregistrare.CodReteta.ToString());
                rand.SubItems.Add(inregistrare.CodMedic.ToString());
                rand.SubItems.Add(inregistrare.Vechime.ToString());
                rand.SubItems.Add(inregistrare.NrConsultatii.ToString());
                rand.SubItems.Add(inregistrare.Activ.ToString());

                listViewVechime.Items.Add(rand);
                rand.Tag = inregistrare;
            }

            
        }
        private void btnAddMedic_Click(object sender, EventArgs e)
        {
          //  this.Hide();
            Medic medic= new Medic();
         
            AddMedicForm addMedic = new AddMedicForm(medic);
            addMedic.mod="adaugare";
            addMedic.ShowDialog();
            
            if(medic.CodCabinet!=0)
            {
                listaMedici.Add(medic);
             
             
                PopulareListViewMedici(listaMedici);

            }
            
         
        }

        private void btnRmvMedic_Click(object sender, EventArgs e)
        {

            ListViewItem randSelectat = listViewMedici.SelectedItems[0];
            foreach (Medic medic in listaMedici)
            {
                if (medic== ((Medic)randSelectat.Tag))
                {
                    listaMedici.Remove(medic);
                    PopulareListViewMedici(listaMedici);
                    break;
                }
            }

        }

        private void listViewMedici_DoubleClick(object sender, EventArgs e)
        {
            Medic medic = new Medic();
            ListViewItem randSelectat = listViewMedici.SelectedItems[0];

           medic = (Medic)randSelectat.Tag;

            AddMedicForm form = new AddMedicForm(medic);
            form.mod = "modificare";
            form.ShowDialog();
            
            PopulareListViewMedici(listaMedici);
        }

        private void mediciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            listViewMedici.Show();
            btnAddMedic.Show();
            btnRmvMedic.Show();

            PopulareListViewMedici(listaMedici);
        }

        private void ReteteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            listViewRetete.Show();
            btnAddReteta.Show();
            btnRmvReteta.Show();
            
        }

        private void vechimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            listViewVechime.Show();
            btnAddVechime.Show();
            btnRmvVechime.Show();
            
        }

        private void bazededateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            listViewVechime.Show();
            btnAddVechime.Show();
            btnRmvVechime.Show();
            lblMedie.Show();
            lblMedie.Text = string.Format("Vechimea medie {0:0.00}", MedieCabinet(listaVechime));
        }

        private void veziDateCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VechimeMediciForm vechimeMediciForm = new VechimeMediciForm(listaMedici,listaRetete,listaVechime,listaNrCabinet);
            vechimeMediciForm.ShowDialog();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medic medic = new Medic();
            ListViewItem randSelectat = listViewMedici.SelectedItems[0];

            medic = (Medic)randSelectat.Tag;

            AddMedicForm form = new AddMedicForm(medic);
            form.mod = "modificare";
            form.ShowDialog();

            PopulareListViewMedici(listaMedici);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem randSelectat = listViewMedici.SelectedItems[0];
          
            foreach (Medic medic in listaMedici)
            {
                if (medic == ((Medic)randSelectat.Tag))
                {
                    var rezultat = MessageBox.Show(this,
                   $"Sunteți sigur că doriți ștergerea medicului   {medic.Nume} {medic.Prenume}?",
                    "Ștergere Medic",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                    if (rezultat == DialogResult.Yes)
                    {
                        listaMedici.Remove(medic);
                        PopulareListViewMedici(listaMedici);
                        break;
                    }
                    
                }
            }
        }

        private void fundalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem randSelectat = listViewMedici.SelectedItems[0];
            using (ColorDialog color = new ColorDialog())
            {
                if (color.ShowDialog() == DialogResult.OK)
                    randSelectat.BackColor = color.Color;
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListViewItem randSelectat = listViewMedici.SelectedItems[0];
            using (ColorDialog color = new ColorDialog())
            {
                if (color.ShowDialog() == DialogResult.OK)
                    randSelectat.ForeColor = color.Color;
            }
        }

        private void incarcaDateDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    incarcaDateDinFisier("dateMedici.txt");
            //    PopulareListViewMedici(listaMedici);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fisiete text (*.txt)|*.txt|Toate fisierele(*.*)|*.*";
            if(openFileDialog.ShowDialog(this)==DialogResult.OK)
            {
                incarcaDateDinFisier(openFileDialog.FileName);
                PopulareListViewMedici(listaMedici);
            }


        }

        private void incarcaDateDinFisier(string numeFisier)
        {
            StreamReader streamReader = new StreamReader(numeFisier);
            int nrLinii = int.Parse(streamReader.ReadLine());

            for(int i=0;i<nrLinii;i++)
            {
                string linie = streamReader.ReadLine();
                string[] elemente = linie.Split(',');
                listaMedici.Add(new Medic(nume:elemente[0],prenume:elemente[1],
                  dataNasterii:DateTime.ParseExact(elemente[2], "dd/MM/yyyy", null),codCabinet:int.Parse(elemente[3])));

            }

            streamReader.Close();
        }

        private void salavareDateInFisier(string numeFisier)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(Medic medic in listaMedici)
            {
                stringBuilder.Append(medic.CodMedic.ToString());
                stringBuilder.Append(", ");
                stringBuilder.Append(medic.Nume);
                stringBuilder.Append("  ");
                stringBuilder.Append(medic.Prenume);
                stringBuilder.Append(", ");
                stringBuilder.Append(medic.DataNasterii.ToShortDateString());
                stringBuilder.Append(", ");
                stringBuilder.Append(medic.CodMedic.ToString());
                stringBuilder.AppendLine();
            }
            File.WriteAllText(numeFisier, stringBuilder.ToString());
        }
        private void salveazaDateInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fisiere text (.*txt)|*.txt|Toate fisierele (*.*)|*.*";
            if(saveFileDialog.ShowDialog(this)==DialogResult.OK)
            {
                salavareDateInFisier(saveFileDialog.FileName);
               
            }

        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show(this, "Doriti sa salavti in fisier binar?", "SERIALIZARE"
                 , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                serializare("reteta.dat");
                
            }

        }


        private void serializare(string denumireFisier)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = new FileStream(denumireFisier, FileMode.Create, FileAccess.Write);
            formatter.Serialize(file,listaRetete);
            listViewRetete.Items.Clear();
            MessageBox.Show("Serializarea s-a facut cu succes!");
            file.Close();
        }

     
        

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show(this, "Doriti sa deserializati?", "DESERIALIZARE",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                deserializare("reteta.dat");

            }

        }

        private void deserializare(string denumireFisier)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = new FileStream(denumireFisier, FileMode.Open, FileAccess.Read);
            List<Reteta> reteta = (List<Reteta>)formatter.Deserialize(file);
            PopulareListViewRetete(reteta);
            MessageBox.Show("Deserializarea s-a facut cu succes!");
            file.Close();
        }

        private void txtLoc3_DragDrop(object sender, DragEventArgs e)
        {
            TextBox cine = (TextBox)sender;
            if (cine != null)
                cine.Text += e.Data.GetData(DataFormats.Text);
           
        }

        private void txtLoc3_DragEnter(object sender, DragEventArgs e)
        {

            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
        }

        private double MedieCabinet(List<Inregistrare> listaVechime)
        {
            float sumaVechime = 0;
            float sumaNrConsultatii = 0;
            
            foreach(Inregistrare inregistrare in listaVechime)
            {
                sumaNrConsultatii += inregistrare.Vechime * inregistrare.NrConsultatii;
                sumaVechime += inregistrare.NrConsultatii;
            }


            return sumaNrConsultatii / sumaVechime;
        }

        private void medieMediciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SituatieCabinet form = new SituatieCabinet(listaMedici, listaVechime, listaRetete, listaNrCabinet);
            form.ShowDialog();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asistentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistenti form = new Asistenti();
            form.ShowDialog();
        }

        private void txtLoc2_TextChanged(object sender, EventArgs e)
        {

        }

        private void graficeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
