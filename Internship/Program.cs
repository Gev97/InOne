using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    class Program
    {
        static void Main(string[] args)
        {Books books = new Books();
            Journals journals = new Journals();
            Notebooks notebooks = new Notebooks();
            Copybooks copybooks = new Copybooks();

            string stop = "";
            string decision;
            string type;
            string text;
            while (stop != "STOP")
            {
                Console.WriteLine("Read or Write ?");
                decision = Console.ReadLine();
                decision = decision.ToLower();

                if (decision == "read")
                {

                    Console.WriteLine("Book,Journal,Notebook,Copybook ?");
                    type = Console.ReadLine();
                    type = type.ToLower();
                    switch (type)
                    {
                        case "book":
                            
                            books.Read_text(books.Read);
                            break;
                        case "journal":
                            
                            journals.Read_text(journals.Read);
                            break;
                        case "notebook":
                           
                            notebooks.Read_text(notebooks.Read);
                            break;
                        case "copybook":
                           
                            copybooks.Read_text(copybooks.Read);
                            break;


                        default:
                            Console.WriteLine("Wrong name");
                            break;
                    }

                }

                else
                {
                    Console.WriteLine("Notebook or Copybook ?");
                    type = Console.ReadLine();
                    type = type.ToLower();
                    switch (type)
                    {
                        case "notebook":
                            Console.WriteLine("Type some text");
                            text = Console.ReadLine();
                            notebooks = new Notebooks(text);
                            break;

                        case "copybook":
                            
                            Console.WriteLine("Type some text");
                            text = Console.ReadLine();
                            copybooks = new Copybooks(text);
                            break;


                        default:
                            Console.WriteLine("Wrong name");
                            break;
                    }


                }
                Console.WriteLine();
                Console.WriteLine("Type STOP to stop or press Enter to continue !!!");
                stop = Console.ReadLine();
            }
        }
    }
}
