﻿using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 30; i++)
        {
            String output = "";

            if (i % 14 == 0 && i % 4 == 0)
            {
                output = "Unictive Media";
            }
            else if (i % 4 == 0)
            {
                output = "Unictive";
            }
            else 
            {
                output = i.ToString();
            }
            Console.WriteLine(output);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}