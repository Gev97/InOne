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
            while (true)
            {


                double number;
                string s_number, reverse = "";
                Console.WriteLine("Enter number ");
                number = double.Parse(Console.ReadLine());
                s_number = number.ToString();
                for (int i = s_number.Length - 1; i >= 0; i--)
                {
                    reverse += s_number[i].ToString();
                }
                if (reverse == s_number)
                {
                    Console.WriteLine("It is polindrome");
                }
                else
                {
                    Console.WriteLine("It is not polindrome");

                }
            }
        }
    }
}
