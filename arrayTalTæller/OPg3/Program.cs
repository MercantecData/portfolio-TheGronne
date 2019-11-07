using System;

namespace OPg3
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int[] array = new int[input];
            int currentNumber = 0;
            int biggestNumber = 0;
            int function()
            {
                Console.WriteLine(biggestNumber);
                return biggestNumber;
            }
            while (currentNumber < input)
            {
                int number = int.Parse(Console.ReadLine());
                array[currentNumber] = number;
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
                currentNumber++;
                if (currentNumber == input)
                {
                    function();
                }
            }
        }
    }
}
