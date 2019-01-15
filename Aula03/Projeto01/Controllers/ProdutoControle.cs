using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using System.IO;
using Newtonsoft.Json;

namespace Projeto01.Controllers
{
    public class ProdutoControle
    {
        //Método para exportar dados do produto em formato JSON
        public void ExportarDados(Produto produto)
        {
            //Criando um arquivo de extensão .json
            StreamWriter sw = new StreamWriter("c:\\temp\\produto.json");

            //Serializa os dados do objeto JSON (objeto -> json)
            string json = JsonConvert.SerializeObject(produto, Formatting.Indented);

            //Escrevendo no arquivo
            sw.WriteLine(json);

            //Fechando arquivo
            sw.Close();
        }

        public Produto ImportarDados()
        {
            //Abrindo o arquivo em modo leitura
            StreamReader sr = new StreamReader("c:\\temp\\produto.json");

            //Ler todo o conteúdo do arquivo e armazenar na variável json
            string json = sr.ReadToEnd();

            //Fechando o arquivo
            sr.Close();

            //Deserializar o conteúdo JSON (json -> objeto)
            Produto produto = JsonConvert.DeserializeObject<Produto>(json);

            return produto;
        }
    }
}
