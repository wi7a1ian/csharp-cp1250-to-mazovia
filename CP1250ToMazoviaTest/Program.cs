using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CP1250ToMazoviaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = @"TestSample.txt";
            string outputFile = "TestSample.out.txt";

            Process.Start("CP1250ToMazovia.exe", string.Format("\"{0}\" \"{1}\"", inputFile, outputFile));
        }
    }
}
