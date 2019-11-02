using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstract
{
    class AudioElement : Element
    {
        public AudioElement(string name) : base(name)
        {
            Display();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
