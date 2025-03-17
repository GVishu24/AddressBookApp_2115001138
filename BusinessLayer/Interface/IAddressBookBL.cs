using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Entity;

namespace BusinessLayer.Interface
{
    public interface IAddressBookBL
    {
        List<AddressBookEntity> GetAllContacts();
        AddressBookEntity GetContactById(int id);
        AddressBookEntity AddContact(AddressBookDTO addressBookDTO);
        AddressBookEntity UpdateContact(int id, AddressBookDTO addressBookDTO);
        bool DeleteContact(int id);
    }
}
