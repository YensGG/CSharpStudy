using System;

namespace Brackyboi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 10; i > -1; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(100);
            }
            
            Console.Write("How many cool numbers do you want: ");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= count; i++)
            {
                double result = Math.Pow(2, i);
                System.Threading.Thread.Sleep(50);
                Console.WriteLine(result);
            }
            */
            Random numberGen = new Random();

            int roll1 = 0;
            int roll2 = 1;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the dice.");

            while (roll1 != roll2){
                Console.ReadKey();

                roll1 = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll1 + " and a " + roll2);
                attempts++;
            }
            
            Console.WriteLine("It took you " + attempts + " attempts to roll a pair.");

            Console.ReadKey();
        }
    }
}
