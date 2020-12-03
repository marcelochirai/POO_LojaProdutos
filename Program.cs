using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_TarefaLojaProdutos.Entities;
using System.Globalization;


/*
 * CONTEÚDO DISPONÍVEL NA AULA DO DIA 23/11/20 (slides 7 e 8)
 * Criar um programa para receber os dados de N produtos.
 * Após o lançamento dos mesmos, mostrar a etiqueta de preço de cada produto 
 * na mesma ordem em que foram digitados.
 * Todo o produto possui nome e preço.
 * Produtos importados possuem uma taxa de alfândega, e produtos usados possuem data de fabricação.
 * Estes dados específicos devem ser acrescentados na etiqueta de preço.
 * Para os produtos importados, a taxa e alfândega deve ser acrescentada ao preço final do produto.
 */


namespace POO_TarefaLojaProdutos.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar lista de produtos conforme informado pelo usuário
            List<Produto> list = new List<Produto>();
            Console.Write("Informe o número de produtos para cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            //Criar um laço para os produtos informados, conforme a quantidade
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Produto #{i} : ");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                string produtoPCadast = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                //Verificação de Importado
                if (produtoPCadast == "i")
                {
                    Console.Write("Taxa de Importação: ");
                    double taxaImportacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ProdutoImportado(nome, preco, taxaImportacao));
                    Produto Importado = new ProdutoImportado();
                    Importado.EtiquetaPreco(produtoPCadast);
                }
                //Verficação de usado
                else if (produtoPCadast == "u")
                {
                    Console.Write("Data da Produção (DD/MM/AAAA): ");
                    DateTime producao = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nome, preco, producao));
                    Produto usado = new ProdutoUsado();
                    usado.EtiquetaPreco(produtoPCadast);
                }
                //Verificação de produto comum
                else
                {
                    list.Add(new Produto(nome, preco));
                    Produto produto = new Produto();
                    produto.EtiquetaPreco(produtoPCadast);
                }
            }

            Console.WriteLine();
            foreach (Produto produto in list)
            {
                Console.WriteLine(produto);
            }

            Console.WriteLine();

        }
    }
}
