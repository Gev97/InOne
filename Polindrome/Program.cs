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


                double number; // our number
                string s_number, reverse = ""; 
                Console.WriteLine("Enter number ");
                number = double.Parse(Console.ReadLine()); 
                s_number = number.ToString(); // changing to string 

                // making reverse of that string
                for (int i = s_number.Length - 1; i >= 0; i--)
                {
                    reverse += s_number[i].ToString();
                }

                //chaking if polindrome
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
