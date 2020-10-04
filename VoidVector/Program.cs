using System;

namespace VoidVector
{
    /*  TO DO LIST:
    - Add dialogue set for Asmongold, 

    */
    
    class Sector
    {
        public string sectorName;
        public string sectorSection;
        public int sectorSecurity;
        public int sectorPopulation;
    }
    
    class Planet
    {
        public string planetName;
        public int planetEco;
        public float planetSize;
        public float planetTemp;
        public float planetPop;
        public int planetCount = 1;
        
        public Planet()
        {
            
        }

        public void Scan()
        {
            Console.WriteLine(planetName + planetEco + planetSize + planetTemp + planetPop);
        }

        public void SystemScan()
        {
            Console.WriteLine("Your scan reads " + planetCount + " planetoids in this system.");
        }
    }
    
    class Player
    {
        public string shipName;
        public string shipClass;
        public string shipAIname;
        public bool shipAI;
        public int shipShield = 100;
        public int shipHull = 78;
        public int shipFuel = 400;
        public int shipCargo;
        public int shipCargoCapacity;
        public string answer;

        public void PlayerShip(string _shipName, string _shipClass)
        {
            shipName = _shipName;
            shipClass = _shipClass;
        }
        
        public void CommandList()
        {
            Console.WriteLine("\nYour options are:");
            Console.WriteLine("SectorScan");
            Console.WriteLine("SystemScan");
            Console.WriteLine("ConsultAI");
            Console.WriteLine("ShipStatus");
            Console.WriteLine("ShipCargo");
        }
        public void ConsultAI()
        {
            
            Console.WriteLine(shipAIname + " is processing.");System.Threading.Thread.Sleep(300);Console.Write(" . ");
            System.Threading.Thread.Sleep(300);Console.Write(" . ");System.Threading.Thread.Sleep(300);Console.Write(" . \n");
            System.Threading.Thread.Sleep(300);Console.Write(" . ");System.Threading.Thread.Sleep(300);Console.Write(" . ");
            System.Threading.Thread.Sleep(300);Console.Write(" . \n\n");
            Console.WriteLine(shipAIname + " tells you:\n");
             System.Threading.Thread.Sleep(1400);
            Console.WriteLine("Sometimes you get it.");
            System.Threading.Thread.Sleep(500);Console.Write(" . ");System.Threading.Thread.Sleep(500);Console.Write(" . ");System.Threading.Thread.Sleep(500);Console.Write(" . ");
            Console.WriteLine("\nSometimes you get got.\n");
        }
        public void SectorScan()
        {
            // DEMO, FIX LATER
            Console.WriteLine("\nSector Z11.10. You are currenlty located in the SouthWest Reagion");
            Console.WriteLine("Sector contains 57 Star Systems.");
            Console.WriteLine("Star Systems:\n[ 62% Binary Systems ]\n[ 38% Mono Systems ]\n");
            Console.WriteLine("[ Sector Population: 33.205.329 ]\n[ Sector Security: 0.3 ]\n");
        }
        public void SystemScan()
        {
            
        }
        public void ShipStatus()
        {
            Console.WriteLine("\nYour " + shipClass + " " + shipName + " status:");
            Console.WriteLine("Shields: " + shipShield + " / 100 Capacity.");
            Console.WriteLine("Shields: " + shipShield + " / 100 Capacity.");
            Console.WriteLine("Hull: " + shipHull + " / 100 Capacity.");
            Console.WriteLine("Fuel: " + shipFuel + " / 1000 Capacity.");
            Console.WriteLine("Cargo: " + shipCargo + " / " + shipCargoCapacity + " Capacity.");
        }
        public void ShipCargo()
        {
            Console.WriteLine("The cargobay of " + shipName + " contains:");
        }

        /* Not sure if making the fork a function is appropriate,
        but previously my solution has been unlimited switches in main so not sure what to do. */
        public void Fork (string answer)
        {
            switch (answer)
            {
                case "CommandList":
                CommandList();
                break;
                case "SectorScan":
                SectorScan();
                break;
                case "SystemScan":
                SystemScan();
                break;
                case "ShipStatus":
                ShipStatus();
                break;
                case "ConsultAI":
                ConsultAI();
                break;
                default:
                Console.WriteLine("Invalid Response..");
                break;
            }
            // answer = Console.ReadLine();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Change Console Appearance
            Console.Title = "Void Vector";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WindowWidth = 80;
            Console.WindowHeight = 50;
            
            Random rng = new Random();
            
            int gameSeed = rng.Next(10, 1000);
            int seedPlanets = rng.Next(1, 15);
            int seedStars = rng.Next(1, 4);
            int seedPOI = rng.Next(1, 8);

            Player player = new Player();
            
            Planet planet01 = new Planet();
            Planet planet02 = new Planet();
            Console.WriteLine("DEBUG GAME STATISTICS:");
            Console.WriteLine("Game Seed: " + gameSeed);
            Console.WriteLine("Planets: " + seedPlanets);
            Console.WriteLine("Stars: " + seedStars);
            Console.WriteLine("Points Of Interests: " + seedPOI + "\n\n");
            
            // Pre Game Settings
            Console.Write("Please input the name of your ship: ");
            player.shipName = Console.ReadLine();
            Console.Write("\nNow choose your ship class, you can choose between: \n'Interceptor'\n'Hauler'\n'Explorer'" + "\nClass: ");
            player.shipClass = Console.ReadLine();
            Console.Write("Enter the name for your ship AI: \n");
            player.shipAIname = Console.ReadLine();

            System.Threading.Thread.Sleep(600);
            Console.Write("\n\nGenerating Sector");
            System.Threading.Thread.Sleep(300);Console.Write(" . ");System.Threading.Thread.Sleep(100);Console.Write(" . ");System.Threading.Thread.Sleep(200);Console.Write(" . ");
            System.Threading.Thread.Sleep(200);Console.Write(" . ");System.Threading.Thread.Sleep(100);Console.Write(" . ");System.Threading.Thread.Sleep(100);Console.Write(" . ");
            System.Threading.Thread.Sleep(100);Console.Write(" . ");System.Threading.Thread.Sleep(100);Console.Write(" . ");System.Threading.Thread.Sleep(200);Console.Write(" . ");
            System.Threading.Thread.Sleep(200);Console.Write(" . ");System.Threading.Thread.Sleep(100);Console.Write(" . ");System.Threading.Thread.Sleep(100);Console.Write(" . ");
            System.Threading.Thread.Sleep(800);
            Console.Write("Done.\n\n\n");
            System.Threading.Thread.Sleep(500);

            // Game start
            Console.WriteLine("\n\nYou exit from hyperspace in unknown territory.\nWhat would you like to do?\n\nWrite 'CommandList' to review your options.\n");
            string answer = Console.ReadLine();
            
            // Fork 1
            player.Fork(answer);
            
            // Wait for user input before exiting.
            Console.ReadKey();

            // Make Death Screen Scenario for: NO FUEL + NO HULL.s
        }
    }
}
