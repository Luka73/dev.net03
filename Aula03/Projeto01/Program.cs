using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Controllers;
using System.IO;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(1, "Mouse", 12.50m, 5);

            ProdutoControle produtoControle = new ProdutoControle();

            #region ExportarDados
            try //tentativa
            {
                produtoControle.ExportarDados(p);
                Console.WriteLine("\nDados gravados com sucesso!\n");
            }
            catch(UnauthorizedAccessException e)
            {
                Console.WriteLine("\nAcesso negado ao diretório: " + e.Message);
            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("\nDiterório não encontrado: " + e.Message);
            }
            catch(Exception e) //captura a exceção genérica
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }
            #endregion


            #region ImportarDados
            try
            {
                Produto registro = produtoControle.ImportarDados();

                Console.WriteLine("\nDADOS OBTIDOS DO ARQUIVO JSON:\n");
                Console.WriteLine($"Id: {registro.IdProduto}, " +
                                  $"Nome: {registro.Nome}, " +
                                  $"Preço: {registro.Preco}, " +
                                  $"Quantidade: {registro.Quantidade}");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
