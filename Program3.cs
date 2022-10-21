using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome , genero;
            int idade, generoselect;
            Console.WriteLine("Informe o seu nome");
            nome = (Console.ReadLine());
            Console.WriteLine("Informe a sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o seu gênero para masculino 1, feminino 2 e outro 3");
            generoselect = int.Parse(Console.ReadLine());
            if(generoselect == 1)
            {
                genero = "Masculino";
                Console.WriteLine("Nome:" + nome + "idade" + idade + "genero" + genero);
            }
            else 
            if(generoselect == 2)
            {
                genero = "Feminino";
                Console.WriteLine("Nome:" + nome ,"idade" + idade + "genero" + genero);
            }
            else
            if(generoselect == 3)
            {
                Console.WriteLine("informe o seu gênero ");
                genero = Console.ReadLine();
                Console.WriteLine("Nome:" + nome + "idade" + idade + "genero" + genero);
            }
            else
            {
                Console.WriteLine("Invalido");
            }
        }
    }
}
