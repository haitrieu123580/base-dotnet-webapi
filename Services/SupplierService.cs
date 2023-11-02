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
        private readonly ISupplierCategoryRepo _supplierCategoryRepo;
        private readonly IMapper _mapper;
        public SupplierService(ISupplierRepository supplierRepo, ISupplierCategoryRepo supplierCategoryRepo, IMapper mapper)
        {
            _supplierRepo = supplierRepo;
            _supplierCategoryRepo = supplierCategoryRepo;
            _mapper = mapper;
        }
        public IEnumerable<SupplierResDto> GetSupplierCategories()
        {
            IEnumerable<SupplierCategory> suppliers = _supplierRepo.GetSupplierCategories();
            var supplierDtos = _mapper.Map<List<SupplierResDto>>(suppliers);
            return supplierDtos;
        }
        public SupplierResDto GetSupplierWithCategoryById(int scId)
        {
            // int id = int.Parse(IdWithPrefix.Substring(3));
            try
            {
                if (_supplierRepo.isExistSupplier(scId))
                {
                    // _supplierRepo.g
                    var supplierCategory = _supplierCategoryRepo.GetSupplierCategoryById(scId);
                    return _mapper.Map<SupplierResDto>(supplierCategory);
                }
                else
                {

                }
            }
            catch (System.Exception)
            {

                throw;
            }
            return null;
        }
        public bool DeleteSupplierCategoryById(int scId)
        {
            try
            {
                return _supplierCategoryRepo.DeleteSupplierCategoryById(scId);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public SupplierResDto Create()
        {
            return null;
        }
    }
}
