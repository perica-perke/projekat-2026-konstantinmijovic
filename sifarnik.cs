using Ednevnik410b;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ednevnik410b
{
    public partial class sifarnik : Form
    {
        SqlDataAdapter Adapter;
        DataTable podaci;
        string ime_tabele;
        public sifarnik(string tabela)
        {
            this.ime_tabele = tabela;
            InitializeComponent();
        }

        private void sifarnik_Load(object sender, EventArgs e)
        {
            Adapter = new SqlDataAdapter("select * from " + ime_tabele, konekcija.povezi());
            podaci = new DataTable();
            Adapter.Fill(podaci);
            dataGridView1.DataSource = podaci;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable menjano = podaci.GetChanges();
            Adapter.UpdateCommand = new SqlCommandBuilder(Adapter).GetUpdateCommand();
            if (menjano != null) Adapter.Update(menjano);
        }

        private void sifarnik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}