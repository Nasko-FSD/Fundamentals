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
        public Library(string name, string books, decimal price, decimal totalPrice)
        {
            Name = name;
            Books = books;
            Price = price;
            TotalPrice = totalPrice;
        }

        public string Name { get; set; }
        public string Books { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
    static void Main()
    {
        List<Book> books = ReadBooks();
        Dictionary<string, decimal> sortedBooks = SortedBooks(books);
        PrintResult(sortedBooks);
    }

    static void PrintResult(Dictionary<string, decimal> sortedBooks)
    {
        foreach (var author in sortedBooks)
        {
            Console.WriteLine($"{author.Key} -> {author.Value:f2}");
        }
    }

    static Dictionary<string, decimal> SortedBooks(List<Book> books)
    {
        Dictionary<string, decimal> authors = new Dictionary<string, decimal>();

        foreach (Book book in books)
        {
            string authorName = book.Author;
            decimal price = book.Price;

            if (authors.ContainsKey(authorName) == false)
            {
                authors.Add(authorName, price);
            }
            else
            {
                authors[authorName] += price;
            }
        }
        Dictionary<string, decimal> sortedAuthors = authors
            .OrderByDescending(p => p.Value)
            .ThenBy(p => p.Key)
            .ToDictionary(p => p.Key, p => p.Value);

        return sortedAuthors;
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