using System;

namespace WhileLoopNogetSkole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mathias", "Jeppe" };
            int idfk = 0;
            while (idfk < names.Length)
            {
                Console.WriteLine(names[idfk]);
                idfk++;
            }
        }
    }
}
