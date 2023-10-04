﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float preco = float.Parse(maskedPreco.Text);
            int alunos = int.Parse(txtAlunos.Text);
            int aulas = int.Parse(txtAulas.Text);
            Modalidade modalidade = new Modalidade(txtModalidade.Text, preco, alunos, aulas);

            if (modalidade.cadastrarModalidade())
                MessageBox.Show("Cadastro realizado com sucesso!");
            else
                MessageBox.Show("Erro no cadastro!");
        }
    }
}
