using System;

namespace MetotCalism
{
    class Program
    {
        static void Main(string[] args)
        {
            //out keyword
            
            Console.WriteLine("---Outkys------");


            int number= 25;
            int number2 = 35;

            var result =  Add(out int number1, number2);
            Console.WriteLine(result);

            static int Add(out int number1,int number2)
            {
                number1 = 28;
                return number1 + number2;
            }

        }
    }
}
