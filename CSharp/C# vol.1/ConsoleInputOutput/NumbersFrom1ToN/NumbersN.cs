﻿/* Problem 8. Numbers from 1 to n

Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n],
each on a single line. */


using System;

class NumbersN
{
    static void Main()
    {
        Console.WriteLine("Please enter tne Integer number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe console print all numbers in the interval [1...n]:\n");

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }

    }
}

