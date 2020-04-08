using System;

namespace FactorialNumberProject.Domain
{
    public class FactorialNumber
    {
        public int Number { get; set; }

        public FactorialNumber(int number)
        {
            Number = number;
        }

        public int FactorialNumberCalc(int number)
        {
            if (number < 0 || number > 30)
                throw new Exception("This value is out of the range");

            int fatorial = 1;
           
            for (int i = Number;  i<=1 ; i--)
            {
                fatorial *= i;
            }
            return fatorial;
        }

    }
}
