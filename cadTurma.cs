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
    public partial class cadTurma : Form
    {
        public cadTurma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            int modalidade = turma.consultarID(txtModalidade.Text);
            int qtde_alunos = int.Parse(txtQtdeAlunos.Text);

            Turma turma2 = new Turma(txtProf.Text, txtDia.Text, mtbHora.Text, modalidade, qtde_alunos);
            if (turma2.cadastrarTurma())
                MessageBox.Show("Cadastro realizado com sucesso!");
            else
                MessageBox.Show("Erro no cadastro!");
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtdeAlunos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
