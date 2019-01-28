using BookwormRSL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Business.Interfaces
{
    public interface ICategoryBusiness
    {
        IEnumerable<Category> Get();
        Task Add(Category category);
        Task Update(Category category);
        Task Delete(Category category);
    }
}
