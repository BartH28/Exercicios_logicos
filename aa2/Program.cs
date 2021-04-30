using System;

namespace aa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade em anos\n");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 30;

            int dias = idade * 365;

            int horas = idade * 8766;

            int minutos = idade * 525960;

            Console.ForegroundColor =  ConsoleColor.Blue;

            Console.WriteLine(" Sua idade em meses é " + meses);
            Console.WriteLine(" Sua idade em dias é " + dias);
            Console.WriteLine(" Sua idade em horas é " + horas);
            Console.WriteLine(" Sua idade em minutos é " + minutos);

            Console.ResetColor();




        }
    }
}
