using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                string name = NumberToWordConvertor(Console.ReadLine());
                Console.WriteLine(name);
                Console.Write("Do you want to cotinue press Y or else press any key to exit");
                if (Console.ReadLine() == "Y")
                    continue;
                else
                    break;
            }
        }

        public static string NumberToWordConvertor(string number)
        {
            string word = string.Empty;
            string[] d = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] dd = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] d0 = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            long num = Convert.ToInt64(number);

            switch (number.Length)
            {
                case 1:
                    word = d[num];
                    return word;
                case 2:
                    word = num % 10 == 0 ? d0[num / 10] : (num < 20 ? dd[num % 10] : d0[num / 10] + " " + d[num % 10]);
                    return word;
                case 3:
                    word = d[num / 100] + " hundred " + NumberToWordConvertor(Convert.ToString(num % 100));
                    return word;
                case 4:
                    word = d[num / 1000] + " thousand " + NumberToWordConvertor(Convert.ToString(num % 1000));
                    return word;
                case 5:
                case 6:
                    word = NumberToWordConvertor(Convert.ToString(num / 1000)) + " thousand " + NumberToWordConvertor(Convert.ToString(num % 1000));
                    return word;
                case 7:
                case 8:
                case 9:
                    word = NumberToWordConvertor(Convert.ToString(num / 1000000)) + " million " + NumberToWordConvertor(Convert.ToString(num % 1000000));
                    return word;
            }

            return word;
        }
    }
}
