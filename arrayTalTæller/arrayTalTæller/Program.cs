using System;

namespace arrayTalTæller
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
            int[] array = new int[input]; //Makes an array that is as long as the number you wrote.
            int currentNumber = 0;
            while(currentNumber < input)
            {
                Console.WriteLine(currentNumber);
                currentNumber++;
                if (currentNumber == input)
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
