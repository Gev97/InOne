using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    class Notebooks : Information
    {
        public Notebooks()
        {
            read = "            WIKIPEDIA  \n "  +
                "A laptop computer (also shortened to just laptop; \n" +
                "or called a notebook computer) \n " +
                "is a small,portable personal computer (PC) with a clamshell form factor, \n " +
                " portable personal computer (PC) with a clamshell form factor, \n " +
                "typically having a thin LCD or LED computer screen mounted on the inside of \n" +
                " the upper lid of the clamshell and an alphanumeric keyboard on \n" +
                " the inside of the lower lid \n";

        }
        // constructor for changing the text
        public Notebooks(string text)
        {
            read = text;
        }
        
        public string Read { get => read; }
    }
    }
