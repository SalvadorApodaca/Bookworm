using BookwormRSL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Business.Interfaces
{
    public interface IBookLendingBusiness
    {
        Task Add(BookLending lending);
        Task Delete(BookLending lending);
        Task Update(BookLending lending);
        IEnumerable<BookLending> Get();
        IEnumerable<BookLending> GetByActive();
        IEnumerable<BookLending> GetByContact(int contactId);
        IEnumerable<BookLending> GetByBook(int bookId);
    }
}
