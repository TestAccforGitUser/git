using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstract
{
   abstract class Element 
    {
        public string Name { get; set; }
        public Element(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
}
