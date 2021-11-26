using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet_Medical
{
    public class Inregistrare
    {

        public static int contor;
        public int codInreg;
        private int codMedic;
        private int codReteta;
        private int vechime;
        private int nrConsultatii;
        private bool activ;

        static Inregistrare()
        {
            contor = 0;
        }

        public Inregistrare(int codReteta, int codMedic, int vechime, int nrConsultatii, bool activ)
        {
            ++contor;
            this.codInreg = contor;
            this.codMedic = codMedic;
            this.codReteta = codReteta;
            this.activ = activ;
            this.vechime = vechime;
            if (activ)
            {
                this.nrConsultatii = nrConsultatii;
            }
            else
            {
                this.nrConsultatii = 0;
            }
        }
        public Inregistrare()
        {
            ++contor;
            this.codInreg = contor;
            this.codReteta = 0;
            this.codMedic = 0;
            this.vechime = 0;
            this.nrConsultatii = 0;
            this.activ = false;

        }
        public int CodInreg { get => codInreg; }
        public int CodReteta
        {
            get => codReteta;
            set
            {
                if (value > 0)
                    codReteta = value;
                else
                    throw new Exception("Valoarea codului trebuie sa fie mai mare strict decat 0!");
            }
        }

        public int CodMedic
        {
            get => codMedic;
            set
            {
                if (value > 0)
                    codMedic = value;
                else
                    throw new Exception("Valoarea codului trebuie sa fie mai mare strict decat 0!");
            }
        }

        public int NrConsultatii
        {
            get => nrConsultatii;
            set
            {
                nrConsultatii = value;
                if (value == 0)
                    activ = false;
            }
        }

        public bool Activ
        {
            get => activ;
            set
            {
                activ = value;
                if (value == false)
                    nrConsultatii = 0;
            }

        }


        public int Vechime
        {
            get => vechime;
            set
            {
                if (value > 0)
                {
                    vechime = value;
                    if (value < 1)
                    {
                        activ = false;
                        nrConsultatii = 0;
                    }

                }
                else
                    throw new Exception("Vechimea trebuie sa fie un numar pozitiv!");
            }
        }

        public override string ToString()
        {
            return ("\nMedicul cu codul " + CodMedic + " are  " + ":\n" +
                "\nVechime=" + Vechime + "-Numar Consultatii=" + NrConsultatii + "-Activitate=" + Activ);
        }

    }
}
