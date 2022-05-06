using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    internal class Swap
    {
        public void swapping()
        {
            int a = 5, b = 10, c;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            c = a;      
            a = b;     
            b = c;       
            Console.Write("After swap a= " + a + " b= " + b);
        }

    }
}
