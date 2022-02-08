using System;

namespace Ex2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[3];
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("Insira o " + (i+1) + "° valor:");
                valor[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(valor);
            Console.WriteLine("\n");
            Console.WriteLine("==============================");
            Console.WriteLine("Valores em ordem decrescente");
            foreach (int p in valor) Console.WriteLine(p);
        }
    }
}
