using AutoMapper;
using Market.Domain.Entities.Products;
using Market.Domain.Entities.Suppliers;
using Market.Service.DTOs.ProductsDTOs;
using Market.Service.DTOs.SuppliersDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.Mappers
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductForCreationDTO>().ReverseMap();
            CreateMap<Category, CategoryForCreationDTO>().ReverseMap();
            CreateMap<Supplier, SupplierForCreationDTO>().ReverseMap();
        }


    }
}
