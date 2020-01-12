using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UnitOfWorkDeneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public SuppliersController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var supplier = _unitOfWork.SupplierRepository.GetAll();
            return new JsonResult(supplier);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var supplier = _unitOfWork.SupplierRepository.GetById(id);
            return new JsonResult(supplier);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.Supplier supplier)
        {
            _unitOfWork.SupplierRepository.Insert(supplier);
            _unitOfWork.Complete();
            return new JsonResult(supplier);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.Supplier supplier)
        {
            _unitOfWork.SupplierRepository.Update(supplier);
            _unitOfWork.Complete();
            return new JsonResult(supplier);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.SupplierRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}