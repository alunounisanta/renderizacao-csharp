using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool renderizado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void renderizar()
        {
            Label lbl_quantidade = new Label();
            lbl_quantidade.Name = "lbl_quantidade";
            lbl_quantidade.Text = "Quantidade: ";
            lbl_quantidade.Location = new Point(74, 157);
            lbl_quantidade.Width = 65;
            //lbl_quantidade.Height = 13;
            this.Controls.Add(lbl_quantidade);

            Label lbl_descricao = new Label();
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Text = "Descricao: ";
            lbl_descricao.Location = new Point(74, 205);
            lbl_descricao.Width = 65;
            //lbl_quantidade.Height = 13;
            this.Controls.Add(lbl_descricao);
            this.renderizado = true;

            TextBox txt_quantidade = new TextBox();
            txt_quantidade.Name = "txt_quantidade";
            txt_quantidade.Location = new Point(148, 154);
            txt_quantidade.Width = 100;

            TextBox txt_descricao = new TextBox();
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Location = new Point(148, 202);
            txt_descricao.Width = 100;

            this.Controls.Add(txt_descricao);
            this.Controls.Add(txt_quantidade);
            
            Button btn_cadastrar = new Button();
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.Location = new Point(289,154);
            btn_cadastrar.Size = new Size(105, 67);

            btn_cadastrar.Click += (s, e) =>
            {
                String nome = txt_name.Text;
                double preco = Double.Parse(txt_preco.Text);
                int qtd = int.Parse(txt_quantidade.Text);
                String desc = txt_descricao.Text;

                ProdutoTeste prod = new ProdutoTeste(nome, preco, qtd, desc);
                double valorEstoque = prod.calcularEstoque();
                MessageBox.Show("Produto Cadastrado, Valor em estoque: " + valorEstoque);
            };
            this.Controls.Add(btn_cadastrar);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // '-' .-. ._. .-. '-'
            // Adicionar comentário
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (!renderizado) 
            {
                this.renderizar();
            }
            

        }

        private void txt_preco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_preco_Click(object sender, EventArgs e)
        {

        }

        private void lb_nome_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
