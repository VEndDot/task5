using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Elephant
    {
        public string Name;
        public int EarSize;
        public void WhoAmI()
        {
            Console.WriteLine("Calling " + Name + ".WhoAmI()");
            Console.WriteLine("My name is " + Name);
            Console.WriteLine("My ears are " + EarSize + " inches tall\n");

        }
    }
}
