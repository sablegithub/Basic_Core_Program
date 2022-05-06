// See https://aka.ms/new-console-template for more information

namespace basic_core_program
{
    class Program
    {
        // int num = 0;
        //int Per = 0;
        // int Totalnumber = 0;
        public static void Main(String[] args)
        {
            Random rnd = new Random();
            int result = rnd.Next(0, 2);



            if (result < 0.5)
            {
                Console.WriteLine("Tails!");

            }
            else if (result == 1)
            {
                Console.WriteLine("Heads!");

            }

            Leap_Year ly = new Leap_Year();
            ly.leapyear();
            _2_Power p =new _2_Power();
            p.Power();
            Even_Odd ED = new Even_Odd();
            ED.evenodd();
            vowel v = new vowel();
            v.vowel_Constrant();
            Swap s=new Swap();
            s.swapping();
        }

    }
}


