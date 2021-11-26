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
    public partial class AddRetetaForm : Form
    {
        Reteta medicamente;
        public string mod=String.Empty;
        public AddRetetaForm()
        {
            InitializeComponent();
        }

        public AddRetetaForm(Reteta medicamente)
        {
            InitializeComponent();
            this.medicamente = medicamente;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            epMedicamente.SetError(txtMedicamente, string.Empty);
            epTipReteta.SetError(cbTipReteta, string.Empty);

            try
            {
                if (txtMedicamente.Text =="")
                    throw new Exception("Medicamente");
                if (cbTipReteta.Text == "")
                    throw new Exception("TipReteta");
                medicamente.Medicamente = txtMedicamente.Text;
                medicamente.Tip_Reteta = cbTipReteta.Text;
                this.Close();

            }
            catch(Exception ex)
            {
                if (ex.Message == "Medicamente")
                    epMedicamente.SetError(txtMedicamente, "Camp obligatoriu!");
                if (ex.Message == "TipReteta")
                    epTipReteta.SetError(cbTipReteta, "Alegeti un tip de reteta!");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRetetaForm_Load(object sender, EventArgs e)
        {
            if(mod=="modificare")
            {
                txtMedicamente.Text = medicamente.Medicamente;
                cbTipReteta.Text = medicamente.Tip_Reteta;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMedicamente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipReteta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
