using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinqSimples();
            //LinqComplexo();
            //LinqOrdenadacaoSimples();
            //LinqOrdenadacaoComplexa();
            LinqPorString();
        }

        private static void LinqSimples()
        {
            int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var numerosFiltrados = numeros.Where(x => x > 4);

            foreach (var item in numerosFiltrados)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void LinqComplexo()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var resultado = from num in numeros
                            where num > 4
                            select num;

            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void LinqOrdenadacaoSimples()
        {
            int[] numeros = { 8, 4, 6, 9, 7, 1, 2, 3, 10 };

            var resultado = from num in numeros
                            orderby num
                            where num > 4
                            select num;

            foreach (var item in resultado)
            {
              Console.WriteLine(item);   
            }

            Console.ReadKey();
        }

        private static void LinqOrdenadacaoComplexa()
        {
            int[] numeros = { 8, 4, 6, 9, 7, 1, 2, 3, 10 };

            var resultado = numeros
                .Where(x => x > 4)
                .OrderBy(x => x);

            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void LinqPorString()
        {
            string[] cores = { "Preto", "Amarelo", "Azul", "Branco", "Rosa", "Marrom", "Verde", "Vermelho" };

            var resultado = cores.Where(x => x.Contains("e") || x.Contains("z"));

            foreach (var cor in resultado)
            {
                Console.WriteLine(cor);
            }

            Console.ReadKey();
        }
    }
}
