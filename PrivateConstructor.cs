using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class PrivateConstructor
    {
        private static PrivateConstructor _instance;
        private PrivateConstructor() { }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public static PrivateConstructor GetInstance() 
        {
            if (_instance == null)
            {
                _instance = new PrivateConstructor();
            }
            return _instance;
        }
    }
    class Demo
    {
       public static void Main(string[] args)
        {
            int a = 45;
            int b = 100;
            PrivateConstructor obj=PrivateConstructor.GetInstance();
            int res=obj.Sum(a, b);
            Console.WriteLine(res);

        }
    }
     
}
