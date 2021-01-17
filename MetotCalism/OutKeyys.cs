using System;
using System.Collections.Generic;
using System.Text;

namespace MetotCalism
{
    class OutKeyys
    {

        static void Main(string[] args)
        {
            //out keyword

            Console.WriteLine("---Outkys------");


            int number;
            int number2 = 35;

            var result = Add(out int number1, number2);
            Console.WriteLine(result);

            static int Add(out int number1, int number2)
            {
                number1 = 28;
                return number1 + number2;
            }

        }
    }
}






    }

}
