﻿namespace _5_InvalidNumber
{
    internal class InvalidNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0 || number >= 100 && number <= 200)
            {            
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}