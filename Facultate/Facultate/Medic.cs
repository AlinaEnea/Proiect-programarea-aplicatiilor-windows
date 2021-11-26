using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet_Medical
{
    public class Medic
    {
        private static int contor;
        private int codMedic;
        private string nume;
        private string prenume;
        private DateTime dataNasterii;
        private int codCabinet;

        static Medic()
        {
            contor = 0;
        }
        public Medic()
        {
            ++contor;
            this.codMedic = contor;
            this.nume = "N/A";
            this.prenume = "N/A";
            this.dataNasterii = DateTime.Today;
            this.codCabinet = 0;
        }

        public Medic(string nume, string prenume, DateTime dataNasterii, int codCabinet)
        {
            ++contor;
            this.codMedic = contor;
            this.nume = nume;
            this.prenume = prenume;
            this.dataNasterii = dataNasterii;
            this.codCabinet = codCabinet;
        }

        public int CodMedic
        {
            get
            {
                return codMedic;
            }
        }

        public string Nume
        {
            get
            {
                return nume;
            }

            set
            {
                if (value != null)
                {
                    nume = value;
                }
                else
                    throw new Exception("Nume");
            }
        }

        public string Prenume
        {
            get
            {
                return prenume;
            }

            set
            {
                if (value != null)
                    prenume = value;
                else
                    throw new Exception("Prenume");

            }
        }

        public DateTime DataNasterii
        {
            get
            {
                return dataNasterii;
            }

            set
            {
                if (value != null)
                    dataNasterii = value;
            }
        }
        public int CodCabinet
        {
            get
            {
                return codCabinet;
            }

            set
            {
                if (value > 0)
                    codCabinet = value;
            }


        }
        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        public override string ToString()
        {

            return ("\nMedicul cu codul " + codMedic + " are urmatoarele date:\nNume: " + Nume
                + "\nPrenume: " + Prenume + "\nDataNasterii: " + DataNasterii.ToShortDateString() + "\nCodCabinet: " + CodCabinet);



        }


    }
}
