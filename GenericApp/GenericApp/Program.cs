﻿using System;

namespace GenericApp
{
    class Program
    {
        static void Main(string[] args)
        {

            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(1, "one");
            Console.WriteLine(aDictionary.Count);
            aDictionary.Add(1, "one");
            Console.WriteLine(aDictionary.Count);
            //aDictionary.Add(1, "one");
            //aDictionary.Add(2, "two");
            //aDictionary.Add(3, "three");
            //aDictionary.Add(1, "ich");
            //aDictionary.Add(2, "nee");
            //aDictionary.Add(3, "sun");
            //Console.WriteLine(aDictionary.Count);
            //aDictionary.Remove(1);
            //Console.WriteLine(aDictionary.Count);
            //aDictionary.Remove(2,"two");
            //Console.WriteLine(aDictionary.Count);
            //Console.WriteLine(aDictionary.ContainsKey(1));
            //Console.WriteLine(aDictionary.Contains(2,"nee"));
            //Console.WriteLine(aDictionary.ContainsKey(2));
            //Console.WriteLine(aDictionary.ContainsKey(3));
            //Console.WriteLine(aDictionary.ContainsKey(4));

        }
    }
}
