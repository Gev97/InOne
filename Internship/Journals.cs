using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    class Journals : Information
    {
        public Journals()
        {
            read = "        INHERITANCE in c#  \n" +
                " One of the most important concepts in \n " +
                "object-oriented programming is inheritance. \n" +
                "Inheritance allows us to define a class in terms of another class, \n" +
                "which makes it easier to create and maintain an application. \n";
        }

        public string Read { get => read; }
    }
}
