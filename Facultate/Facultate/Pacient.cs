using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet_Medical
{
    public class Pacient
    {
        private int codPacient;
        private int nrCabinet;
        private string statut;
        private string mediu;


        public Pacient()
        {
            this.codPacient = 0;
            this.nrCabinet = 0;
            this.statut = "N/A";
            this.mediu = "N/A";

        }
        public Pacient(int codPacient, int nrCabinet, string statut, string mediu)
        {
            this.codPacient = codPacient;
            this.nrCabinet = nrCabinet;
            this.statut = statut;
            this.mediu = mediu;
        }

        public int CodPacient { get => codPacient; set { codPacient = value; } }

        public int NrCabinet
        {
            get => nrCabinet;
            set
            {
                if (value > 0 && value < 4)
                    nrCabinet = value;
            }
        }

        public string Statut
        {
            get => statut;
            set
            {
                if (value != null)
                    statut = value;
            }
        }

        public string Mediu
        {
            get => mediu;
            set
            {
                if (value != null)
                    mediu = value;
            }
        }

        public override string ToString()
        {
            return ("\nCodPacient=" + CodPacient + "\nNrCabinet=" + NrCabinet + "\nStatut=" + Statut + "\nMediu=" + Mediu);
        }


    }
}
