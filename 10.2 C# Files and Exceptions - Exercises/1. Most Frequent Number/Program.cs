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
        List<int> input = File
            .ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\1. Most Frequent Number\\input.txt")
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        int mostFreq = 0;
        int count = 0;
        int maxCount = int.MinValue;
        for (int i = 0; i < input.Count; i++)
        {
            count = 0;
            for (int j = i + 1; j < input.Count; j++)
            {
                if (input[i] == input[j])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                mostFreq = input[i];
                maxCount = count;
            }
        }
        File.WriteAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\1. Most Frequent Number\\output.txt", mostFreq.ToString());
    }
}
