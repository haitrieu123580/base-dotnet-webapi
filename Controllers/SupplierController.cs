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
        public ActionResult GetSupplierWithCategoryById(string id)
        {
            Console.WriteLine( $"id {id}");
            return Ok(_supplierService.GetSupplierCategories()); ;
            // return Ok(_supplierService.GetSupplierCategories());
        }
        [HttpPost]
        public ActionResult<IEnumerable<SupplierResDto>> CreateSupplier()
        {
            return Ok(_supplierService.GetSupplierCategories());
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult<IEnumerable<SupplierResDto>> DeleteSupplier()
        {
            return Ok(_supplierService.GetSupplierCategories());
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