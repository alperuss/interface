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
    public class ProductsController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public ProductsController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var product = _unitOfWork.ProductRepository.GetAll();
            return new JsonResult(product);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _unitOfWork.ProductRepository.GetById(id);
            return new JsonResult(product);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.Product product)
        {
            _unitOfWork.ProductRepository.Insert(product);
            _unitOfWork.Complete();
            return new JsonResult(product);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.Product product)
        {
            _unitOfWork.ProductRepository.Update(product);
            _unitOfWork.Complete();
            return new JsonResult(product);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.ProductRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}