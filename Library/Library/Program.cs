using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int i = 1;
            while (i < input)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
