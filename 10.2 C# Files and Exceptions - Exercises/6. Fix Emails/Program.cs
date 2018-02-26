using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

public class ConsoleApp1
{
    public static void Main()
    {
        var input = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\6. Fix Emails\\input.txt")
            .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        Dictionary<string, string> namesAndEmails = new Dictionary<string, string>();
        List<string> names = new List<string>();
        List<string> emails = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == "stop")
            {
                break;
            }
            else if (i % 2 == 0)
            {
                names.Add(input[i]);
            }
            else
            {
                emails.Add(input[i]);
            }
        }
        for (int i = 0; i < names.Count; i++)
        {
            namesAndEmails.Add(names[i], emails[i]);
        }
        foreach (var pair in namesAndEmails)
        {
            if (!pair.Value.EndsWith("uk") && !pair.Value.EndsWith("us"))
            {
                File.AppendAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\6. Fix Emails\\output.txt", pair.Key + " – > " + pair.Value + Environment.NewLine);
            }
        }
    }
}