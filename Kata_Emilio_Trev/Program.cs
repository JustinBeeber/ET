using System;

namespace Kata_Emilio_Trev
{
    public class String_Calculator
    {
        static void Main(string[] args)
        {
        }

        public int TestCalculator(string input)
        {
            if (input == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(input);
            }
          

        }

       
    }
}
