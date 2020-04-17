using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sonoma
{
    public class TinyURL
    {
        Dictionary<int, string> dict = new Dictionary<int,string>(); 
        int i=0;
        public TinyURL()
        {
            // Hash Map in java is equivalent to dictionary in C#
        }

        public string Encode(string longURL)
        {
            dict[i] = longURL;
            return ($"https://tinyurl.com/{i++}");
        }

        public string Decode(string shortURL)
        {
            string longURL = dict[Convert.ToInt32(shortURL.Replace("https://tinyurl.com/",""))];
            return longURL;
        }
    }

}