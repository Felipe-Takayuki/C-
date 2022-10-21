using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            double numero = double.Parse(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("É positivo");
            }
            else
            if (numero < 0)
            {
                Console.WriteLine("É negativo");
            }
            else
            {
                Console.WriteLine("É um número neutro");
            }
            
        }
    }
}
