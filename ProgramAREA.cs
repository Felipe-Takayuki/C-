using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMPERATURA
{
    class Program
    {
        static void Main(string[] args)
        {
            double Area, pi,raio;
            Console.WriteLine("Digite o raio");
            raio = double.Parse(Console.ReadLine());
            pi= 3.14;
            Area = (pi * raio * raio);
            String TesteString = Area.ToString();
            Console.WriteLine("Area do circulo = " + TesteString);
        }
    }
}
