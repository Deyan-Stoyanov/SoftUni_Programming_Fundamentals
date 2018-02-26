using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;

namespace _9.Book_Library
{
    class Program
    {
        class Book
        {
            public string Name { set; get; }
            public string Author { set; get; }
            public string Publisher { set; get; }
            public DateTime PublishingDate { set; get; }
            public string ISBN { set; get; }
            public decimal Price { set; get; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> dateList = new Dictionary<string, DateTime>();
            var input = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\10. Book Library Modification\\input.txt")
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int n = int.Parse(input[0]);
            DateTime givenDate = DateTime.ParseExact(input[input.Count() - 1], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            for (int i = 1; i < input.Count() - 1; i++)
            {
                var line = input[i].Split();
                Book book = AddBook(line);
                if (DateTime.Compare(givenDate, book.PublishingDate) < 0)
                {
                    dateList.Add(book.Name, book.PublishingDate);
                }
            }
            var sortedDateList = dateList.OrderBy(x => x.Value).ThenBy(x => x.Key);
            foreach (var bookDatePair in sortedDateList)
            {
                File.AppendAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\10. Book Library Modification\\output.txt",
                    $"{bookDatePair.Key} -> {bookDatePair.Value.ToString("dd.MM.yyyy")}{Environment.NewLine}");
            }
        }

        static Book AddBook(string[] line)
        {
            Book book = new Book
            {
                Name = line[0],
                Author = line[1],
                Publisher = line[2],
                PublishingDate = DateTime.ParseExact(line[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = line[4],
                Price = decimal.Parse(line[5])
            };
            return book;
        }
    }
}
