using System;

namespace BrackeyClasses
{
    // CLASS: Wizard
    class Wizard
    {
        public string name;
        public string favoriteSpell;
        private int spellSlots;
        private float experience;

        public static int wizardCount;

        // CONSTRUCTOR : Wizard
        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experience = 0f;

            wizardCount++;
        }

        // FUNCTION / METHOD: Spellcast
        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
                experience += 0.3f;
            } else
            {
                Console.WriteLine(name + " is out of spell slots.");
            }
        }
        
        // FUNCTION / METHOD: Meditate
        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots.");
            spellSlots = 2;
        }
    }   

    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Parry Hopper", "Unextpeco Erecto");

            wizard01.CastSpell(); 
            
            Wizard wizard02 = new Wizard("Bracki Magikki", "Abra cadavra");
 
            wizard02.CastSpell(); 

            Console.WriteLine(Wizard.wizardCount);
            
            // Wait for user input to exit.
            Console.ReadKey();
        }
    }
}
