using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr=new int[10];
            Array.Resize(ref arr, 15);*/  //Array

            ArrayList al = new ArrayList(); //Creating a new ArrayList
            Console.WriteLine(al.Capacity);
            al.Add(12);
            Console.WriteLine(al.Capacity); //Finding capacity of ArrayList
            al.Add(26);
            al.Add(32);                     //Adding the values into AL
            al.Add(11);
            al.Add(14);
            Console.WriteLine(al.Capacity);
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
                Console.WriteLine();
            }
            al.Insert(2, 25);              //Inserting based on the index value
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
                Console.WriteLine();
            }
            al.Remove(25);                 //Removing the value directly
            al.RemoveAt(4);                //Removing using Index position
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
