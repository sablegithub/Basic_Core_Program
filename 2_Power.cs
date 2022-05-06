using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    internal class _2_Power
    {
        //int x1=0;
        public void Power()
        {
            int y = 2;
            Console.WriteLine("Enter a Number");
            int x = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Enter a number");
            //  int z= int.Parse(Console.ReadLine());
          
            for(int i = 1; i < x; i++)
            {
                
                    int result = (int)Math.Pow(i, y);
                    Console.WriteLine(result);
                if(i==x)
                {
                    Console.WriteLine("Hellow");
                }
            }

                  //  int result = (int)Math.Pow(x1, y);
                  //  Console.WriteLine(result);








        }
    }
}
