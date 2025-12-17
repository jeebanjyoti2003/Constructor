using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class DefaultConstructor
    {
        public string Name;
        public DefaultConstructor() { }
        static void Main(string[] args)
        {
            DefaultConstructor instance = new DefaultConstructor();
            instance.Name = "Bapu";
            Console.WriteLine("Hello"+instance.Name);
        }
    }
}
