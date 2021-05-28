using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // an efficient change calculator that does not include half dollars.
            bool isPossible = true;
            bool tryAgain = true;

            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };



            while (tryAgain)
            {


                while (isPossible)
                {
                    Console.WriteLine("Please enter a dollar amount to receive efficient change: ");
                    double dollarAmount = Convert.ToDouble(Console.ReadLine());

                    if (dollarAmount < .1 || dollarAmount == 0)
                    {
                        Console.WriteLine("I am sorry, that is an invalid Selection");
                        isPossible = false;
                    }
                    else if (dollarAmount.ToString().Contains(" "))
                    {
                        Console.WriteLine("I am sorry, that is an invalid Selection");
                        isPossible = false;
                    }
                    else
                    {

                        GetChange(dollarAmount);
                        isPossible = false;
                    }


                }


                Console.WriteLine("Would you like to try again? Y/N: ");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    isPossible = true;
                    tryAgain = true;
                }
                else
                {
                    Console.WriteLine("Thank you for using my change calculator!!");
                    tryAgain = false;
                }


            }
            Console.ReadLine();
        }
        public static void GetChange(double dollarAmount)
        {
            int oneHundreds = 0;
            int fifties = 0;
            int twenties = 0;
            int tens = 0;
            int fives = 0;
            int ones = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;

            oneHundreds = (int)(dollarAmount / 100);
            dollarAmount %= 100;
            fifties = (int)(dollarAmount / 50);
            dollarAmount %= 50;
            twenties = (int)(dollarAmount / 20);
            dollarAmount %= 20;
            tens = (int)(dollarAmount / 10);
            dollarAmount %= 10;
            fives = (int)(dollarAmount / 5);
            dollarAmount %= 5;
            ones = (int)(dollarAmount / 1);
            dollarAmount %= 1;
            quarters = (int)(dollarAmount / .25);
            dollarAmount %= .25;
            dimes = (int)(dollarAmount / .10);
            dollarAmount %= .10;
            nickels = (int)(dollarAmount / .05);
            dollarAmount %= .05;
            pennies = (int)(dollarAmount / .01);
            dollarAmount %= .01;

            Console.WriteLine($"Your change is: {oneHundreds} $100's, {fifties} $50's, " +
                $"{twenties} $20's, {tens} $10's, {fives} $5's, " +
                $"{ones} $1's, {quarters} quarters, {dimes} dimes, {nickels} nickels, and {pennies} pennies.");





        }

    }
}
