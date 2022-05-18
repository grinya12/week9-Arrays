﻿using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fruit Basket: apples, bananas, oranges, pears, plums

            //string[] fruits = { "apples", "bananas", "oranges", "pears", "plums" };
            string[] fruits = new string[5];

            fruits[0] = "apples";
            fruits[1] = "bananas";
            fruits[2] = "oranges";
            fruits[3] = "pears";
            fruits[4] = "plums";

            Console.WriteLine(fruits[2]);

            fruits[2] = "tangerines"; //arrays are mutable
            Console.WriteLine(fruits[2]);

            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[4]);
        }
    }
}
