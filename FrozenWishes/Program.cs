using System;
using System.Collections.Generic;
using System.IO;

namespace FrozenWishes
{
    class Program
    {
        class Wish
        {
            string name;
            string gift;

            public Wish(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            public string Name
            {
                get { return name; }
            }
            public string Gift
            {
                get { return gift; }
            }
        }
        static void Main(string[] args)
        {
            List<Wish> frozenWishes = new List<Wish>();
            string[] wishesFromFile = GetDataFromFile();

            foreach(string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Wish newWish = new Wish(tempArray[0], tempArray[1]);
                frozenWishes.Add(newWish);
            }

            foreach(Wish wishesFromList in frozenWishes)
            {
                Console.WriteLine($"Name ---> {wishesFromList.Name}. Gift ---> {wishesFromList.Gift}");
            }

        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Heleri\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }

}

    
