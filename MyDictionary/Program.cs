using System;
using System.Collections;
using System.Collections.Generic;

namespace OrDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string> ();
            
            myDictionary.Add(1, "The Originals");
            myDictionary.Add(2, "Sense 8");
            myDictionary.Add(3, "Supernatural");
            myDictionary.Add(4, "Teen Wolf");
            myDictionary.Add(5, "How I Mether Your Mother");
            myDictionary.Add(6, "Dark");
            myDictionary.Add(7, "sdfsdfdf");

            
            foreach (var item in myDictionary)
            {
                Console.WriteLine(item.Key + " ID'li ve " + item.Value + "isimli dizi.");
            }
        }
    }
}
