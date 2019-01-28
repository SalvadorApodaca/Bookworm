using BookwormRSL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Business.Interfaces
{
    public interface IBookBusiness
    {
        Task<Book> GetBook(int id);
        IEnumerable<Book> GetBooks();
        IEnumerable<Book> GetByAuthor(int authorId);
        Task Add(Book book);
        Task Update(Book book);
        Task Delete(Book book);

    }
}
