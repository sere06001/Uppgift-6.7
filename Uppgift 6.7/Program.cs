using System;
namespace uppgift6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Skriv ett heltal: ");
                int heltal = int.Parse(Console.ReadLine());
                Primtal(heltal);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Primtal(int a)
        {
            bool prim = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    prim = false;
                    break;
                }
            }
            if (prim)
            {
                Console.WriteLine(a+" är ett primtal.");
            }
            else
            {
                Console.WriteLine(a+" är inte ett primtal.");
            }
        }
    }
}