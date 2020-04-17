using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sonoma
{
    public class HashCode
    {
        Dictionary<Int64, string> dict = new Dictionary<Int64, string>();

        public string Encode(string longURL)
        {
            dict[longURL.GetHashCode()] = longURL;
            return $"https://tinyurl.com/{longURL.GetHashCode()}";
        }

        public string Decode(string shortURL)
        {
            var result = dict[Convert.ToInt64(shortURL.Replace("https://tinyurl.com/",""))];
            return result;
        }
    }

}