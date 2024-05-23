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
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Dictionary<string, DateTime> sortedTitles = books
            .Where(b => b.ReleaseDate > endDate)
            .GroupBy(b => b.Title)
            .Select(group => group.OrderBy(b => b.ReleaseDate).First())
            .OrderBy(b => b.ReleaseDate)
            .ThenBy(b => b.Title)
            .ToDictionary(b => b.Title, b => b.ReleaseDate);

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