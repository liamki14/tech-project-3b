//Author:Liam  K Kelly
//Date: 9/27/2020
//Description: Tech Project 3b.  Automatic Arrays
using System;

namespace TechProject3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an automatic array.");
            int[] countdown = new int[25];
            int pop_array = 0;      
            for (int i = 0; i < 25; i++)
            {
                countdown[i] = pop_array;
                Console.Write("Element value = " + i + '\n');
            }
        }
    }
}
