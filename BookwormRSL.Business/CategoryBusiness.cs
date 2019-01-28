using BookwormRSL.Business.Interfaces;
using BookwormRSL.Data.UnitOfWork;
using BookwormRSL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        UnitOfWork _unitOfWork;

        public CategoryBusiness()
        {
            _unitOfWork = new UnitOfWork();
        }

        public async Task Add(Category category)
        {
            _unitOfWork.CategoryRepository.Insert(category);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(Category category)
        {
            _unitOfWork.CategoryRepository.Delete(category);
            await _unitOfWork.CommitAsync();
        }

        public IEnumerable<Category> Get()
        {
            var categories = _unitOfWork.CategoryRepository.Get();
            return categories;
        }

        public async Task Update(Category category)
        {
            _unitOfWork.CategoryRepository.Update(category);
            await _unitOfWork.CommitAsync();
        }
    }
}
