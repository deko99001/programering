using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[5];
            for (int i = 0; i < tal.Length; i++)
            {
                Console.Write("Ange tal " + (i + 1) + ": ");
                tal[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 4; i >= 0; i--)
            {
                
                Console.Write(tal[i]);
            }
        }
    }
}
