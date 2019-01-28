using BookwormRSL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Business.Interfaces
{
    public interface IAuthorBusiness
    {
        Task<Author> GetAuthorAsync(int id);
        IEnumerable<Author> GetAuthors();
        Task AddAsync(Author author);
        Task UpdateAsync(Author author);
        Task DeleteAsync(Author author);
    }
}
