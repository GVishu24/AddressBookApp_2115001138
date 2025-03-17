using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Interface
{
    public interface IAddressBookRL
    {
        List<AddressBookEntity> GetAllContacts();
        AddressBookEntity GetContactById(int id);
        AddressBookEntity AddContact(AddressBookEntity addressBookEntity);
        AddressBookEntity UpdateContact(int id, AddressBookEntity addressBookEntity);
        bool DeleteContact(int id);
    }
}
