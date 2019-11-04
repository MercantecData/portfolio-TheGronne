using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning = true)
            {
                Console.WriteLine("Write 1!");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    giveRandomNumber();
                }
            }
        }
        static void giveRandomNumber()
        {
            int randomNumber = 0;
            Random random = new Random();
            randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("Weeee");
                    break;
                case 2:
                    Console.WriteLine("You got " + randomNumber + "! lucky!");
                    break;
                case 3:
                    Console.WriteLine("Hello, world!");
                    break;
            }
        }
    }
}
