using BookwormRSL.Business.Interfaces;
using BookwormRSL.Data.UnitOfWork;
using BookwormRSL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Business
{
    public class ContactBusiness : IContactBusiness
    {
        UnitOfWork _unitOfWork;

        public ContactBusiness()
        {
            _unitOfWork = new UnitOfWork();
        }

        public async Task Add(Contact contact)
        {
            _unitOfWork.ContactRepository.Insert(contact);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(Contact contact)
        {
            _unitOfWork.ContactRepository.Delete(contact);
            await _unitOfWork.CommitAsync();
        }

        public IEnumerable<Contact> Get()
        {
            var contacts = _unitOfWork.ContactRepository.Get();
            return contacts;
        }

        public async Task<Contact> GetById(int contactId)
        {
            var contact = await _unitOfWork.ContactRepository.GetByIdAsync(contactId);
            return contact;
        }

        public async Task Update(Contact contact)
        {
            _unitOfWork.ContactRepository.Update(contact);
            await _unitOfWork.CommitAsync();
        }
    }
}
