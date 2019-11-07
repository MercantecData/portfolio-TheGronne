using System;

namespace Fri_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            bool quizIsGoing = true;
            points = 0;
            while (quizIsGoing == true)
            {
                Console.WriteLine("What gender is your champion?");
                Console.WriteLine("1 = Male");
                Console.WriteLine("2 = Female");
                Console.WriteLine("3 = Robot");
                int question1 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                if (question1 > 3)
                {
                    Console.WriteLine("Not a valid answer!");
                }
                if (question1 == 1)
                {
                    points += 0;
                }
                else if (question1 == 2)
                {
                    points += 100;
                }
                else if (question1 == 3)
                {
                    points += 1000;
                }
                Console.WriteLine("What position is your champion?");
                Console.WriteLine("1 = Top");
                Console.WriteLine("2 = Jungle");
                Console.WriteLine("3 = Mid");
                Console.WriteLine("4 = ADC");
                Console.WriteLine("5 = Support");
                int question2 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                if (question2 > 5)
                {
                    Console.WriteLine("Not a valid answer!");
                }
                if (question2 == 1)
                {
                    points += 0;
                }
                else if (question2 == 2)
                {
                    points += 100;
                }
                else if (question2 == 3)
                {
                    points += 100;
                }
                else if (question2 == 4)
                {
                    points += 100;
                }
                else if (question2 == 5)
                {
                    points += 100;
                }
                Console.WriteLine("What role is your champion?");
                Console.WriteLine("1 = Bruiser");
                Console.WriteLine("2 = Assassin");
                Console.WriteLine("3 = Enchanter");
                Console.WriteLine("4 = Marksman");
                Console.WriteLine("5 = Tank");
                Console.WriteLine("5 = Mage");
                int question3 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                if (question3 == 1)
                {
                    points += 0;
                }

                if (points == 0)
                {
                    Console.WriteLine("Does your champion use a sword?");
                    Console.WriteLine("1 = Yes");
                    Console.WriteLine("2 = No");
                    int question4 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                    if (question4 == 1)
                    {
                        Console.WriteLine("Is your champion from Demacia?");
                        Console.WriteLine("1 = Yes");
                        Console.WriteLine("2 = No");
                        int question5 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                        if (question5 == 1)
                        {
                            Console.WriteLine("Your champion is Garen");
                        }
                        if (question5 == 2)
                        {
                            Console.WriteLine("Is your champion an animal?");
                            Console.WriteLine("1 = Yes");
                            Console.WriteLine("2 = No");
                            int question6 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                            if (question6 == 1)
                            {
                                Console.WriteLine("Your champion is Renekton");
                            }
                            if (question6 == 2)
                            {
                                Console.WriteLine("Is your champion a yordle?");
                                Console.WriteLine("1 = Yes");
                                Console.WriteLine("2 = No");
                                int question7 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                                if (question7 == 1)
                                {
                                    Console.WriteLine("Your champion is Kled");
                                }
                                if (question7 == 2)
                                {
                                    if (question6 == 2)
                                    {
                                        Console.WriteLine("Is your champion from Freljord?");
                                        Console.WriteLine("1 = Yes");
                                        Console.WriteLine("2 = No");
                                        int question8 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                                        if (question8 == 1)
                                        {
                                            Console.WriteLine("Your champion is Tryndamere");
                                        }
                                        if (question8 == 2)
                                        {
                                            Console.WriteLine("Does your champion use a gun?");
                                            Console.WriteLine("1 = Yes");
                                            Console.WriteLine("2 = No");
                                            int question9 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                                            if (question9 == 1)
                                            {
                                                Console.WriteLine("Your champion is Gangplank");
                                            }
                                            if (question9 == 2)
                                            {
                                                Console.WriteLine("Your champion is Aatrox");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    } else if (question4 == 2)
                    {
                        Console.WriteLine("Does your champion use an axe?");
                        Console.WriteLine("1 = Yes");
                        Console.WriteLine("2 = No");
                        int question5 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                        if (question5 == 1)
                        {
                            Console.WriteLine("Is your champion from Noxus?");
                            Console.WriteLine("1 = Yes");
                            Console.WriteLine("2 = No");
                            int question6 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                            if (question6 == 1)
                            {
                                Console.WriteLine("Does your champion have a revive ability?");
                                Console.WriteLine("1 = Yes");
                                Console.WriteLine("2 = No");
                                int question7 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                                if (question7 == 1)
                                {
                                    Console.WriteLine("Your champion is Sion");
                                }
                                if (question7 == 2)
                                {
                                    Console.WriteLine("Your champion is Darius");
                                }
                            }
                            if (question6 == 2)
                            {
                                Console.WriteLine("Your champion is Olaf");
                            }
                        }
                        if (question5 == 2)
                        {
                            Console.WriteLine("Is your champion a human?");
                            Console.WriteLine("1 = Yes");
                            Console.WriteLine("2 = No");
                            int question6 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                            if (question6 == 1)
                            {
                                Console.WriteLine("Your champion is Gangplank");
                            }
                            if (question6 == 2)
                            {
                                Console.WriteLine("Is your champion from Shurima?");
                                Console.WriteLine("1 = Yes");
                                Console.WriteLine("2 = No");
                                int question7 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                                if (question7 == 1)
                                {
                                    Console.WriteLine("Your champion is Nasus");
                                }
                                if (question7 == 2)
                                {
                                    Console.WriteLine("Does your champion use a shovel?");
                                    Console.WriteLine("1 = Yes");
                                    Console.WriteLine("2 = No");
                                    int question8 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                                    if (question8 == 1)
                                    {
                                        Console.WriteLine("Your champion is Yorick");
                                    }
                                    if (question8 == 2)
                                    {
                                        Console.WriteLine("Does your champion wear heavy armor?");
                                        Console.WriteLine("1 = Yes");
                                        Console.WriteLine("2 = No");
                                        int question9 = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                                        if (question9 == 1)
                                        {
                                            Console.WriteLine("Your champion is Mordekaiser");
                                        }
                                        if (question9 == 2)
                                        {
                                            Console.WriteLine("Your champion is Jax");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                void restart(){
                    quizIsGoing = false;
                    quizIsGoing = true;
                    points = 0;
                }
            }
        }
    }
}
