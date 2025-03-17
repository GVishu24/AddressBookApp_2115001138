using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;

namespace BusinessLayer.Services
{
    public class AddressBookBL : IAddressBookBL
    {
        private readonly IAddressBookRL _addressBookRL;
        private readonly IMapper _mapper;

        public AddressBookBL(IAddressBookRL addressBookRL, IMapper mapper)
        {
            _addressBookRL = addressBookRL;
            _mapper = mapper;
        }

        public List<AddressBookEntity> GetAllContacts()
        {
            return _addressBookRL.GetAllContacts();
        }

        public AddressBookEntity GetContactById(int id)
        {
            return _addressBookRL.GetContactById(id);
        }

        public AddressBookEntity AddContact(AddressBookDTO addressBookDTO)
        {
            var addressEntity = _mapper.Map<AddressBookEntity>(addressBookDTO);
            return _addressBookRL.AddContact(addressEntity);
        }

        public AddressBookEntity UpdateContact(int id, AddressBookDTO addressBookDTO)
        {
            var updatedEntity = _mapper.Map<AddressBookEntity>(addressBookDTO);
            return _addressBookRL.UpdateContact(id, updatedEntity);
        }

        public bool DeleteContact(int id)
        {
            return _addressBookRL.DeleteContact(id);
        }
    }
}
    

