﻿/* Problem 7. Encode/decode
Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second 
– with the second, etc. When the last key character is reached, the next is the first.*/

namespace EncodeDecode
{
    using System;
    using System.Text;
   


    class EncodeDe
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string text = Console.ReadLine();
            Console.Write("Enter a KEY (sequence of random characters): "); //need to be without spaces
            string key = Console.ReadLine();
            Console.WriteLine("Encryption: {0}", Encrypt(text, key));
            Console.WriteLine("Encryption + decryption: {0}", Decrypt(Encrypt(text, key), key));
        }

        static string Encrypt(string word, string key)
        {
            StringBuilder cipher = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
                cipher.Append((char)(word[i] ^ key[i % key.Length]));
            return cipher.ToString();
        }

        static string Decrypt(string word, string key)
        {
            return Encrypt(word, key);
        }
    }
}
