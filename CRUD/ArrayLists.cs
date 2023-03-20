using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NloggerDemo.CRUD
{
    internal class ArrayLists
    {
        public static void CrudwithArrayList()
        {
            ArrayList Names= new ArrayList();
            Names.Add("Ajay");
            Names.Add("Chandra"); // adding the elements 
             foreach (string name in Names)
            {
                Console.WriteLine("Added values to list");
                Console.WriteLine(name);
            }

            Names[1] = "Awesome";
            Console.WriteLine("Updated the Existed element");// Updating the value or element
            foreach (string name in Names) { Console.WriteLine(name); }

            Names.Remove(0);
            Console.WriteLine("Deleting the value");// Deleting the value
            foreach (string name in Names) {  Console.WriteLine(name); }
            Names[0] = "ChandraAwesome";
            Console.WriteLine("Re-Updating the value");
            foreach (string name in Names) {  Console.WriteLine(name); } // Again Updating

            Names.Add("AwesomeGaming");
            Console.WriteLine("Again Added a value");
            foreach (string name in Names) { Console.WriteLine(name); }
        }
    }
}
