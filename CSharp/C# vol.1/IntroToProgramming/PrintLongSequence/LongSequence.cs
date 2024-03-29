﻿//Problem 16.* Print Long Sequence
//
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

using System;

class LongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(-i);
                if (i < 1001)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine();
    }
}

/*      for (int i = 2; i < 1002; i++)
        {
            Console.WriteLine("{0}", i % 2 == 0? i: -i);
        } 
 */