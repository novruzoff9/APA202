using _04._03.Enums;
using _04._03.Extension;
using _04._03.Models;
using _04._03.Services;

Book book1 = new Book()
{
    Title = "Xosrov",
    Author = "Nizami",
    PageCount = 200,
    Price = 20,
    StockCount = 10,
    Genre = Genre.Romance
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
BookService bookService = new BookService();
bookService.Add(book1);
bookService.Add(book2);

Console.WriteLine(bookService.GetById(1));


Console.WriteLine(BookExtensions.GetShortInfo(book1));
Console.WriteLine(book1.GetShortInfo());



