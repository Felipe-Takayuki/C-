using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, dobro;
            Console.Write("Escreva um número");
            num = int.Parse(Console.ReadLine());
            dobro = num * 2;
            Console.WriteLine(dobro);
            
        }
    }
}
