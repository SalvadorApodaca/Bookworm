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
    public class BookLendingBusiness : IBookLendingBusiness
    {
        UnitOfWork _unitOfWork;

        public BookLendingBusiness()
        {
            _unitOfWork = new UnitOfWork();
        }

        public async Task Add(BookLending lending)
        {
            _unitOfWork.LendingRepository.Insert(lending);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(BookLending lending)
        {
            _unitOfWork.LendingRepository.Delete(lending);
            await _unitOfWork.CommitAsync();
        }

        public IEnumerable<BookLending> Get()
        {
            var lendings = _unitOfWork.LendingRepository.Get().ToList();
            return lendings;
        }

        public IEnumerable<BookLending> GetByActive()
        {
            var lendings = _unitOfWork.LendingRepository.Get(l => l.ReturnDate == null).ToList();
            return lendings;
        }

        public IEnumerable<BookLending> GetByBook(int bookId)
        {
            var lendings = _unitOfWork.LendingRepository.Get(l => l.BookId == bookId, null, l => l.Book, l => l.Contact).ToList();
            return lendings;
        }

        public IEnumerable<BookLending> GetByContact(int contactId)
        {
            var lendings = _unitOfWork.LendingRepository.Get(l => l.ContactId == contactId, null, l => l.Book, l => l.Contact).ToList();
            return lendings;
        }

        public async Task Update(BookLending lending)
        {
            _unitOfWork.LendingRepository.Update(lending);
            await _unitOfWork.CommitAsync();
        }
    }
}
