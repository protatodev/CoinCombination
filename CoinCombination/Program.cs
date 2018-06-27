using System;
using System.Collections.Generic; 

namespace CoinCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            Accountant coinApp = new Accountant();
            coinApp.displayMenu();
        }
    }

    // Build Coin Dictionary
    public class Coins
    {
        public static string[] CoinKeys = { "Quarters", "Dimes", "Nickels", "Pennies" };
        public static int[] CoinValues = { 25, 10, 5, 1 };

    }

    public class Accountant
    {
        // Build console window that shows menu
        public void displayMenu()
        {
            Console.WriteLine("Enter An Option: (C)alculate Change / (Q)uit");
            string choice = Console.ReadLine();

            if(choice.ToLower() == "c")
            {
                calculateCoins();
            } else if(choice.ToLower() == "q")
            {
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("That was not a valid option!");
                displayMenu();
            }
        }

        public void calculateCoins()
        {
            Console.WriteLine("Enter Cents: ");
            int cents = int.Parse(Console.ReadLine());
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;

            while(cents > 0)
            {
                for(int i = 0; i < Coins.CoinKeys.Length; i++)
                {
                    if(cents >= Coins.CoinValues[i])
                    {
                        cents -= Coins.CoinValues[i];

                        if(Coins.CoinValues[i] == 25)
                        {
                            quarters += 1;
                        } else if(Coins.CoinValues[i] == 10)
                        {
                            dimes += 1;
                        } else if(Coins.CoinValues[i] == 5)
                        {
                            nickels += 1;
                        } else
                        {
                            pennies += 1;
                        }
                    } 
                }
            }

            displayResults(quarters, dimes, nickels, pennies);
        }

        public void displayResults(int quarters, int dimes, int nickels, int pennies)
        {
            Console.WriteLine("*** Results ***");
            Console.WriteLine("* Quarters: " + quarters);
            Console.WriteLine("* Dimes: " + dimes);
            Console.WriteLine("* Nickels: " + nickels);
            Console.WriteLine("* Pennies: " + pennies);

            displayMenu();
        }
    }

}
