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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            menuStrip1.Enabled = false;

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202243", "cl202243", "Lorena25"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
            groupBox1.Visible = false;
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarUsuario form2 = new cadastrarUsuario();
            form2.MdiParent = this;
            form2.Show();
            groupBox1.Visible = false;
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ver = DAO_Conexao.verificaLogin(textBox1.Text, textBox2.Text);
            if (ver==0)
            {
                MessageBox.Show("Usuário/Senha Inválido!");
            }
            if (ver==1)
            {
                MessageBox.Show("Usuário Administrador");
                menuStrip1.Enabled = true;
                groupBox1.Visible = false;
            } 
            if(ver==2)
            {
                MessageBox.Show("Usuário Restrito!");
                menuStrip1.Enabled = true;
                groupBox1.Visible = false;
                cadastrarLoginToolStripMenuItem.Enabled = false;
            }
        }

        private void consultarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excluirAluno form4 = new excluirAluno();
            form4.MdiParent = this;
            form4.Show();
            groupBox1.Visible = false;
        }

        private void atualizarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atualizarAluno form5 = new atualizarAluno();
            form5.MdiParent = this;
            form5.Show();
            groupBox1.Visible = false;
        }

        private void cadastrarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarModalidade form6 = new cadastrarModalidade();
            form6.MdiParent = this;
            form6.Show();
            groupBox1.Visible = false;
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarModalidade form7 = new consultarModalidade();
            form7.MdiParent = this;
            form7.Show();
            groupBox1.Visible = false;
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excluirModalidade form8 = new excluirModalidade();
            form8.MdiParent = this;
            form8.Show();
            groupBox1.Visible = false;
        }

        private void atualizarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atualizarModalidade atualizarModalidade = new atualizarModalidade();
            atualizarModalidade.MdiParent = this;
            atualizarModalidade.Show();
            groupBox1.Visible = false;
        }
    }
}
