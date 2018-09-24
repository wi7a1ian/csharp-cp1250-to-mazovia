using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CP1250ToMazovia
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = string.Empty;
            string outputFile = string.Empty;

            if(args.Length == 0)
            {
                Console.WriteLine("Podaj ścieżki do plików!");
                return;
            }

            inputFile  = args[0].Trim('"');

            if (args.Length == 1)
            {
                outputFile = inputFile;
            }
            else
            {
                outputFile = args[1].Trim('"');
            }

            if (!File.Exists(inputFile))
            {
                Console.WriteLine("Plik wejściowy nie istnieje!");
                return;
            }

            Encoding encoding = new MazoviaEncoding();
            File.WriteAllText(outputFile, File.ReadAllText(inputFile, Encoding.Default), encoding); // CP: 667 790 991
        }
    }
}
