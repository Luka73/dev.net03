using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Produto
    {
        #region Atributos
        private int idProduto;
        private string nome;
        private decimal preco;
        private int quantidade;
        #endregion

        #region Métodos
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        //construtor default
        //Atalho: ctor + 2x(tab)
        public Produto()
        {
                
        }

        public Produto(int idProduto, string nome, decimal preco, int quantidade)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        #endregion
    }

}
