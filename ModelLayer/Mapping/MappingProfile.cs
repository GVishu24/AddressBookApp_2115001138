using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ModelLayer.DTO;
using ModelLayer.Model;

namespace ModelLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Map AddressBookEntry ↔ AddressBookDTO
            CreateMap<AddressBookEntry, AddressBookDTO>().ReverseMap();
        }
    }
}
