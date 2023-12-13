using System;
using System.IO;

class namecalc
{


    static void Main()
    {
        string filePath = "./names.txt";

        string namesLine = File.ReadAllText(filePath);

        string[] namesArray = namesLine.Split(new[] { "\"", "," }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(namesArray);
        int total = 0;
        for (int i = 0; i < namesArray.Length; i++)
        {
            int miniTotal = 0;
            foreach (char c in namesArray[i])
            {
                miniTotal += char.ToUpper(c) - 64;
            }
            total += miniTotal * (i + 1);
        }
        Console.WriteLine(total);
        // Console.WriteLine(namesArray.Length);
        // string namesLine2 = File.ReadAllText(filePath);


        // string[] namesArray2 = namesLine.Split(",");
        // Console.WriteLine(namesArray2.Length);


    }

}