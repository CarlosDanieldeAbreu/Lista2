using System;

namespace Ex5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Informe o valor A:");
            string ValorA = Console.ReadLine();
            int A = Convert.ToInt32(ValorA);

            Console.WriteLine("=====================");
            Console.WriteLine("Informe o valor B:");
            string ValorB = Console.ReadLine();
            int B = Convert.ToInt32(ValorB);
            int resultado, C = 0;
            //int[] C = new int[100];
            
            
            if (A == B)
            {
                resultado = A + B;
            }
            else if (A != B)
            {
                resultado = A * B;
            }
                        

            Console.WriteLine("Variavel C:");
            Console.WriteLine(C);
        }
    }
}
