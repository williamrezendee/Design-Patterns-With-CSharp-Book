using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            Console.Write("Escolha seu Personagem: ");
            string escolha = Console.ReadLine();

            IPersonagem personagem = factoryMethod.Escolher_Personagem(escolha);
            Console.WriteLine();

            Console.Write("Você vai jogar com ");
            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
