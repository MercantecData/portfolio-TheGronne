using System;

namespace Opg_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            int biggestNumber = 0;
            int middleNumber = 0;
            int lowestNumber = 0;
            array[0] = int.Parse(Console.ReadLine());
            array[1] = int.Parse(Console.ReadLine());
            array[2] = int.Parse(Console.ReadLine());
            int number1 = array[0];
            int number2 = array[1];
            int number3 = array[2];
            void function()
            {
                if (number1 > number2)
                {
                    if (number1 > number3)
                    {
                        biggestNumber = number1;
                        if (number2 > number3)
                        {
                            middleNumber = number2;
                            lowestNumber = number3;
                        } else if (number2 < number3)
                        {
                            lowestNumber = number2;
                            middleNumber = number3;
                        }
                    } else if (number1 < number3)
                    {
                        biggestNumber = number3;
                        middleNumber = number1;
                        lowestNumber = number2;
                    }
                } else if (number1 < number2)
                {
                    if (number1 > number3)
                    {
                        biggestNumber = number2;
                        middleNumber = number1;
                        lowestNumber = number3;
                    } else if (number3 < number2)
                    {
                        number2 = biggestNumber;
                        if (number1 < number2)
                        {
                            middleNumber = number2;
                            lowestNumber = number1;
                        } else if (number1 > number2)
                        {
                            middleNumber = number1;
                            lowestNumber = number2;
                        }
                    }
                }
                Console.WriteLine(biggestNumber);
                Console.WriteLine(middleNumber);
                Console.WriteLine(lowestNumber);
            }
            Console.WriteLine(">---------------------------<");
            function();
        }
    }
}
