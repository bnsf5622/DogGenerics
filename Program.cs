using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();

            ages.Add(23);
            ages.Add(20);
            
            Console.WriteLine();
            Console.Write("Press enter to shut down...");
            Console.ReadLine();
        }
        private static void DemonstrateTextFileStorage()...