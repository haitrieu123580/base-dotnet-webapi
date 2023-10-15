using System.Linq;
using AutoMapper;
using s002API.Dtos;
using s002API.Models;


namespace s002API.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // CreateMap<Supplier, SupplierResDto>()
            // .ForMember(dest => dest.Id, opt => opt.MapFrom(src => "NCC" + src.Id.ToString()))
            // .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.SupplierCategories.FirstOrDefault().Category.Name));
            // .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
            CreateMap<SupplierCategory, SupplierResDto>()
                        .ForMember(dest => dest.SupplierId, opt => opt.MapFrom(src => "NCC" + src.Supplier.Id))
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Supplier.Name))
                        .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Supplier.Code))
                        .ForMember(dest => dest.DebtCode, opt => opt.MapFrom(src => src.Supplier.DebtCode))
                        .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Supplier.Phone))
                        .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Supplier.Email))
                        .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Supplier.City))
                        .ForMember(dest => dest.District, opt => opt.MapFrom(src => src.Supplier.District))
                        .ForMember(dest => dest.Ward, opt => opt.MapFrom(src => src.Supplier.Ward))
                        .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Supplier.Address))
                        .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Supplier.Status))
                        .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

        }
    }
}