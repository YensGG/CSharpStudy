using System;

namespace BrackyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] pots = {"Minor Healing Potion", "Greater Healing Potion", "Minor Mana Potion", "Stamina Potion", "Debuff Elixir"};
            
            for (int i = 0; i < pots.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + pots[i]);
            }
            */

            /*
            Console.WriteLine("How many items would you like to buy?");
            int buyAmount = Convert.ToInt32(Console.ReadLine());
            */

            string[] pots = new string[5];

            Console.WriteLine("Type in 5 potions: ");

            for (int i = 0; i < pots.Length; i++)
            {
                pots[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Here is your potions, alphabetically: ");
   
            Array.Sort(pots);

            for (int i = 0; i < pots.Length; i++)
            {
                Console.WriteLine(pots[i]);
            }

            // Wait for input to exit.
            Console.ReadKey();
        }
    }
}
