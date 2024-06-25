using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
              
            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida!");

                Console.Write("Digite novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Senha correta!");

        }
    }
}
