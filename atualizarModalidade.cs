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
    public partial class atualizarModalidade : Form
    {
        public atualizarModalidade()
        {
            InitializeComponent();
            Modalidade cad = new Modalidade();
            MySqlDataReader a = cad.consultarTodasModalidade();
            while (a.Read())
                comboBox1.Items.Add(a["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);
            MySqlDataReader r = modalidade.consultarModalidade();
            
            if (r.Read())
            {
                txtAtualizaPreco.Text = r["precoModalidade"].ToString();
                txtAtualizaAlunos.Text = r["qtdeAlunos"].ToString();
                txtAtualizaAulas.Text = r["qtdeAulas"].ToString();
            }
            else
            {
                MessageBox.Show("Modalidade não cadastrada!");
            }
            DAO_Conexao.con.Close();
            int b = modalidade.consultarAtivo();
            Console.WriteLine(b);
            if(b == 1)
            {
                btnAtivo.Enabled = true;
            }
            else
            {
                btnAtivo.Enabled = false;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            float preco = float.Parse(txtAtualizaPreco.Text);
            int aulas = int.Parse(txtAtualizaAulas.Text);
            int alunos = int.Parse(txtAtualizaAlunos.Text);

            Modalidade modalidade = new Modalidade(comboBox1.Text, preco, alunos, aulas);
            MySqlDataReader r = modalidade.consultarModalidade();
            if (r.Read())
            {
                DAO_Conexao.con.Close();
                if (modalidade.atualizarModalidade(comboBox1.Text))
                {
                    MessageBox.Show("Dados atualizados com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar");
                }
            }
            else
            {
                MessageBox.Show("Modalidade não encontrada");
            }
        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);
            MySqlDataReader r = modalidade.consultarModalidade();
            if (r.Read())
            {
                DAO_Conexao.con.Close();
                if (modalidade.atualizaAtiva(comboBox1.Text))
                {
                    MessageBox.Show("Modalidade ativa com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao ativar");
                }
            }
            else
            {
                MessageBox.Show("Modalidade não encontrada");
            }

        }
    }
}
