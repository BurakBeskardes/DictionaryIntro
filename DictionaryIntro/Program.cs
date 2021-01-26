using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {

        static void Main(string[] args)
        {

            Dictionary<int, string> MyDictionary = new Dictionary<int, string>();

            MyDictionary.Add(1907, "FENERBAHÇE");
            MyDictionary.Add(1905, "GALATASARAY");
            MyDictionary.Add(1903, "BEŞİKTAŞ");
            MyDictionary.Add(1967, "TRABZONSPOR");

            foreach (var dictionary in MyDictionary)
            {
                Console.WriteLine("Kuruluş tarihi : " + dictionary.Key + '\n' + "Takım :  " + dictionary.Value);
            }


        }
    }
}
