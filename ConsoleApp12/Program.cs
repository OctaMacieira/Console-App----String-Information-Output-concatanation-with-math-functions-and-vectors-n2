using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, maiorAB;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;

            Console.WriteLine(maiorAB + " eh o maior");
            Console.ReadLine();
        }
    }
}
