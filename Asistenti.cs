using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cabinet_Medical
{
    public partial class Asistenti : Form
    {
        string connString;

        public Asistenti()
        {
            InitializeComponent();
            connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\Date\Asistenti1.mdb";
            txtModif.Hide();
        }

        private void btnPrelDate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                // MessageBox.Show("Merge");
                //OleDbCommand comanda = new OleDbCommand("SELECT * FROM Asistenti", conexiune);
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM Asistenti";

                OleDbDataReader reader = comanda.ExecuteReader();
                //populare ListView
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID"].ToString());
                    item.SubItems.Add(reader["Nume"].ToString());
                    item.SubItems.Add(reader["Prenume"].ToString());
                    item.SubItems.Add(reader["Email"].ToString());
                    item.SubItems.Add(reader["Medicamente"].ToString());
                    item.SubItems.Add(reader["Tip Reteta"].ToString());

                    listView1.Items.Add(item);



                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;

                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Checked)
                    {
                        int id = Convert.ToInt32(item.SubItems[0].Text);
                    

                        txtModif.Show();
                        comanda.CommandText = "UPDATE Asistenti set Nume=?" +
                            " WHERE ID=" + id;
                        var nume = new OleDbParameter("?",OleDbType.VarChar);
                        
                        nume.Value = txtModif.Text;
                        comanda.Parameters.Add(nume);
                      
                        comanda.ExecuteNonQuery();
                        txtModif.Clear();

                    }
                }




            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void btnInserare_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT MAX(ID) FROM Asistenti";
                int id = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO Asistenti VALUES(?,?,?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                comanda.Parameters.Add("Nume", OleDbType.Char,20).Value = txtNume.Text;
                comanda.Parameters.Add("Prenume", OleDbType.Char,20).Value = txtPrenume.Text;
                comanda.Parameters.Add("Email", OleDbType.Char,20).Value = txtEmail.Text;
                comanda.Parameters.Add("Medicamente", OleDbType.Char,20).Value = txtMedicamente.Text;
                comanda.Parameters.Add("Tip Reteta", OleDbType.Char, 20).Value = txtTipReteta.Text;

                comanda.ExecuteNonQuery();


            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                txtNume.Clear();
                txtPrenume.Clear();
                txtEmail.Clear();
                txtMedicamente.Clear();
                txtTipReteta.Clear();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;

                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Checked)
                    {
                        int id = Convert.ToInt32(item.SubItems[0].Text);



                        comanda.CommandText = "DELETE FROM Asistenti" +
                            " WHERE ID=" + id;
                        comanda.ExecuteNonQuery();
                    }

                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Asistenti_Load(object sender, EventArgs e)
        {

        }
    }
}
