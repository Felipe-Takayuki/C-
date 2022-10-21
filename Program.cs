using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultadosub, resultmult, resultsoma, resultdiv;
            Console.Write("Digite o valor da variavel A");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da variavel B");
            b = int.Parse(Console.ReadLine());
            resultadosub = a - b;
            resultsoma = a + b;
            resultmult = a * b;
            resultdiv = a / b;
            Console.WriteLine("subtração" + resultadosub);
            Console.WriteLine("soma {0}", resultsoma);
            Console.WriteLine("Multiplicação" + resultmult);
            Console.WriteLine("Divisão" + resultdiv);
        }
    }
}
