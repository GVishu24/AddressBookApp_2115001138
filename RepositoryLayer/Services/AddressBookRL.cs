using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Context;
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
    }
}
