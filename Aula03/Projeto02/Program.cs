using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> lista = new List<Cliente>();

            for (int i = 0; i < 3; i++)
            {
                Cliente cliente = new Cliente();

                Console.WriteLine($"\nEntre com o {i + 1}º Cliente:\n");

                Console.WriteLine("Id do Cliente.....: ");
                cliente.IdCliente = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do Cliente.....: ");
                cliente.Nome = Console.ReadLine();

                Console.WriteLine("Email do Cliente.....: ");
                cliente.Email = Console.ReadLine();

                lista.Add(cliente);
            }

            Console.WriteLine("\nClientes adicionados com sucesso!\n");
            Console.WriteLine("Quantidade de Cliente: " + lista.Count);
            Console.WriteLine("\n\n");

            //Varrendo todos os elementos da lista
            foreach(Cliente c in lista)
            {
                Console.WriteLine("\tID.......: " + c.IdCliente);
                Console.WriteLine("\tNOME.....: " + c.Nome);
                Console.WriteLine("\tEMAIL....: " + c.Email);
                Console.WriteLine("\t----------------------");
            }

            Console.ReadKey();
        }
    }
}
