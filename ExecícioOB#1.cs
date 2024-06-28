using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosOB_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa Nome, Idade;

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());


            Console.Write("Digite o nome da segunda pessoa: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("O mais velho(a) é: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("O mais velho(a) é: " + pessoa2.Nome);
            }
        }
    }
}
