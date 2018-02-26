using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

public class ConsoleApp1
{
    public static void Main()
    {
        var input = int.Parse(File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\7. Advertisement Message\\input.txt"));
 
        var phrases = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\7. Advertisement Message\\messages\\Phrases.txt")
            .Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
            .ToArray();
        var events = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\7. Advertisement Message\\messages\\Events.txt")
            .Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
            .ToArray();
        var authors = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\7. Advertisement Message\\messages\\Authors.txt")
            .Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
            .ToArray();
        var cities = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\7. Advertisement Message\\messages\\Cities.txt")
            .Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
            .ToArray();

        Random random = new Random();
        for (int i = 0; i < input; i++)
        {
            int phraseIndex = random.Next(0, phrases.Length);
            int eventIndex = random.Next(0, events.Length);
            int authorIndex = random.Next(0, authors.Length);
            int cityIndex = random.Next(0, cities.Length);
            File.AppendAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\7. Advertisement Message\\output.txt",
                $"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} – {cities[cityIndex]}{Environment.NewLine}");
        }
    }
}