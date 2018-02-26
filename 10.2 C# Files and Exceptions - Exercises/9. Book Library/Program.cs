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
            Dictionary<string, decimal> priceList = new Dictionary<string, decimal>();
            var input = File.ReadAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\9. Book Library\\input.txt")
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int n = int.Parse(input[0]);
            for (int i = 1; i < input.Count(); i++)
            {
                var line = input[i].Split();
                Book book = AddBook(line);
                if (!priceList.ContainsKey(book.Author))
                {
                    priceList.Add(book.Author, book.Price);
                }
                else
                {
                    priceList[book.Author] += book.Price;
                }
            }
            var sortedPriceList = priceList.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var bookPricePair in sortedPriceList)
            {
                File.AppendAllText("C:\\Users\\ASUS\\Desktop\\Files and Exceptions - Exercises\\9. Book Library\\output.txt",
                    $"{bookPricePair.Key} -> {bookPricePair.Value:F2}{Environment.NewLine}");
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
