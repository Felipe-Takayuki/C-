using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int basi, altura;
            double area;
            Console.Write("Informe o valor da base");
            basi = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor da altura");
            altura = int.Parse(Console.ReadLine());
            area = basi * altura / 2;
            Console.WriteLine("O triângulo com base"+ basi +"e altura"+ altura + "tem área igual a"+ area);
           
        }
    }
}
