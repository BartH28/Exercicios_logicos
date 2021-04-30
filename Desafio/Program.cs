using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade ?");
            double idade = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;

            if (idade >= 5 &&  idade <= 7)
            {
                Console.WriteLine("Sua categoria de natação é Infantio A"); 
            }
            else if (idade >= 8 &&  idade <= 10)
            {
                Console.WriteLine("Sua categoria de natação é Infantio B");
            }
            else if (idade >= 11 &&  idade <= 13)
            {
                Console.WriteLine("Sua categoria de natação é Juvenio A");
            }
            else if (idade >= 14 &&  idade <= 17)
            {
                Console.WriteLine("Sua categoria de natação é Juvenio B");
            }
            else 
            {
                Console.WriteLine("Sua categoria de natação é Senior");
            }
            Console.ResetColor();
        }
    }
}
