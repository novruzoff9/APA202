using _04._03.Enums;
using _04._03.Extension;
using _04._03.Models;
using _04._03.Services;

Book book1 = new Book()
{
    Title = "Xosrov",
    Author = "Sirin",
    PageCount = 200,
    Price = 20,
    StockCount = 10,
    Genre = Genre.Science
};

Book book2 = new Book()
{
    Title = "Seyfeli",
    Author = "Nizami",
    PageCount = 300,
    Price = 30,
    StockCount = 15,
    Genre = Genre.Romance
};

Book book3 = new Book()
{
    Title = "Leyli",
    Author = "Mecnun",
    PageCount = 400,
    Price = 71,
    StockCount = 20,
    Genre = Genre.Programming
};

BookService bookService = new BookService();

bookService.ReadFromFile();

//bookService.Add(book1);
//bookService.Add(book2);
//bookService.Add(book3);

bookService.WriteToFile();


//Console.WriteLine(bookService.CountByGenre(Genre.Romance));

//Console.WriteLine(bookService.GetById(1));

////Console.WriteLine(BookExtensions.GetShortInfo(book1));
//Console.WriteLine(book1.GetShortInfo());




