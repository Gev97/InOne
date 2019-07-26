using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equally
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("enter value for a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value for b");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a="+a+" and "+" b="+b);
        
        }
    }
}
