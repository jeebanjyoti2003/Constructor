using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Constructor
{
    internal class StaticConstructor
    {
       public static int Id;
      public static string Name;
         static StaticConstructor()
        {
            Console.WriteLine("Static Constructor Called .");
            Id = 23;
            Name = "Bapu";
        }
        public StaticConstructor()
        {
            Console.WriteLine("Default Constructor Called .");
        }

        public StaticConstructor(int id, string name)
        {
            Id=id;
            Name=name;
            Console.WriteLine("Private Constructor Called ."+Id +" "+Name);
        }
    }
    class staticDemo
    {
        public static void Main() 
        {
            Console.WriteLine( StaticConstructor.Id + " " + StaticConstructor.Name);
            StaticConstructor obj = new StaticConstructor(67,"Jata");
            Console.WriteLine( StaticConstructor.Id + " " +StaticConstructor. Name);

        }
    }
}
