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
    public partial class excluirAluno : Form
    {
        public excluirAluno()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
            
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text);
               if (e.KeyChar == 13)
               {
                  if (aluno.consultarAluno())
                  {
                      DAO_Conexao.con.Close();
                    if (aluno.excluirAluno())
                     {
                         MessageBox.Show("Aluno Excluído!");
                     }
                     else
                     {
                        MessageBox.Show("Deu erro ruim!");
                     }
                  }
               }
        }
    }
}
