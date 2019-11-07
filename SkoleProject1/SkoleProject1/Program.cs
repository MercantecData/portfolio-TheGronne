using System;

namespace SkoleProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] array = new string[input];
            int currentName = 0;
            bool arrayIsFull = false;
            int arrayName = 0;
            while (currentName < input)
            {
                string name = (Console.ReadLine());
                array[currentName] = name;
                currentName++;
                if (currentName == input)
                {
                    arrayIsFull = true;
                }
            }
            while (arrayIsFull = true)
            {
                Console.WriteLine(array[arrayName]);
                arrayName++;
                
            }
        }
    }
}
