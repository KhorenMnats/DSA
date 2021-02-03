using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTables
{
    class Program
    {
        // https://stackoverflow.com/questions/10168333/what-are-the-differences-b-w-hashtable-dictionary-and-keyvaluepair#:~:text=The%20difference%20between%20Hashtable%20and,values%20are%20of%20type%20Object%20.&text=KeyValuePair%20is,a%20series%20of%20KeyValuePair%20objects.

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void RunDictionary()
        {
            var book = new Dictionary<string, decimal>();
            book.Add("apple", 0.67m);
            book.Add("milk", 1.49m);
            book.Add("avocado", 1.49m);
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static void RunHashtable()
        {
            var book = new Hashtable();
            book.Add("apple", 0.67m);
            book.Add("milk", 1.49m);
            book.Add("avocado", 1.49m);
            foreach (DictionaryEntry item in book)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static void RunKeyValuePair()
        {
            var book = new List<KeyValuePair<string, decimal>>();
            book.Add(new KeyValuePair<string, decimal>("apple", 0.67m));
            book.Add(new KeyValuePair<string, decimal>("milk", 1.49m));
            book.Add(new KeyValuePair<string, decimal>("avocado", 1.49m));
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
