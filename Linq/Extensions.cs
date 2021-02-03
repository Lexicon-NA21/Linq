using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public static class Extensions
    {
        public static string Add(this string str, string newWord)
        {
            return $"{str} {newWord}";
        }

        public static string Add(this string str, params string[] words)
        {
            var temp = String.Join(" ", words);
            return $"{str} {temp}";
        }

        public static void Print<T>(this IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
