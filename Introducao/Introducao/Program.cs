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
            LinqComplexo();
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

        
    }
}
