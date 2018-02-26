using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;

class ConsoleApp1
{
    public static void Main()
    {
        string input = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\2. Index of Letters\\input.txt");
        foreach (char letter in input)
        {
            File.AppendAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\2. Index of Letters\\output.txt", $"{letter} -> {Convert.ToInt32(letter) - 97}{Environment.NewLine}");
        }
    }
}
