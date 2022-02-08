using System;

namespace Ex4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Descubra se um número é IMPAR ou PAR");
            Console.WriteLine("====================================");

            Console.WriteLine("Imforme um número:");
            string NumeroAdescobrir = Console.ReadLine();
            float Numero = Convert.ToSingle(NumeroAdescobrir);

            if(Numero % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Seu número é par");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Seu número é ímpar");
                Console.ResetColor();
            }
        }
    }
}
