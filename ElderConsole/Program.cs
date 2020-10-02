using System;

namespace ElderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change Console Appearance
            Console.Title = "ElderConsole";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WindowWidth = 80;
            Console.WindowHeight = 50;
            
            // My variables
            int num01;
            int num02;
            int myCash;
            
            
            // Introduction
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("A void of darkness dissapears...\n");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("You regain consciousness.\n");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("For a moment everything is blurry,\nbut you manage to make out something.\n");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("You stand before a tall slender, wooden door.\n");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("As you try to push it open,\na robotic voice appears from a panel on the side of the door.\n");

            // Dialogue Start
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("What is your name stranger?");
            string userName = Console.ReadLine();

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Hello " + userName + ", i greet you.\n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("I am IEC.6232¤ee.7.03.\nBut you can call me Dave.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nBefore we proceed,\ni need to gauge your intelligence level.");
            System.Threading.Thread.Sleep(3000);

            Console.Write("Please input a number.. \n");
            num01 = Convert.ToInt32( Console.ReadLine() );
            System.Threading.Thread.Sleep(1000);

            Console.Write("Input a second number please..\n");
            num02 = Convert.ToInt32( Console.ReadLine() );
            System.Threading.Thread.Sleep(2000);

            // Int. Test
            int testResultA = num01 * num02;
            Console.WriteLine("Now multiply these two numbers and then divided by two.\n");
            int testResultB = testResultA / 2;
            int answer = Convert.ToInt32( Console.ReadLine() );     // User Response
            
            // *Processing*
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(". ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(". ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(". ");
            
            if (answer == testResultB )
            {
                // Right = No Admission Fee
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Not bad, your intelligence level is that of a newborn Grïhldæk.\n We can work with this.\n");
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("Your admission to the guild has been granted.");
            }
            else
            {
                // Wrong = Admission Fee
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Your answer is very incorrect.\n");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("In fact, it's so incorrect i might subject you\nto deresolution in 6 seconds..\n");
                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("I have decided not to erase you just yet.\n");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("the entry fee is 30 Credits.\nWould you like to proceed?");
                string userAnswer = Console.ReadLine();     // User Response
                
                string yes = "yes";

                if (userAnswer == yes )
                {
                    myCash = 70;
                    int entryFee = 30;
                    myCash = myCash - entryFee;
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("You pay 30 credits.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You currently have " + myCash + " credits left.\n");
                }
                else
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("That's unfortunate.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Good day...");
                    
                    // *Processing*
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(". ");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(". ");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(". ");
                    System.Threading.Thread.Sleep(500);

                    // Exits Console Application
                    System.Environment.Exit(1);
                }
            }

            // Admission
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("You enter the guild...");
            
            // *Processing*
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(". ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(". ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(". ");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Your journey has begun...");
            
            Console.ReadKey();      // Press key to exit.
        }
    }
}
