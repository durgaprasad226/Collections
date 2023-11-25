using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Generics1
    {
        public bool Compare(int a, int b)
        {
            if (a == b) 
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Generics1 obj1 = new Generics1();
            bool result=obj1.Compare(1, 1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        
    }
}
