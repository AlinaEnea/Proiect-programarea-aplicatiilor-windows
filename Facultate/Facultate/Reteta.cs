using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet_Medical
{
    [Serializable]
    public class Reteta
    {

        private static int contor;
        private int codReteta;
        private string medicamente;
        private string tip_reteta;

        static Reteta()
        {
            contor = 0;
        }

        public Reteta()
        {
            ++contor;
            this.codReteta = contor;
            this.medicamente = "N/A";
            this.tip_reteta = "N/A";
        }


        public Reteta(string medicamente, string tip_reteta)
        {
            ++contor;
            this.codReteta = contor;
            this.medicamente = medicamente;
            this.tip_reteta = tip_reteta;

        }

        public int CodReteta { get => codReteta; }
        public string Medicamente
        {
            get => medicamente;
            set
            {
                if (value != null)
                    medicamente = value;
            }
        }

        public string Tip_Reteta
        {
            get => tip_reteta;
            set
            {
                if (value != null)
                    tip_reteta = value;
            }
        }


        public override string ToString()
        {
            return ("\nCodReteta=" + CodReteta + "\nMedicamente="
                + Medicamente + "\nTip_Reteta=" + Tip_Reteta);
        }

    }
}
