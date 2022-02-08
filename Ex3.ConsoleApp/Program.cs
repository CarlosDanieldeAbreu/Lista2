using System;

namespace Ex3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Descubra se seu pesso e ideal!!!");
            Console.WriteLine("================================");

            Console.WriteLine("Informe sua altura:");
            string AlturaDaPessoa = Console.ReadLine();
            double Altura = Convert.ToDouble(AlturaDaPessoa);

            Console.WriteLine("Informe seu peso:");
            string PesoDaPessoa = Console.ReadLine();
            double Peso = Convert.ToDouble(PesoDaPessoa);
            
            double IMC = Math.Pow(Altura,2) / Peso;

            if (IMC < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Abaixo do peso!!!");
            }else if (IMC >= 18.5 && IMC <= 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Peso normal!!!");
            }else if(IMC >= 25 && IMC <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Acima do peso!!!");
            }else if (IMC > 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Obeso!!!");
            }
        }
    }
}
