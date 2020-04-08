using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorNumeroRomano
{
    public class ConversorDeNumeroRomano
    {
       public int Number { get; set; }

        public ConversorDeNumeroRomano(int number)
        {
            Number = number;
        }

        public string ToRoman( int number)
            {
                if (number < 0 || number > 3999)
                    throw new Exception("This value is to small / large to be converted.");
                if (number < 1)
                    return "";
                string value = string.Empty;
                if (number >= 1000)
                {

                    return "M" + ToRoman(number - 1000);
                }
                if (number >= 900)
                {
                    return "CM" + ToRoman(number - 900);
                }
                if (number > 500)
                {

                    return "D" + ToRoman(number - 500);
                }
                if (number >= 400)
                {
                    return "CD" + ToRoman(number - 400);
                }
                if (number >= 100)
                {

                    return value += "C" + ToRoman(number - 100);
                }
                if (number >= 90)
                {
                    return value += "XC" + ToRoman(number - 90);
                }
                if (number >= 50)
                {

                    return value += "L" + ToRoman(number - 50);
                }
                if (number >= 40)
                {
                    return value += "XL" + ToRoman(number - 40);
                }
                if (number >= 10)
                {

                    return value += "X" + ToRoman(number - 10);
                }
                if (number >= 9)
                {

                    return value += "IX" + ToRoman(number - 9);
                }
                if (number >= 5)
                {

                    return value += "V" + ToRoman(number - 5);
                }
                if (number >= 4)
                {

                    return value += "IV" + ToRoman(number - 4);
                }
                if (number >= 1)
                {

                    return value += "I" + ToRoman(number - 1);
                }
                return string.Empty;
            }
        
    }
}

