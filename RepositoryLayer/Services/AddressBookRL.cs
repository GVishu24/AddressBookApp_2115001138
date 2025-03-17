using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Services
{
    public class AddressBookRL : IAddressBookRL
    {
        private readonly AddressBookDbContext _context;

        public AddressBookRL(AddressBookDbContext context)
        {
            _context = context;
        }
        public List<AddressBookEntity> GetAllContacts()
        {
            return _context.Addresses.AsNoTracking().ToList();
        }

        public AddressBookEntity GetContactById(int id)
        {
            return _context.Addresses.FirstOrDefault(a => a.AddressId == id);
        }

        public AddressBookEntity AddContact(AddressBookEntity addressBookEntity)
        {
            _context.Addresses.Add(addressBookEntity);
            _context.SaveChanges();
            return addressBookEntity;
        }

        public AddressBookEntity UpdateContact(int id, AddressBookEntity addressBookEntity)
        {
            var existingContact = _context.Addresses.Find(id);
            if (existingContact == null) return null;

            existingContact.PersonName = addressBookEntity.PersonName;
            existingContact.Address = addressBookEntity.Address;
            existingContact.PhoneNumber = addressBookEntity.PhoneNumber;
            existingContact.Email = addressBookEntity.Email;

            _context.SaveChanges();
            return existingContact;
        }

        public bool DeleteContact(int id)
        {
            var contact = _context.Addresses.Find(id);
            if (contact == null) return false;

            _context.Addresses.Remove(contact);
            _context.SaveChanges();
            return true;
        }
    }
}
    

