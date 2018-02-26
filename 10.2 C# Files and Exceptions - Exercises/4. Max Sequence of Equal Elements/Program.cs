using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

public class ConsoleApp1
{
    public static void Main()
    {
        int[] input = File
            .ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\4. Max Sequence of Equal Elements\\input.txt")
            .Split()
            .Select(int.Parse)
            .ToArray();
        int bestCount = 0;
        int bestIndex = 0;
        int count = 0;
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > bestCount)
            {
                bestCount = count;
                bestIndex = i - count + 1;
            }
        }
        StringBuilder answer = new StringBuilder();
        for (int i = bestIndex; i < bestIndex + bestCount; i++)
        {
            answer.Append($"{input[i]} ");
        }
        File.WriteAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\4. Max Sequence of Equal Elements\\output.txt", answer.ToString());

    }
}