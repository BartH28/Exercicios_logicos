using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o ano em que voce nasceu ?");
            int anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano nôs estamos?");
            int anoAtual = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;
            double semanas = idade * 52.179;

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("A sua idade é " + idade);
            Console.WriteLine("A sua idade em semanas é " + semanas);

            Console.ResetColor();
        }
    }
}
