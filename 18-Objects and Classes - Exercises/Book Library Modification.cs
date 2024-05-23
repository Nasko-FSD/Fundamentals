using System.Globalization;

class Program
{
    class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string iSBN, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            ISBN = iSBN;
            Price = price;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public Library(string name, List<Book> books, decimal price, decimal totalPrice)
        {
            Name = name;
            Books = books;
            Price = price;
            TotalPrice = totalPrice;
        }

        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
    static void Main()
    {
        List<Book> books = ReadBooks();
        Dictionary<string, DateTime> sortedTitles = SortedBooks(books);
        PrintResult(sortedTitles);
    }

    static void PrintResult(Dictionary<string, DateTime> sortedTitles)
    {
        foreach (var title in sortedTitles)
        {
            Console.WriteLine($"{title.Key} -> {title.Value.ToString("dd.MM.yyyy")}");
        }
    }

    static Dictionary<string, DateTime> SortedBooks(List<Book> books)
    {
        Dictionary<string, DateTime> titles = new Dictionary<string, DateTime>();
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.MM.yyyy", CultureInfo.InvariantCulture);

        foreach (Book book in books)
        {
            string title = book.Title;
            var releaseDate = book.ReleaseDate;

            if (titles.ContainsKey(title) == false)
            {
                titles.Add(title, releaseDate);
            }
            else
            {
                titles[title] = releaseDate;
            }
        }

        Dictionary<string, DateTime> sortedTitles = titles
            .Where(d => d.Value > endDate)
            .OrderBy(d => d.Value)
            .ThenBy(d => d.Key)
            .ToDictionary(d => d.Key, d => d.Value);

        return sortedTitles;
    }

    static List<Book> ReadBooks()
    {
        int number = int.Parse(Console.ReadLine());
        List<Book> books = new List<Book>();

        for (int i = 0; i < number; i++)
        {
            string[] booksData = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string title = booksData[0];
            string author = booksData[1];
            string publisher = booksData[2];
            DateTime releaseDate = DateTime.ParseExact(booksData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string isbn = booksData[4];
            decimal price = decimal.Parse(booksData[5]);
            Book book = new Book(title, author, publisher, releaseDate, isbn, price);
            books.Add(book);
        }
        return books;
    }
}