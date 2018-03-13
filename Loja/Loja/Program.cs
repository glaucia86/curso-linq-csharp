using Loja.Domain.Entities;
using System;
using System.Linq;

namespace Loja
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LinqComplexo();
            LinqSimples();
        }

        private static void LinqComplexo()
        {
            var produto = new Produto();

            var produtos = produto.ListarProdutos()
                .Where(x => x.Valor > 4)
                .OrderBy(x => x.Nome);

            foreach (var item in produtos)
            {
                Console.WriteLine(item.Nome);
            }

            Console.ReadKey();
        }

        private static void LinqSimples()
        {
            new Produto()
                .ListarProdutos()
                .Where(x => x.Valor > 4)
                .ToList()
                .ForEach(item =>
                {
                    Console.WriteLine(item.Nome);
                    Console.WriteLine(item.Valor);
                });

            Console.ReadKey();
        }
    }
}
