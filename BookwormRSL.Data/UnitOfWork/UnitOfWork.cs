using System;
using System.Threading.Tasks;
using BookwormRSL.Data.Repositories;
using BookwormRSL.Data.Repositories.Interface;
using BookwormRSL.Models;

namespace BookwormRSL.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly BookwormDbContext _context;
        private IGenericRepository<Author> _authorRepository;
        private IGenericRepository<Book> _bookRepository;
        private IGenericRepository<BookLending> _lendingRepository;
        private IGenericRepository<Category> _categoryRepository;
        private IGenericRepository<Contact> _contactRepository;
        private IGenericRepository<Genre> _genreRepository;
        private IGenericRepository<ReadingHistory> _historyRepository;
        private IGenericRepository<Status> _statusRepository;

        public IGenericRepository<Author> AuthorRepository => _authorRepository ?? (_authorRepository = new GenericRepository<Author>(_context));
        public IGenericRepository<Book> BookRepository => _bookRepository ?? (_bookRepository = new GenericRepository<Book>(_context));
        public IGenericRepository<BookLending> LendingRepository => _lendingRepository ?? (_lendingRepository = new GenericRepository<BookLending>(_context));
        public IGenericRepository<Category> CategoryRepository => _categoryRepository ?? (_categoryRepository = new GenericRepository<Category>(_context));
        public IGenericRepository<Contact> ContactRepository => _contactRepository ?? (_contactRepository = new GenericRepository<Contact>(_context));
        public IGenericRepository<Genre> GenreRepository => _genreRepository ?? (_genreRepository = new GenericRepository<Genre>(_context));
        public IGenericRepository<ReadingHistory> HistoryRepository => _historyRepository ?? (_historyRepository = new GenericRepository<ReadingHistory>(_context));
        public IGenericRepository<Status> StatusRepository => _statusRepository ?? (_statusRepository = new GenericRepository<Status>(_context));

        public UnitOfWork()
        {
            _context = new BookwormDbContext();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Task CommitAsync()
        {
            return _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
