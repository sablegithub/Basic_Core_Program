using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    internal class Leap_Year
    {
        public void leapyear()
        {
        
            
                Console.WriteLine("Enter Year : ");
                int Year = int.Parse(Console.ReadLine());

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine(Year +" is a Leap Year.");
            }
            else
            {
                Console.WriteLine(Year +" is not a Leap Year.");
            }

                Console.ReadLine();
            
        
        }

    }
}
