using _04._03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03.Interfaces
{
    internal interface IBookService
    {
        void Add(Book book);
        Book GetById(int id);


    }
}
