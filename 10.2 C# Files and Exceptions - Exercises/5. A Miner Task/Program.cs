using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

public class ConsoleApp1
{
    public static void Main()
    {
        var input = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\5. A Miner Task\\input.txt")
            .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        Dictionary<string, int> minedMaterialsAndPrice = new Dictionary<string, int>();
        List<string> materials = new List<string>();
        List<int> quantites = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == "stop")
            {
                break;
            }
            else if (i % 2 == 0)
            {
                materials.Add(input[i]);
            }
            else
            {
                quantites.Add(int.Parse(input[i]));
            }
        }
        for (int i = 0; i < quantites.Count; i++)
        {
            if (!minedMaterialsAndPrice.ContainsKey(materials[i]))
            {
                minedMaterialsAndPrice.Add(materials[i], quantites[i]);
            }
            else
            {
                minedMaterialsAndPrice[materials[i]] += quantites[i];
            }
        }
        StringBuilder answer = new StringBuilder();
        foreach (var pair in minedMaterialsAndPrice)
        {
            answer.Append($"{pair.Key} –> {pair.Value}{Environment.NewLine}");
        }
        File.WriteAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\5. A Miner Task\\output.txt", answer.ToString());
    }
}