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
            Console.WriteLine("Please enter a dollar amount to receive efficient change: ");
            double dollarAmount = Convert.ToDouble(Console.ReadLine());
            

            
        }
    }
}
