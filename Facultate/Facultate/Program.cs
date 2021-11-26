using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Cabinet_Medical
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            List<Medic> listMedici = new List<Medic>();

            Medic medic2 = new Medic("Manaila", "Stefania", DateTime.ParseExact("22/02/1999", "dd/MM/yyyy", null), 4);
            Medic medic3 = new Medic("Lupu", "Tatiana", DateTime.ParseExact("02/05/1998", "dd/MM/yyyy", null), 2);
            Medic medic4 = new Medic("Moise", "Ana", DateTime.ParseExact("06/07/1998", "dd/MM/yyyy", null), 3);
            Medic medic5 = new Medic("Argaseala", "Gabriela", DateTime.ParseExact("10/05/1999", "dd/MM/yyyy", null), 5);
            Medic medic6 = new Medic("Iordache", "Eugen", DateTime.ParseExact("10/08/1997", "dd/MM/yyyy", null), 7);
            Medic medic7 = new Medic("Fatu", "Iulia", DateTime.ParseExact("02/05/2000", "dd/MM/yyyy", null), 2);
            Medic medic8 = new Medic("Dumitrescu", "Maria", DateTime.ParseExact("23/02/1999", "dd/MM/yyyy", null), 7);
            Medic medic9 = new Medic("Dobrescu", "Bogdan", DateTime.ParseExact("02/08/1996", "dd/MM/yyyy", null), 4);
            Medic medic10 = new Medic("Dragomir", "Mariana", DateTime.ParseExact("02/05/2000", "dd/MM/yyyy", null), 1);
            Medic medic11 = new Medic("Tirlea", "Marius", DateTime.ParseExact("14/03/1997", "dd/MM/yyyy", null), 2);
            Medic medic12 = new Medic("Popescu", "Andreea", DateTime.ParseExact("17/10/1999", "dd/MM/yyyy", null), 3);
            Medic medic13 = new Medic("Mircea", "Oana", DateTime.ParseExact("20/06/1999", "dd/MM/yyyy", null), 3);
            Medic medic14 = new Medic("Iosef", "Vladut", DateTime.ParseExact("20/04/2000", "dd/MM/yyyy", null), 6);
            Medic medic15 = new Medic("Maican", "Vlad", DateTime.ParseExact("10/03/1997", "dd/MM/yyyy", null), 7);
            Medic medic16 = new Medic("Lupu", "Tatiana", DateTime.ParseExact("02/05/1998", "dd/MM/yyyy", null), 1);



            //  listMedici.Add(medic1);
            listMedici.Add(medic2);
            listMedici.Add(medic3);
            listMedici.Add(medic4);
            listMedici.Add(medic5);
            listMedici.Add(medic6);
            listMedici.Add(medic7);
            listMedici.Add(medic8);
            listMedici.Add(medic9);
            listMedici.Add(medic10);
            listMedici.Add(medic11);
            listMedici.Add(medic12);
            listMedici.Add(medic13);
            listMedici.Add(medic14);
            listMedici.Add(medic15);
            listMedici.Add(medic16);

            Reteta reteta = new Reteta("", "");
            //Retete
            List<Reteta> listaReteta = new List<Reteta>();
            Reteta reteta1 = new Reteta("Apa oxigenata", "Reteta oficinala");
            Reteta reteta2 = new Reteta("Unguent dr. T", "Reteta magistrala");
            Reteta reteta3 = new Reteta("Antibiotice polipeptide", "Reteta tipizata");
            Reteta reteta4 = new Reteta("Tinctura de iod", "Reteta oficinala");
            Reteta reteta5 = new Reteta("Hipertensiune Edeme", "Reteta magistrala");
            Reteta reteta6 = new Reteta("Tetraciclina", "Reteta tipizata");
            Reteta reteta7 = new Reteta("Alcool iodat", "Reteta oficinala");
            Reteta reteta8 = new Reteta("Colargol 1%", "Reteta magistrala");
            Reteta reteta9 = new Reteta("Cloramfenicol", "Reteta tipizata");
            Reteta reteta10 = new Reteta("Mixtura mentolata", "Reteta oficinala");
            Reteta reteta11 = new Reteta("Unguent pentru zona Zoster", "Reteta magistrala");
            Reteta reteta12 = new Reteta("Antivirale", "Reteta tipizata");
            Reteta reteta13 = new Reteta("Bixtonim", "Reteta oficinala");
            Reteta reteta14 = new Reteta("Solutie FEMA", "Reteta magistrala ");
            Reteta reteta15 = new Reteta("Clonidina", "Reteta tipizata");

            listaReteta.Add(reteta1);
            listaReteta.Add(reteta2);
            listaReteta.Add(reteta3);
            listaReteta.Add(reteta4);
            listaReteta.Add(reteta5);
            listaReteta.Add(reteta6);
            listaReteta.Add(reteta7);
            listaReteta.Add(reteta8);
            listaReteta.Add(reteta9);
            listaReteta.Add(reteta10);
            listaReteta.Add(reteta11);
            listaReteta.Add(reteta12);


            StreamReader reader = new StreamReader("dateRetete.txt");
            int nrlinii = int.Parse(reader.ReadLine());
            for (int i = 0; i < nrlinii; i++)
            {
                string linie = reader.ReadLine();
                string[] elemente = linie.Split(',');
                listaReteta.Add(new Reteta(medicamente: elemente[0], tip_reteta: elemente[1]));
            }

            reader.Close();

            //Pacienti
            Pacient pacient1 = new Pacient(1, 1, "Abonat", "rural");
            Pacient pacient2 = new Pacient(2, 1, "Neabonat", "urban");
            Pacient pacient3 = new Pacient(3, 1, "Neabonat", "rural");
            Pacient pacient4 = new Pacient(4, 2, "Abonat", "urban");
            Pacient pacient5 = new Pacient(5, 2, "Neabonat", "rural");
            Pacient pacient6 = new Pacient(6, 3, "Abonat", "urban");
            Pacient pacient7 = new Pacient(7, 3, "Abonat", "rural");

            List<Pacient> listaPacienti = new List<Pacient>();
            listaPacienti.Add(pacient1);
            listaPacienti.Add(pacient2);
            listaPacienti.Add(pacient3);
            listaPacienti.Add(pacient4);
            listaPacienti.Add(pacient5);
            listaPacienti.Add(pacient6);
            listaPacienti.Add(pacient7);



            List<Inregistrare> listaVechime = new List<Inregistrare>();
            Inregistrare inregistrare1 = new Inregistrare(4, 3, 7, 5, true);
            Inregistrare inregistrare2 = new Inregistrare(5, 4, 6, 4, true);

            listaVechime.Add(inregistrare1);
            listaVechime.Add(inregistrare2);



            reader = new StreamReader("dateVechime.txt");
            nrlinii = int.Parse(reader.ReadLine());
            for (int i = 0; i < nrlinii; i++)
            {
                string linie = reader.ReadLine();
                string[] elemente = linie.Split(',');
                listaVechime.Add(new Inregistrare(codReteta: int.Parse(elemente[0]), codMedic: int.Parse(elemente[1])
                    , vechime: int.Parse(elemente[2]),
                    nrConsultatii: int.Parse(elemente[3]), activ: bool.Parse(elemente[4].ToString())));

            }
            reader.Close();




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal(listMedici, listaReteta,listaPacienti,listaVechime));

        }
    }
}