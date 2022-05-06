using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    internal class vowel
    {
        
       public  void vowel_Constrant()
        {
            Console.Write("Input an Alphabet  : ");
           char  ch = Convert.ToChar(Console.ReadLine().ToLower());

            if ( ch == 'a' || ch == 'e' ||  ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch +  "is vowel");

            }
            else
            {
                Console.WriteLine(ch +  "is constrant");
            }
        }
    }
}
