using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using s002API.Dtos;
using s002API.Models;
using s002API.Services;
namespace s002API.Controllers
{
    [Route("api/supplier")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;
        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<SupplierResDto>> GetSupplierCategories()
        {
            return Ok(_supplierService.GetSupplierCategories());
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult GetSupplierWithCategoryById(int id)
        {
            return Ok(_supplierService.GetSupplierWithCategoryById(id)); ;
            // return Ok(_supplierService.GetSupplierCategories());
        }
        [HttpPost]
        public ActionResult<SupplierResDto> CreateSupplier([FromBody] CreateSupplierReqDto data)
        {
            Console.WriteLine(data);
            return Ok(_supplierService.Create());
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteSupplier(int id)
        {
            return Ok(_supplierService.DeleteSupplierCategoryById(id));
        }
        [HttpDelete]
        public ActionResult<IEnumerable<SupplierResDto>> DeleteSuppliers()
        {
            return Ok(_supplierService.GetSupplierCategories());
        }
        [HttpPut]
        [Route("{id}")]
        public ActionResult<IEnumerable<SupplierResDto>> EditSupplier()
        {
            return Ok(_supplierService.GetSupplierCategories());
        }

    }
}