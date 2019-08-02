using System;
using System.Text;
namespace Read_or_Write
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, desicion="";
            Copybooks cb = new Copybooks();
            Notebooks nb = new Notebooks();
            Journals jr = new Journals();
            Book b = new Book();
            while (desicion!="exit")
            {
                Console.WriteLine("Read,Write or Exit (1,2,exit)");
                desicion = Console.ReadLine();
                if (desicion == "1")
                {
                    Console.WriteLine("Copybook,Notebook,Journal,Book (1,2,3,4)");
                    desicion = Console.ReadLine();
                    if (desicion == "1")
                    {
                        cb.Reading();
                    }
                    else if (desicion == "2")
                    {
                        nb.Reading();
                    }
                    else if (desicion == "3")
                    {
                        jr.Reading();
                    }
                    else if (desicion == "4")
                    {
                        b.Reading();
                    }
                    else { Console.WriteLine("Wrong number"); }
                }
                else if (desicion == "2")
                {
                    Console.WriteLine("Write your text");
                    text = Console.ReadLine();
                    Console.WriteLine("Copybook or Notebook, (1,2)");
                    desicion = Console.ReadLine();
                    if (desicion == "1")
                    {
                        cb.Writing(text);
                    }
                    else if (desicion == "2")
                    {
                        nb.Writing(text);
                    }
                    else { Console.WriteLine("Wrong number"); }
                }
                else { Console.WriteLine("Wrong number"); }
            }
        }
    }
}
