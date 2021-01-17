using System;
using System.Collections.Generic;
using System.Text;

namespace MetotCalism
{
    class RefKeys
    {
        static void Main(string[] args)
        {
            //ref keyword

            Console.WriteLine("---Refskey------");


            int number1 = 15;
            int number2 = 35;

            var result = Add(ref number1, number2);
            Console.WriteLine(result);

            static int Add(ref int number1, int number2)
            {
                number1 = 28;
                return number1 + number2;
            }

























        }
    }
}