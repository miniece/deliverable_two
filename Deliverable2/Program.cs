using System;
using System.ComponentModel.Design;
using System.Security.Authentication;

namespace Buffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;

            while (!valid)
            {

                Console.WriteLine("Hi. Welcome to the buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, only parties of 6 or lower.");
                int partySize = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                //calculations//
                double buffetPrice = 9.99;
                double totalBuffetPrice = buffetPrice * partySize;
                double waterPrice = 0.00;
                double coffeePrice = 2.00;
                int partyCounter = 0;
                int waterCounter = 0;
                int coffeeCounter = 0;


                if (partySize <= 6)
                {
                    Console.WriteLine("A table for " + partySize + "! Please follow me and take a seat.");
                    Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");
                    Console.WriteLine("");
                    // possible if statement, works for party size 1, not for 2. not sure if correct way to do this //
                    while (partyCounter < partySize)
                    {
                        partyCounter++;
                        Console.WriteLine("Alright person " + partyCounter + ", water or coffee?");
                        string drinkChoice = Console.ReadLine();
                        if (drinkChoice == "water" || drinkChoice == "Water")
                        {
                            waterCounter++;
                            Console.WriteLine(drinkChoice + ", excellent choice!");
                            Console.WriteLine("");
                        }
                        else if (drinkChoice == "coffee" || drinkChoice == "Coffee")
                        {
                            coffeeCounter++;
                            Console.WriteLine(drinkChoice + ", coming right up!");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, we don't serve that. No drink for you!");
                            Console.WriteLine("");
                        }



                    }
                    // total bill calculations //
                    double totalCoffeePrice = coffeePrice * coffeeCounter;
                    double totalWaterPrice = waterPrice * waterCounter;
                    double totalBill = totalBuffetPrice + totalCoffeePrice + totalWaterPrice;

                    Console.WriteLine("Okay, so that is, " + coffeeCounter + " coffees and " + waterCounter + " waters. I'll be right back. Feel free to grab your food!");
                    Console.WriteLine("");
                    Console.WriteLine("Okay, so here is your bill! Total price is $" + totalBill);
                    break;
                }

                else
                {
                    Console.WriteLine("Sorry, we can only allow parties up to 6. Have a nice day!");
                    valid = true;
                }

            }



        }
    }
}
