using System.Collections.Generic;
using s002API.Models;
using s002API.Data.Repositories;
using s002API.Dtos;
using System;
using AutoMapper;
namespace s002API.Services
{
    public class SupplierService : ISupplierService
    {

        private readonly ISupplierRepository _supplierRepo;
        private readonly IMapper _mapper;
        public SupplierService(ISupplierRepository supplierRepo, IMapper mapper)
        {
            _supplierRepo = supplierRepo;
            _mapper = mapper;
        }
        public IEnumerable<SupplierResDto> GetSupplierCategories()
        {
            IEnumerable<SupplierCategory> suppliers = _supplierRepo.GetSupplierCategories();
            var supplierDtos = _mapper.Map<List<SupplierResDto>>(suppliers);
            return supplierDtos;
        }
        public SupplierResDto GetSupplierWithCategoryById(string IdWithPrefix)
        {
            int id = int.Parse(IdWithPrefix.Substring(3));
            try
            {
                if (_supplierRepo.isExist(id))
                {

                }
            }
            catch (System.Exception)
            {

                throw;
            }
            return null;
        }
    }
}
