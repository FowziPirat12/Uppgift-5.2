using System;
namespace Uppgift_5._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");

            int tal = int.Parse(Console.ReadLine());

            int[] antal = new int[tal];

            Console.WriteLine($"Skriv in {tal} heltal:");

            for (int i = 0; i < tal; i++)
            {
                antal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("här är de talen du skrev in:");
            for(int i = 0; i < antal.Length; i++)   
            Console.WriteLine(antal[i]);

        }
    }
}