using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_or_Write
{
    class Notebooks
    {
        string text = "You are reading from Notebook";

        

        public void Reading()
        {
            Console.WriteLine(text);
        }

        public void Writing(string text)
        {
            this.text = text;
        }
    }
}
