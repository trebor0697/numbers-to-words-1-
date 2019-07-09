using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        static string Numbersintowrds(int number)
        {
            if (number == ) return "zero";

            if (number < 0) return "minus" + Numbersintowrds(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0) ;
            {
                words += Numbersintowords(number / 1000000) + "million";
                number %= 1000000;
            }

            if ((Numbersintowords / 1000) > 0)
            {

                words += Numbersintowords(Numbersintowords / 1000) + "thousand");
                number %= 10000;
            }

            if((number / 100)>
        }
    }
}
