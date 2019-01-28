using BookwormRSL.Business.Interfaces;
using BookwormRSL.Data.UnitOfWork;
using BookwormRSL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Business
{
    public class BookBusiness : IBookBusiness
    {
        UnitOfWork _unitOfWork;

        public BookBusiness()
        {
            _unitOfWork = new UnitOfWork();
        }

        public async Task Add(Book book)
        {
            _unitOfWork.BookRepository.Insert(book);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(Book book)
        {
            _unitOfWork.BookRepository.Delete(book);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            var book = await _unitOfWork.BookRepository.GetByIdAsync(id);
            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            var books = _unitOfWork.BookRepository.Get().ToList();
            return books;
        }

        public IEnumerable<Book> GetByAuthor(int authorId)
        {
            var books = _unitOfWork.BookRepository.Get(b => b.AuthorId == authorId).ToList();
            return books;
        }

        public async Task Update(Book book)
        {
            _unitOfWork.BookRepository.Update(book);
            await _unitOfWork.CommitAsync();
        }
    }
}
