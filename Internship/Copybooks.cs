using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    class Copybooks:Information
    {
        public Copybooks()
        {
            read = "        FORMULA ONE  \n " +
                "Formula One automobile racing has its roots in \n" +
                "the European Grand Prix championships of the 1920s and 1930s, \n " +
                "though the foundation of the modern Formula One began in 1946 \n " +
                "with the Fédération Internationale de l'Automobile's (FIA)  \n" +
                "standardisation of rules, which was followed by a World  \n" +
                "Championship of Drivers in 1950 The sport's history parallels the \n" +
                " evolution of its technical regulations.";
        }
        public Copybooks(string text)
        {
            read = text;
        }

        public string Read { get => read; }
    }
}
