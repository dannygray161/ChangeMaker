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

            GetChange();
        }
        public static void GetChange()
        {
            bool isPossible = true;
            bool tryAgain = true;


            while (tryAgain)
            {


                while (isPossible)
                {
                    Console.WriteLine("Please enter a dollar amount to receive efficient change: ");
                    double dollarAmount = Convert.ToDouble(Console.ReadLine());


                }
                Console.WriteLine("Would you like to try again? Y/N: ");



            }

        }
    }
}
