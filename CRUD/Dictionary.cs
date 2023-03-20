using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NloggerDemo.CRUD
{
    internal class Dictionary
    {
        public static void CrudwithDictionary()
        {
            Dictionary <int, string> Names= new Dictionary <int, string> ();
            Names.Add(1, "Ajay");
            Names.Add(2, "Chandra");

            Console.WriteLine("Added elements"); // adding elements into dictionary collection
            foreach (KeyValuePair<int, string> name in Names)
            {
                Console.WriteLine(name);
            }

            Names[1] = "Awesome";
            Console.WriteLine("Updated value"); //updating the value of the key
            foreach(KeyValuePair<int, string> name in Names)
            { Console.WriteLine(name); }

            Names.Remove(2);

            Console.WriteLine("Deleted the value");
            foreach(KeyValuePair<int, string>name in Names) { Console.WriteLine(name); }

            Names.Add(3, "ChandraAwesome");

            Console.WriteLine("Added a new key and value");
            foreach(KeyValuePair<int, string>name in Names) { Console.WriteLine(name); }
        }
    }
}
