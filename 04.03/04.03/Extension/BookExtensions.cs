using _04._03.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//GetShortInfo(this Book book): Title - Author - Price AZN formatında qaytarsın
//IsInStock(this Book book): bool qaytarsın
//ApplyDiscount(this Book book, double percent): qiyməti faiz qədər endirsin

namespace _04._03.Extension
{
    internal static class BookExtensions
    {
        public static string GetShortInfo(this Book book)
        {
            return $"{book.Title},{book.Author},{book.Price}";
        }
        
    }
}
