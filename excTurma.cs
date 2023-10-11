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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aulasem2
{
    public partial class excTurma : Form
    {
        public excTurma()
        {
            InitializeComponent();
            Modalidade cad = new Modalidade();
            MySqlDataReader a = cad.consultarTodasModalidade();
            while (a.Read())
                cbModalidade.Items.Add(a["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            int modalidade = turma.consultarID(cbModalidade.Text);

            Turma turma2 = new Turma(modalidade);
            turma2.consultarTodasTurma();
            DAO_Conexao.con.Close();

            if (turma2.excluirTurma())
            {
                MessageBox.Show("Turma Excluída!");
            }
            else
            {
                MessageBox.Show("Deu erro ruim!");
            }
        }

        private void cbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            int modalidade = turma.consultarID(cbModalidade.Text);

            Turma tr = new Turma();
            MySqlDataReader b = tr.consultarTurmaModalidade(modalidade);
            while (b.Read())
                cbDia.Items.Add(b["diasemanaTurma"].ToString());
            DAO_Conexao.con.Close();
        }

        private void cbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turma tr = new Turma();
            MySqlDataReader b = tr.consultarTurmaDia(cbDia.Text);
            while (b.Read())
                cbHora.Items.Add(b["horaTurma"].ToString());
            DAO_Conexao.con.Close();
        }
    }
}