using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class CopyConstuctor
    {
       public int Id;
       public string Name;
       public int Age;

        public CopyConstuctor() { }
        public CopyConstuctor(CopyConstuctor copy)
        {
            Id = copy.Id;
            Name = copy.Name;
            Age = copy.Age;
        }

        static void Main(string[] args)
        {
            CopyConstuctor obj = new CopyConstuctor();
            obj.Id = 10;
            obj.Name = "test";
            obj.Age = 23;
            CopyConstuctor obj1=new CopyConstuctor(obj);
            obj1.Id = 26;
            Console.WriteLine(obj.Id);
        }
    }
}
