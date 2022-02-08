using System;

namespace Ex1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor A:");
            String MedidaA = Console.ReadLine();
            float MedA =  Convert.ToSingle(MedidaA);

            Console.WriteLine("-----------------");
            Console.WriteLine("Insira o valor B:");
            string MedidaB = Console.ReadLine();
            float MedB = Convert.ToSingle(MedidaB);

            Console.WriteLine("-----------------");
            Console.WriteLine("Insira o valor C:");
            string MedidaC = Console.ReadLine();
            float MedC = Convert.ToSingle(MedidaC);

            float SomaAmaisB = MedA + MedB;

            if (MedC < SomaAmaisB)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("A soma de A + B é MAIOR que C!!!");
            }
            else if (MedC > SomaAmaisB)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A soma de A + B é MENOR que C!!!");
            }
        }
    }
}
