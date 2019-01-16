using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Cliente
    {
        #region Atributos
        private int idCliente;
        private string nome;
        private string email;
        #endregion

        #region Encapsulamento
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        #region Construtores
        //Construtor default
        public Cliente()
        {

        }

        //Sobrecarga (Overloading)
        public Cliente(int idCliente, string nome, string email)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
        }       
        #endregion
    }
}
