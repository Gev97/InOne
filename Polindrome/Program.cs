using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; // our number
            Console.WriteLine("Enter number ");
            number = int.Parse(Console.ReadLine());

            Polindrome(number);
            
        }
        public static void Polindrome(int number)
        {
            int reverse = 0;
            while (number > reverse)
            {
                reverse = reverse * 10 + number%10;
                number = number / 10;
              
            }
            if (number == reverse || number == reverse / 10)
                Console.WriteLine("Number is palindrome ");
            else
                Console.WriteLine("Number is not palindrome");
        }
    }

}
