
namespace aulasem2
{
    partial class atualizarModalidade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAtualizaPreco = new System.Windows.Forms.TextBox();
            this.txtAtualizaAlunos = new System.Windows.Forms.TextBox();
            this.txtAtualizaAulas = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAtivo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtivo);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.txtAtualizaAulas);
            this.groupBox1.Controls.Add(this.txtAtualizaAlunos);
            this.groupBox1.Controls.Add(this.txtAtualizaPreco);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atualizar Modalidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qtde de Alunos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qtde de Aulas:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtAtualizaPreco
            // 
            this.txtAtualizaPreco.Location = new System.Drawing.Point(129, 105);
            this.txtAtualizaPreco.Name = "txtAtualizaPreco";
            this.txtAtualizaPreco.Size = new System.Drawing.Size(160, 20);
            this.txtAtualizaPreco.TabIndex = 5;
            // 
            // txtAtualizaAlunos
            // 
            this.txtAtualizaAlunos.Location = new System.Drawing.Point(142, 158);
            this.txtAtualizaAlunos.Name = "txtAtualizaAlunos";
            this.txtAtualizaAlunos.Size = new System.Drawing.Size(147, 20);
            this.txtAtualizaAlunos.TabIndex = 6;
            // 
            // txtAtualizaAulas
            // 
            this.txtAtualizaAulas.Location = new System.Drawing.Point(142, 205);
            this.txtAtualizaAulas.Name = "txtAtualizaAulas";
            this.txtAtualizaAulas.Size = new System.Drawing.Size(147, 20);
            this.txtAtualizaAulas.TabIndex = 7;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(85, 246);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAtivo
            // 
            this.btnAtivo.Enabled = false;
            this.btnAtivo.Location = new System.Drawing.Point(254, 246);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(75, 23);
            this.btnAtivo.TabIndex = 9;
            this.btnAtivo.Text = "Ativar";
            this.btnAtivo.UseVisualStyleBackColor = true;
            this.btnAtivo.Click += new System.EventHandler(this.btnAtivo_Click);
            // 
            // atualizarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "atualizarModalidade";
            this.Text = "atualizarModalidade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtivo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtAtualizaAulas;
        private System.Windows.Forms.TextBox txtAtualizaAlunos;
        private System.Windows.Forms.TextBox txtAtualizaPreco;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}