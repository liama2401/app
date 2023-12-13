using System;
using System.IO;

class namecalc
{


    static void Main()
    {
        // Specify the path to your text file
        string filePath = "./names.txt";

        // Read the entire line from the file
        string namesLine = File.ReadAllText(filePath);

        // Split the line into an array of strings using commas as separators
        string[] namesArray = namesLine.Split(',', StringSplitOptions.TrimEntries);

        // Now 'namesArray' contains the names as strings

        // You can loop through the array to see the names, for example:
        foreach (var name in namesArray)
        {
            Console.WriteLine(name);
        }
    }

}