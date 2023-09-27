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
    public partial class atualizarAluno : Form
    {
        public atualizarAluno()
        {
            InitializeComponent();
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
                Aluno aluno = new Aluno(txtCPF.Text);
                if (e.KeyChar == 13)
                {

                    MySqlDataReader r = aluno.consultarAluno01();
                    if (r.Read())
                    {
                        txtNome.Text = r["nomeAluno"].ToString();
                        txtEnd.Text = r["ruaAluno"].ToString();
                        txtNumero.Text = r["numeroAluno"].ToString();
                        txtBairro.Text = r["bairroAluno"].ToString();
                        txtCompl.Text = r["complementoAluno"].ToString();
                        txtCEP.Text = r["CEPAluno"].ToString();
                        txtCidade.Text = r["cidadeAluno"].ToString();
                        txtEstado.Text = r["estadoAluno"].ToString();
                        txtTel.Text = r["telefoneAluno"].ToString();
                        txtEmail.Text = r["emailAluno"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Aluno não cadastrado!");
                    }

                }
                DAO_Conexao.con.Close(); //somente fecha depois de retornar
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEnd.Text, txtNumero.Text, txtBairro.Text, txtCompl.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text);
            if (aluno.consultarAluno())
            {
                DAO_Conexao.con.Close();
                if (aluno.atualizarAluno())
                {
                    MessageBox.Show("Dados atualizados com Sucesso");
                    /*txtBairro.Text = "";
                    txtCEP.Text = "";
                    txtCidade.Text = "";
                    txtCompl.Text = "";
                    txtCPF.Text = "";
                    txtEmail.Text = "";
                    txtEnd.Text = "";
                    txtEstado.Text = "";
                    txtNome.Text = "";
                    txtNumero.Text = "";
                    txtTel.Text = "";*/
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar");
                }
            }
            else
            {
                MessageBox.Show("CPF não encontrado");
            }
        }
    }
}
