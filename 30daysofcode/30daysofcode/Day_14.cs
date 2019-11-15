﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _30daysofcode
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // Add your code here

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public int computeDifference()
        {
            Array.Sort(elements);
            maximumDifference = elements[elements.Length - 1] - elements[0];
            return maximumDifference;
        }

    } // End of Difference Class

    class Solution
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
