using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();
            ht.Add("EmpId", 1267);
            ht.Add("Ename", "Durga Prasad");
            ht.Add("Dept", "MCB");
            ht.Add("Role", "Dotnet Developer");
            ht.Add("Email", "dp@gmail.com");
            ht.Add("Phone", 6304195695);
            ht.Add("Company", "Carbynetech");
            ht.Add("Location", "Hi-Tech City");
            ht.Add("Salary", 18000);
            Console.WriteLine(ht.Count);
            Console.WriteLine(ht.ContainsValue("Durga Prasad"));
            Console.WriteLine(ht.ContainsValue("Hello"));     //Checks whether given value is present or not
            Console.WriteLine(ht.ContainsKey("EmpId"));
            Console.WriteLine(ht.ContainsKey("StdId"));       //Checks whether given key is present or not
            ht.Remove("Dept");                                //Removes the value with given key
            Console.WriteLine("DP".GetHashCode());
            Console.WriteLine("=========Only Keys=========");
            foreach (object key  in ht.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("=========Only Values=========");
            foreach (object value in ht.Values)
            {
                Console.WriteLine(value);
                //Console.WriteLine(ht[key]); value or ht[key] are similar
            }
            Console.WriteLine("=========Key : Value pair=========");
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            Console.ReadKey();
        }
    }
}
