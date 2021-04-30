using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu salario?");
            double salario = double.Parse(Console.ReadLine());

            if (salario > 500)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O seu salario não é adequado para o aumento");
                Console.ResetColor();
            }
            else
            {
               Console.ForegroundColor = ConsoleColor.Green; 
               double aumento = (salario * 30) /100; 
               double novoSalario = salario + aumento;
               Console.WriteLine("O seu novo salario ficara " + "R$" + novoSalario );
               Console.ResetColor();
            }
        
        }
    }
}
