using System;

namespace PerfectNumberProject.Domain
{
    public class PerfectNumberClass
    {
        public int Number { get; set; }

        public PerfectNumberClass(int number)
        {
            Number = number;
        }

        public bool IsPerfectNumber(int number)
        {

            if (number < 0 || number > 10000)
                throw new Exception("This value a invalid number to this service");


            int sum = 0;
            int i = 1;

            while (i < number)
            {
                if (number % i == 0)
                    sum += i;

                ++i;
            }

            return sum == number;
        }

    }
}

