using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();

        Console.WriteLine("Enter names (press Enter on an empty line to finish):");
        string input;
        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            names.Add(input);
        }

        Action<string> printName = name => Console.WriteLine(name);

        Console.WriteLine("Names entered:");
        names.ForEach(printName);
    }
}