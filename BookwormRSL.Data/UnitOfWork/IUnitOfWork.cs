using BookwormRSL.Data.Repositories.Interface;
using BookwormRSL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<Author> AuthorRepository { get; }
        IGenericRepository<Book> BookRepository { get; }
        IGenericRepository<BookLending> LendingRepository { get; }
        IGenericRepository<Category> CategoryRepository { get; }
        IGenericRepository<Contact> ContactRepository { get; }
        IGenericRepository<Genre> GenreRepository { get; }
        IGenericRepository<ReadingHistory> HistoryRepository { get; }
        IGenericRepository<Status> StatusRepository { get; }

        void Commit();
        Task CommitAsync();
    }
}
