using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> BlackList = new Dictionary<int, string>();

            BlackList.Add(1, "Elizabeth Keen"); 
            BlackList.Add(3, "Katarina Rostova");
            BlackList.Add(4, "Kathryn Nemec");
            BlackList.Add(7, "Tom Keen");
            BlackList.Add(10, "Dembe Zuma");
            BlackList.Add(12, "Alan Fitch");
            BlackList.Add(13, "Raymond Reddington");

            foreach (var number in BlackList)
            {
                Console.WriteLine(number);
            }






        }
    }
}
