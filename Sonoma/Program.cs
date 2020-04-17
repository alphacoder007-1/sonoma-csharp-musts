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
            // Console.WriteLine("dictionary - simple\n");
            // Dict dictObj = new Dict();

            // Console.WriteLine("----Tiny URL------");
            // TinyURL obj = new TinyURL();
            // var result = obj.Decode(obj.Encode("https://www.microsoft.com/pluralsight/python/flask"));
            // Console.WriteLine($"result: {result}");

            Console.WriteLine("-----Tiny URL suing HashCode----------");
            HashCode obj = new HashCode();
            var result = obj.Encode("https://www.microsoft.com/pluralsight/python/flask");
            Console.WriteLine($"Encoded - {result}");

            Console.WriteLine($"Decoded - {obj.Decode(result)}");
        }
    }
}
