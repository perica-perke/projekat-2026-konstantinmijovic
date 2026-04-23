using Ednevnik410b;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ednevnik410b
{
    public partial class Upisnica : Form
    {
        public Upisnica()
        {
            InitializeComponent();
        }
        private void PopulateCboxGod()
        {
            SqlConnection veza = konekcija.povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Skolska_godina", veza);
            DataTable godina = new DataTable();
            adapter.Fill(godina);
            this.godina.DataSource = godina;
            this.godina.ValueMember = "id";
            this.godina.DisplayMember = "naziv";
        }
        private void PopulateCboxOdeljenje()
        {
            SqlConnection veza = konekcija.povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, razred, indeks, godina_id, str(razred)+'-'+indeks as naziv FROM Odeljenje", veza);
            DataTable Odeljenje = new DataTable();
            adapter.Fill(Odeljenje);
            odeljenje.DataSource = Odeljenje;
            odeljenje.ValueMember = "id";
            odeljenje.DisplayMember = "naziv";
        }
        private void PopulateCboxUcenik()
        {
            SqlConnection veza = konekcija.povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, prezime+' '+ime as naziv FROM Osoba", veza);
            DataTable ucenik = new DataTable();
            adapter.Fill(ucenik);
            this.ucenik.DataSource = ucenik;
            this.ucenik.ValueMember = "id";
            this.ucenik.DisplayMember = "naziv";
        }
        private void PopulateDGridView()
        {
            SqlConnection veza = konekcija.povezi();
            string naredba = "SELECT Upisnica.id, ime+' '+prezime as ucenik, str(razred)+'-'+indeks as odel, Odeljenje.Godina_id as god_id, Odeljenje.id as odel_id, Osoba.id as os_id from Upisnica JOIN Osoba ON Osoba_id=Osoba.id JOIN Odeljenje ON Odeljenje_id=Odeljenje.id";
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, veza);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            datagrid.DataSource = tabela;
            datagrid.AllowUserToAddRows = false;
            tabela.Columns["id"].ColumnName = "ID";
            tabela.Columns["ucenik"].ColumnName = "Učenik";
            tabela.Columns["odel"].ColumnName = "Odjeljenje";
            datagrid.Columns["god_id"].Visible = false;
            datagrid.Columns["odel_id"].Visible = false;
            datagrid.Columns["os_id"].Visible = false;
        }
        private void PopulateCBoxes()
        {
            PopulateCboxGod();
            PopulateCboxOdeljenje();
            PopulateCboxUcenik();
        }
        private void Upisnica_Load(object sender, EventArgs e)
        {
            PopulateCBoxes();
            PopulateDGridView();
        }

        private void DGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null)
            {
                int brSloga = datagrid.CurrentRow.Index;
                godina.SelectedValue = datagrid.Rows[brSloga].Cells["god_id"].Value.ToString();
                odeljenje.SelectedValue = datagrid.Rows[brSloga].Cells["odel_id"].Value.ToString();
                ucenik.SelectedValue = datagrid.Rows[brSloga].Cells["os_id"].Value.ToString();
                id.Text = datagrid.Rows[brSloga].Cells["id"].Value.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM upisnica WHERE id=" + id.Text;
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            PopulateDGridView();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE upisnica SET osoba_id = " + ucenik.SelectedValue.ToString();
            naredba += ", odeljenje_id=" + odeljenje.SelectedValue.ToString();
            naredba += " WHERE id=" + id.Text;
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            PopulateDGridView();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string naredba = "INSERT INTO upisnica (odeljenje_id, osoba_id) VALUES(";
            naredba += odeljenje.SelectedValue.ToString() + ", ";
            naredba += ucenik.SelectedValue.ToString() + ")";
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            PopulateDGridView();
        }

        private void Upisnica_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}