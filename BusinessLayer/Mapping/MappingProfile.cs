using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ModelLayer.DTO;
using ModelLayer.Model;
using RepositoryLayer.Entity;


namespace BusinessLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddressBookEntity, AddressBookDTO>().ReverseMap();
        }
    }
}
