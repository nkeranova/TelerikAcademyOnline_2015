﻿/* Problem 2. Numbers Not Divisible by 3 and 7

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. */

using System;

class NotDivisible
{
    static void Main()
    {
        Console.Write("Please enter a pozitive integer number n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
