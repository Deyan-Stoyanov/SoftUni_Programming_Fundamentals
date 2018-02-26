using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class ConsoleApp1
{
    public static void Main()
    {

        int[] array = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\3. Equal Sums\\input.txt").Split(' ').Select(int.Parse).ToArray();
        int sum1 = 0;
        int sum2 = 0;
        string answer = "";
        for (int i = 0; i < array.Length; i++)
        {
            sum1 = 0;
            sum2 = 0;
            for (int j = 0; j < i; j++)
            {
                sum1 += array[j];
            }

            for (int j = i + 1; j < array.Length; j++)
            {
                sum2 += array[j];
            }

            if (sum1 == sum2)
            {
                File.WriteAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\3. Equal Sums\\output.txt", i.ToString());
                return;
            }
        }
        File.WriteAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\3. Equal Sums\\output.txt", "no");
    }
}