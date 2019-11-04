using System;

namespace CombinedProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = 0;
            bool isRunning = true;
            while (isRunning == true)
            {
                Console.WriteLine(">---------------------------------------------------------------------------------------------------------------------<");
                Console.WriteLine("                                              Welcome! Choose a game!");
                Console.WriteLine("                                              Type 1 for CountingGame");
                Console.WriteLine("                                         Type 2 to generate a random quote!");
                Console.WriteLine("                                        Type 3 to play Rock, Paper, Scissors");
                Console.WriteLine("                                         Type 4 to ask the magic eightball!");
                Console.WriteLine("                                          Type 5 to play Would you rather?");
                Console.WriteLine("                                            Type 6 to play LeagueBetting!");
                Console.WriteLine(">---------------------------------------------------------------------------------------------------------------------<");

                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    countingGame();
                }
                else if (input == 2)
                {
                    Console.WriteLine(randomQuoteGenerator());
                }
                else if (input == 3)
                {
                    rockPaperScissor();
                }
                else if (input == 4)
                {
                    while (isRunning == true)
                    {
                        Console.WriteLine("Ask me a yes/no question and I'll answer!");
                        string quit = (Console.ReadLine());
                        Console.WriteLine(eightBallPossibilities());
                    }
                } 
                else if (input == 5)
                {
                    Console.Clear();
                    Console.WriteLine(WouldYouRather());
                } 
                else if (input == 6)
                {
                    while (isRunning == true)
                    {
                        Console.Clear();
                        leagueBetting();
                    }
                }
                else if (input > 6)
                {
                    Console.WriteLine("That's not an option!");
                }
                void leagueBetting()
                {
                    bool firstTime = true;
                    int currentBetterNumber = 0;
                    int blueMoneyPool = 0;
                    int redMoneyPool = 0;
                    string name = "";
                    string team = "";
                    int money = 0;
                    string winningTeam = "";
                    int numberOfBlueBetters = 0;
                    int numberOfRedBetters = 0;
                    int currentBetterNumber2 = 0;
                    int blueBetters = 0;
                    int redBetters = 0;
                    bool bettingMoney = true;

                    Console.WriteLine("How many people are betting?");
                    int numberOfBetters = int.Parse(Console.ReadLine());
                    string[] betters = new string[numberOfBetters];
                    int[] bettersBet = new int[numberOfBetters];
                    string[] bettersTeam = new string[numberOfBetters];
                    int[] bettersTotalMoney = new int[numberOfBetters];

                    while (currentBetterNumber < numberOfBetters)
                    {
                        
                        Console.WriteLine("Who's betting?");
                        name = (Console.ReadLine());
                        Console.WriteLine("Hello " + name + "!");
                        betters[currentBetterNumber] = name;

                        Console.WriteLine("Choose a team to bet on! Type blue for blue team, and red for red team!");
                        team = (Console.ReadLine());
                        Console.WriteLine("You've chosen team " + team + "!");
                        bettersTeam[currentBetterNumber] = team;

                        bettingMoney = true;


                        while (bettingMoney == true)
                        {
                            Console.WriteLine("Now how much will you bet?");
                            money = int.Parse(Console.ReadLine());
                            bettersBet[currentBetterNumber] = money;

                            if (firstTime == true)
                            {
                                bettersTotalMoney[currentBetterNumber] = 1000;
                            }
                            if (bettersTotalMoney[currentBetterNumber] < money)
                            {
                                Console.WriteLine("You don't have the money!!!");
                            } else
                            {
                                bettingMoney = false;
                            }
                        }
                        bettersTotalMoney[currentBetterNumber] -= money;
                        if (team.ToLower().Contains("blue"))
                        {
                            blueMoneyPool += money;
                            blueBetters += 1;
                        } else if (team.ToLower().Contains("red"))
                        {
                            redMoneyPool += money;
                            redBetters += 1;
                        }
                        Console.WriteLine("You have bet " + money + " mushrooms on team " + team + "!");
                        currentBetterNumber += 1;
                    }
                    Console.WriteLine("Everyone has voted! Wait for the game to end and tell me which team won!");
                    winningTeam = (Console.ReadLine());
                    int totalAmountOfMoney = blueMoneyPool + redMoneyPool;

                    if (winningTeam.ToLower().Contains("blue"))
                    {
                        int wonMoney = totalAmountOfMoney /= blueBetters;
                        while (currentBetterNumber2 < currentBetterNumber)
                        {
                            if (blueBetters == 0)
                            {
                                Console.WriteLine("Nobody won!");
                                currentBetterNumber2 = currentBetterNumber;
                            } else
                            {
                                if (bettersTeam[currentBetterNumber2].ToLower().Contains("red"))
                                {
                                    bettersBet[currentBetterNumber2] = 0;
                                } else
                                {
                                    bettersTotalMoney[currentBetterNumber2] = bettersBet[currentBetterNumber2] + wonMoney;
                                }
                                
                                Console.WriteLine(betters[currentBetterNumber2] + " has won " + bettersBet[currentBetterNumber2] + " mushrooms!");
                                Console.WriteLine(betters[currentBetterNumber2] + " now has a balance of " + bettersTotalMoney[currentBetterNumber2] + " mushrooms!");
                                currentBetterNumber2 += 1;
                            }
                        }
                        Console.WriteLine("Type y/n to play again");
                        string betAgain = (Console.ReadLine());
                        if (betAgain.ToLower().Contains("y"))
                        {
                            firstTime = false;
                            restart();
                        }
                        
                    }
                }
                void rockPaperScissor()
                {
                    Console.WriteLine("Write Rock, Paper or Scissors!");
                    string name = (Console.ReadLine());
                    Random random = new Random();
                    randomNumber = random.Next(1, 3);
                    if (name.ToLower().Contains("rock"))
                    {
                        if (randomNumber == 1)
                        {
                            Console.WriteLine("I choose Rock!");
                            Console.WriteLine("Nobody Wins!");
                        }
                        else if (randomNumber == 2)
                        {
                            Console.WriteLine("I choose Paper!");
                            Console.WriteLine("Paper beats Rock, I win!");
                        }
                        else if (randomNumber == 3)
                        {
                            Console.WriteLine("I choose Scissor!");
                            Console.WriteLine("Rock beats Scissors, you win!");
                        }
                    }
                    if (name.ToLower().Contains("paper"))
                    {
                        if (randomNumber == 1)
                        {
                            Console.WriteLine("I choose Rock!");
                            Console.WriteLine("Paper beats Rock, you Win!");
                        }
                        else if (randomNumber == 2)
                        {
                            Console.WriteLine("I choose Paper!");
                            Console.WriteLine("Nobody wins!");
                        }
                        else if (randomNumber == 3)
                        {
                            Console.WriteLine("I choose Scissors!");
                            Console.WriteLine("Scissors beats Paper, I win!");
                        }
                    }
                    if (name.ToLower().Contains("scissors"))
                    {
                        if (randomNumber == 1)
                        {
                            Console.WriteLine("I choose Rock!");
                            Console.WriteLine("Rock beats Scissors, I win!");
                        }
                        else if (randomNumber == 2)
                        {
                            Console.WriteLine("I choose Paper!");
                            Console.WriteLine("Scissors beats Paper, you win!");
                        }
                        else if (randomNumber == 3)
                        {
                            Console.WriteLine("I choose Scissor!");
                            Console.WriteLine("Nobody wins!");
                        }
                    }
                    restart();
                }
                static string randomQuoteGenerator()
                {
                    int randomNumber = 0;
                    string answer = ("");
                    Random random = new Random();
                    randomNumber = random.Next(1, 50);
                    string fact1 = ("Ignorance feels horrible");
                    string fact2 = ("By reflecting you can become older");
                    string fact3 = ("You're gay");
                    string fact4 = ("Having the preiod is an incredible death race");
                    string fact5 = ("When is the right time to stop modernizing good karma?");
                    string fact6 = ("Rule#11: Always let your dreams get in the way of giving up");
                    string fact7 = ("Before the universe, comes the mother");
                    string fact8 = ("It's not your fault if you become an undercover agent");
                    string fact9 = ("In our medication begin marriages");
                    string fact10 = ("With good conviction comes good art");
                    string fact11 = ("Pimping requires meditation");
                    string fact12 = ("SHAVE YOUR FEET");
                    string fact13 = ("After the value of human lives, comes the book");
                    string fact14 = ("Random people, they're there to think of you");
                    string fact15 = ("Be fat");
                    string fact16 = ("We cannot become better \n by inspiring each other \n but we can become better \n by saving each other");
                    string fact17 = ("Involuntary calibracy is like an insect");
                    string fact18 = ("People who feed on pets, feed on evidence");
                    string fact19 = ("Hey! Here comes intelligence!");
                    string fact20 = ("Fool your personal issues");
                    string fact21 = ("Keep on infecting. Be normalizing");
                    string fact22 = ("Be a burglar. Rat up your family");
                    string fact23 = ("Our minds end when our body fluids begin");
                    string fact24 = ("If you are not questioning political pain you don't know the true power of political pain!");
                    string fact25 = ("Can \n make you \n seem \n unhealthy");
                    string fact26 = ("You're redarded");
                    string fact27 = ("Underestimate confusion of people you meet");
                    string fact28 = ("Don't stop being at home and don't be hypnotized");
                    string fact29 = ("Deceiving each other means you and me");
                    string fact30 = ("You're original. \nIn the same way that a bird in a cage is original");
                    string fact31 = ("Mother nature is an aging actress that isn't there");
                    string fact32 = ("Sex can feel like an explosion");
                    string fact33 = ("Becoming pregnant is 110 percent optional");
                    string fact34 = ("Seem a winnner. Be a winner.");
                    string fact35 = ("Adolescence can be a mysterious rollercoaster");
                    string fact36 = ("Be grateful. Do it. Don't ask questions.");
                    string fact37 = ("Going broke is a bender");
                    string fact38 = ("Self-pitying enables you to climax");
                    string fact39 = ("Cancer");
                    string fact40 = ("Once an illusionist always an illusionist");
                    string fact41 = ("Thou shalt not terminate insanity");
                    string fact42 = ("If you can spoil him, you can feel him");
                    string fact43 = ("Become disappointing");
                    string fact44 = ("Don't tell anyone that you're starving");
                    string fact45 = ("The singularity is a disease");
                    string fact46 = ("Growing up can be unworthy");
                    string fact47 = ("Talk loud in public and be dumb");
                    string fact48 = ("Be more communist");
                    string fact49 = ("How would things look if clowns got what they deserved?");
                    string fact50 = ("Complain about people who are different from you during recess");
                    string space = (">------------------------------------------------------------<");
                    switch (randomNumber)
                    {
                        case 1:
                            answer = (space + "\n" + fact1 + "\n" + space);
                                break;
                        case 2:
                            answer = (space + "\n" + fact2 + "\n" + space);
                            break;
                        case 3:
                            answer = (space + "\n" + fact3 + "\n" + space);
                            break;
                        case 4:
                            answer = (space + "\n" + fact4 + "\n" + space);
                            break;
                        case 5:
                            answer = (space + "\n" + fact5 + "\n" + space);
                            break;
                        case 6:
                            answer = (space + "\n" + fact6 + "\n" + space);
                            break;
                        case 7:
                            answer = (space + "\n" + fact7 + "\n" + space);
                            break;
                        case 8:
                            answer = (space + "\n" + fact8 + "\n" + space);
                            break;
                        case 9:
                            answer = (space + "\n" + fact9 + "\n" + space);
                            break;
                        case 10:
                            answer = (space + "\n" + fact10 + "\n" + space);
                            break;
                        case 11:
                            answer = (space + "\n" + fact11 + "\n" + space);
                            break;
                        case 12:
                            answer = (space + "\n" + fact12 + "\n" + space);
                            break;
                        case 13:
                            answer = (space + "\n" + fact13 + "\n" + space);
                            break;
                        case 14:
                            answer = (space + "\n" + fact14 + "\n" + space);
                            break;
                        case 15:
                            answer = (space + "\n" + fact15 + "\n" + space);
                            break;
                        case 16:
                            answer = (space + "\n" + fact16 + "\n" + space);
                            break;
                        case 17:
                            answer = (space + "\n" + fact17 + "\n" + space);
                            break;
                        case 18:
                            answer = (space + "\n" + fact18 + "\n" + space);
                            break;
                        case 19:
                            answer = (space + "\n" + fact19 + "\n" + space);
                            break;
                        case 20:
                            answer = (space + "\n" + fact20 + "\n" + space);
                            break;
                        case 21:
                            answer = (space + "\n" + fact21 + "\n" + space);
                            break;
                        case 22:
                            answer = (space + "\n" + fact22 + "\n" + space);
                            break;
                        case 23:
                            answer = (space + "\n" + fact23 + "\n" + space);
                            break;
                        case 24:
                            answer = (space + "\n" + fact24 + "\n" + space);
                            break;
                        case 25:
                            answer = (space + "\n" + fact25 + "\n" + space);
                            break;
                        case 26:
                            answer = (space + "\n" + fact26 + "\n" + space);
                            break;
                        case 27:
                            answer = (space + "\n" + fact27 + "\n" + space);
                            break;
                        case 28:
                            answer = (space + "\n" + fact28 + "\n" + space);
                            break;
                        case 29:
                            answer = (space + "\n" + fact29 + "\n" + space);
                            break;
                        case 30:
                            answer = (space + "\n" + fact30 + "\n" + space);
                            break;
                        case 31:
                            answer = (space + "\n" + fact31 + "\n" + space);
                            break;
                        case 32:
                            answer = (space + "\n" + fact32 + "\n" + space);
                            break;
                        case 33:
                            answer = (space + "\n" + fact33 + "\n" + space);
                            break;
                        case 34:
                            answer = (space + "\n" + fact34 + "\n" + space);
                            break;
                        case 35:
                            answer = (space + "\n" + fact35 + "\n" + space);
                            break;
                        case 36:
                            answer = (space + "\n" + fact36 + "\n" + space);
                            break;
                        case 37:
                            answer = (space + "\n" + fact37 + "\n" + space);
                            break;
                        case 38:
                            answer = (space + "\n" + fact38 + "\n" + space);
                            break;
                        case 39:
                            answer = (space + "\n" + fact39 + "\n" + space);
                            break;
                        case 40:
                            answer = (space + "\n" + fact40 + "\n" + space);
                            break;
                        case 41:
                            answer = (space + "\n" + fact41 + "\n" + space);
                            break;
                        case 42:
                            answer = (space + "\n" + fact42 + "\n" + space);
                            break;
                        case 43:
                            answer = (space + "\n" + fact43 + "\n" + space);
                            break;
                        case 44:
                            answer = (space + "\n" + fact44 + "\n" + space);
                            break;
                        case 45:
                            answer = (space + "\n" + fact45 + "\n" + space);
                            break;
                        case 46:
                            answer = (space + "\n" + fact46 + "\n" + space);
                            break;
                        case 47:
                            answer = (space + "\n" + fact47 + "\n" + space);
                            break;
                        case 48:
                            answer = (space + "\n" + fact48 + "\n" + space);
                            break;
                        case 49:
                            answer = (space + "\n" + fact49 + "\n" + space);
                            break;
                        case 50:
                            answer = (space + "\n" + fact50 + "\n" + space);
                            break;
                    }
                    return answer;
                }
                void countingGame()
                {
                    Console.WriteLine("Write a number that I should count to!");
                    int input = int.Parse(Console.ReadLine()); //Makes an int that is the number you write at first.
                    int[] array = new int[input]; //Makes an array that is as long as the number you wrote.
                    int currentNumber = 0;
                    while (currentNumber < input)
                    {
                        Console.WriteLine(currentNumber);
                        currentNumber++;
                        if (currentNumber == input)
                        {
                            Console.WriteLine(input);
                        }
                    }
                    restart();
                }
                static string eightBallPossibilities()
                {
                    int randomNumber = 0;
                    string answer = ("");
                    Random random = new Random();
                    randomNumber = random.Next(1, 9);
                    string possibility1 = ("Yes!");
                    string possibility2 = ("No!");
                    string possibility3 = ("Maybe...");
                    string possibility4 = ("Signs point to no");
                    string possibility5 = ("Signs point to yes");
                    string possibility6 = ("You're retarded");
                    string possibility7 = ("Probably");
                    string possibility8 = ("Of course! Why not???");
                    string possibility9 = ("Of course not!!!");
                    string space = (">------------------------------------------------------------<");

                    switch (randomNumber)
                    {
                        case 1: 
                            answer = (space + "\n" + possibility1 + "\n" + space);
                            break;
                        case 2: 
                            answer = (space + "\n" + possibility2 + "\n" + space);
                            break;
                        case 3:
                            answer = (space + "\n" + possibility3 + "\n" + space);
                            break;
                        case 4:
                            answer = (space + "\n" + possibility4 + "\n" + space);
                            break;
                        case 5:
                            answer = (space + "\n" + possibility5 + "\n" + space);
                            break;
                        case 6:
                            answer = (space + "\n" + possibility6 + "\n" + space);
                            break;
                        case 7:
                            answer = (space + "\n" + possibility7 + "\n" + space);
                            break;
                        case 8:
                            answer = (space + "\n" + possibility8 + "\n" + space);
                            break;
                        case 9:
                            answer = (space + "\n" + possibility9 + "\n" + space);
                            break;
                    }
                    return answer;
                }
                while (isRunning == false)
                {
                    restart();
                }
                void restart()
                {
                    isRunning = true;
                }
                static string WouldYouRather()
                {
                    int randomNumber = 0;
                    string answer = ("");
                    Random random = new Random();
                    randomNumber = random.Next(1, 10);
                    string possibility1 = ("Be able to read minds");
                    string possibility2 = ("Always be right but lose your argument");
                    string possibility3 = ("Be able to teleport");
                    string possibility4 = ("End world hunger");
                    string possibility5 = ("Have a superpower of your choice");
                    string possibility6 = ("Eat a bowl of spiders");
                    string possibility7 = ("Eat a bowl of poop every single day");
                    string possibility8 = ("Not be able to see");
                    string possibility9 = ("Know when you die");
                    string possibility10 = ("Be a Devil");
                    string possibility11 = ("Be invisible");
                    string space = (">------------------------------------------------------------<");
                    string possibility01 = ("be able to talk telepathically?");
                    string possibility02 = ("always be wrong but win your argument?");
                    string possibility03 = ("be able to move things with your mind?");
                    string possibility04 = ("have world peace?");
                    string possibility05 = ("be able to do everything humanly possible?");
                    string possibility06 = ("step on a very sharp and big needle?");
                    string possibility07 = ("break a random bone (Not spine) every single week?");
                    string possibility08 = ("not be able to hear?");
                    string possibility09 = ("how you die?");
                    string possibility010 = ("be a God?");
                    string possibility011 = ("Be invincible");

                    string or = (" or ");
                    string wouldYouRather = ("Would you rather:");

                    switch (randomNumber)
                    {
                        case 1:
                            answer = (space + "\n" + wouldYouRather + "\n" + possibility1 + or + possibility01 + "\n" + space);
                            break;
                        case 2:
                            answer = (space + "\n" + wouldYouRather + "\n" + possibility2 + or + possibility02 + "\n" + space);
                            break;
                        case 3:
                            answer = (space + "\n" + wouldYouRather + "\n" + possibility3 + or + possibility03 + "\n" + space);
                            break;
                        case 4:
                            answer = (space + "\n" + wouldYouRather + "\n" + possibility4 + or + possibility04 + "\n" + space);
                            break;
                        case 5:
                            answer = (space + "\n" + wouldYouRather + "\n" + possibility5 + or + possibility05 + "\n" + space);
                            break;
                        case 6:
                            answer = (space + "\n" + wouldYouRather + "\n" + possibility6 + or + possibility06 + "\n" + space);
                            break;
                        case 7:
                            answer = (space + "\n" + wouldYouRather + "\n" + possibility7 + or + possibility07 + "\n" + space);
                            break;
                        case 8:
                            answer = (space + "\n" + wouldYouRather + "\n" + possibility8 + or + possibility08 + "\n" + space);
                            break;
                        case 9:
                            answer = (space + "\n" + wouldYouRather + "\n" + possibility9 + or + possibility09 + "\n" + space);
                            break;
                        default:
                            Console.WriteLine("You broke");
                            break;
                    }
                    return answer;
                    //Problem
                }
                
                
            }
        }
    }
}
