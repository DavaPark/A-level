﻿using System;

namespace homework5
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logs = new Logger();
            Console.WriteLine("Enter the log type: Error, Info, Warning or All");
            logs.LogLevel = Console.ReadLine();

            Starter.Run(logs);

            logs.PrintLog();
        }
    }
}