using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sonoma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dictionary - simple\n");

            // dictionary

            var dict = new Dictionary<int, string>();

            dict.Add(1, "Jan");
            dict.Add(2, "Feb");
            dict.Add(3, "Mar");

            foreach (var item in dict)
            {
                Console.WriteLine($" Key: {item.Key} Value: {item.Value}");
            }

            Console.WriteLine("\ndictionary - initialization and using for loop\n");
            // dictionary initialization and using for loop & Contains

            dict = new Dictionary<int, string>() {
                { 1, "Sunday"},
                { 2, "Monday"},
                { 3, "Tuesday"},
                { 4, "Wednesday"},
                { 5, "Thursday"},
            };            

            // dictionary - add key if not contains

            if (!dict.ContainsKey(6))
            {
                dict.Add(6, "I am newly added");
            }
            else
            {
                Console.WriteLine("there is a value at key 4");
            }

            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine("Key: " + dict.Keys.ElementAt(i) + " value: " + dict[dict.Keys.ElementAt(i)]);
            }


            // Hash Table

            Console.WriteLine("\nHashtable\n");

            var ht = new Hashtable();
            ht.Add(1,"Fremont");
            ht.Add(2,"Milpitas");
            ht.Add(3,"San Jose");
            ht.Add(4, "Mountain View");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"Key: {item.Key} value: {item.Value}");            
            }

            // accessing hashtable keys
            foreach (var key in ht.Keys)
            {
                Console.WriteLine($"Key: {key} ");
            }

            //accessing hashtable values
            foreach (var value in ht.Values)
            {
                Console.WriteLine($"Key: {value} ");
            }


        }
    }
}
