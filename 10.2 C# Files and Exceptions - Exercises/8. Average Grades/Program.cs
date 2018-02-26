using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

public class ConsoleApp1
{
    class Student
    {
        public string Name { get; set; }
        public double AverageGrade { get; set; }
    }
    public static void Main()
    {
        var input = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\8. Average Grades\\input.txt")
            .Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
            .ToArray();
        int n = int.Parse(input[0]);
        List<Student> listOfStudents = new List<Student>();
        for (int i = 1; i < input.Length; i++)
        {
            var nameAndGrades = input[i].Split();
            string name = nameAndGrades[0];
            List<double> grades = new List<double>();
            Student student = new Student();
            for (int j = 1; j < nameAndGrades.Length; j++)
            {
                grades.Add(double.Parse(nameAndGrades[j]));
            }
            if (grades.Average() >= 5.00)
            {
                student.Name = name;
                student.AverageGrade = grades.Average();
                listOfStudents.Add(student);
            }
        }
        var orderedListOfStudents = listOfStudents.OrderBy(x => x.Name);
        foreach (var student in orderedListOfStudents)
        {
            File.AppendAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\8. Average Grades\\output.txt",
               $"{student.Name} -> {student.AverageGrade:F2}{Environment.NewLine}");
        }
    }
}