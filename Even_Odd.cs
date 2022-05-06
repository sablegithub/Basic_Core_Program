using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    internal class Even_Odd
    {
        public void evenodd()
        {
            Console.WriteLine("Enter a Number");
            int i=int.Parse(Console.ReadLine());
            if((i%2)==0)
            {
                Console.WriteLine("Even number");

            }
            else
            {
                Console.WriteLine("Odd Number");
            }

        }
    }
}
