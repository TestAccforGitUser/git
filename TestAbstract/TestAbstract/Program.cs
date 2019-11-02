using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player(new AudioElement("audio"));
            Player pl2 = new Player(new VideoElement("video"));
            Console.WriteLine("////////");
            Console.ReadLine();
        }
    }
}
