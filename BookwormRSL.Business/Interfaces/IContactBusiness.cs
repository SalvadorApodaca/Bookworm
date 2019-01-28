using BookwormRSL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Business.Interfaces
{
    public interface IContactBusiness
    {
        Task Add(Contact contact);
        Task Update(Contact contact);
        Task Delete(Contact contact);
        IEnumerable<Contact> Get();
        Task<Contact> GetById(int contactId);
    }
}
