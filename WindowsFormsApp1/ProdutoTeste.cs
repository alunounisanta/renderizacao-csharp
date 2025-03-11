using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ProdutoTeste
    {
        private String Nome { get; set; }
        private double Valor { get; set; }
        private int Quantidade { get; set; }
        private string Descricao { get; set; }

        public ProdutoTeste(string nome, double valor, int quantidade, string descricao)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
            Descricao = descricao;
        }
        public double calcularEstoque()
        {
            return this.Valor * this.Quantidade;
        }

    }
}
