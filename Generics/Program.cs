using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(4);
            li.Add(5);
            li.Add(6);  //Adds a value sequentially
            li.Add(7);
            li.Add(8);
            li.Add(9);
            li.Remove(9); //Removes a specified value
            li.RemoveAt(7); //Removes a value from specified index
            li.Insert(0, 0); //Adds a value at specified index
            Console.WriteLine(li.Capacity); //Shows the capacity of List
            Console.WriteLine("==========Using for loop==========");
            for (int i=0;i<li.Count;i++)
            {
                Console.WriteLine(li[i]);
            }
            Console.WriteLine("==========Using foreach loop==========");
            foreach (int intlist in li)
            {
                Console.WriteLine(intlist);
            }
            Console.ReadKey();
        }
    }
}
