﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_task1_jan_20
{
    internal class ProductList
    {
        public static void Main(string[] args)
        {
            string[][] Product = new string[3][];
            Product[0] = new string[3] { "a", "Biscuits", "There are 4 items" };
            Product[1] = new string[3] { "b", "Chocolates", "There are 5 items" };
            Product[2] = new string[3] { "c", "Drinks", "There are 6 items" };
            for (int i = 0; i < Product.Length; i++)
            {
                for (int j = 0; j < Product[i].Length; j++)
                {
                    Console.Write(Product[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
