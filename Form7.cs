using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulasem2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Modalidade cad = new Modalidade();
            MySqlDataReader a = cad.consultarTodasModalidade();
            while (a.Read())
                comboBox1.Items.Add(a["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);
            MySqlDataReader r = modalidade.consultarModalidade(comboBox1.Text);
            if (r.Read())
            {
                txtConsultaPreco.Text = r["precoModalidade"].ToString();
                txtConsultaAlunos.Text = r["qtdeAlunos"].ToString();
                txtConsultaAulas.Text = r["qtdeAulas"].ToString();
                txtConsultaPreco.Enabled = false;
                txtConsultaAlunos.Enabled = false;
                txtConsultaAulas.Enabled = false;

            }
            else
            {
                MessageBox.Show("Modalidade não cadastrada!");
            }
                DAO_Conexao.con.Close();
        }
    }
}
