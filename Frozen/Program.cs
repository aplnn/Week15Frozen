using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Kink
        {
            string nimi;
            string kingitus;

            public Kink(string _nimi, string _kingitus)
            {
                nimi = _nimi;
                kingitus = _kingitus;
                
            }

            //getters for Kink

            public string Nimi
            {
                get { return nimi; }
            }

            public string Kingitus
            {
                get { return kingitus; }
            }

        }

        static void Main(string[] args)
        {
            List<Kink> myKingid = new List<Kink>();
            string[] kingidFromFile = GetDataFromFile();

            foreach (string line in kingidFromFile)
            {
                string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Kink newKink = new Kink(tempArray[0], tempArray[1]);
                myKingid.Add(newKink);
            }

            foreach (Kink kinkFromList in myKingid)
            {
                Console.WriteLine($"{kinkFromList.Nimi} wants {kinkFromList.Kingitus} for Christmas.");
            }
        }


        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\xxx\xxx\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }

}