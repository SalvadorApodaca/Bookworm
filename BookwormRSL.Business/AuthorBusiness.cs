using BookwormRSL.Business.Interfaces;
using BookwormRSL.Data.UnitOfWork;
using BookwormRSL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookwormRSL.Business
{
    public class AuthorBusiness : IAuthorBusiness
    {
        UnitOfWork _unitOfWork;

        public AuthorBusiness()
        {
            _unitOfWork = new UnitOfWork();
        }

        public async Task AddAsync(Author author)
        {
            _unitOfWork.AuthorRepository.Insert(author);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(Author author)
        {
            _unitOfWork.AuthorRepository.Delete(author);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Author> GetAuthorAsync(int id)
        {
            var author = await _unitOfWork.AuthorRepository.GetByIdAsync(id);
            return author;
        }

        public IEnumerable<Author> GetAuthors()
        {
            var authors = _unitOfWork.AuthorRepository.Get();
            return authors.ToList();
            
        }

        public async Task UpdateAsync(Author author)
        {
            _unitOfWork.AuthorRepository.Update(author);
            await _unitOfWork.CommitAsync();
        }
    }
}
