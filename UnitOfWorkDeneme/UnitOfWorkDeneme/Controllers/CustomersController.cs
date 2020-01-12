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
    public class CustomersController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public CustomersController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var customer = _unitOfWork.CustomerRepository.GetAll();
            return new JsonResult(customer);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = _unitOfWork.CustomerRepository.GetById(id);
            return new JsonResult(customer);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.Customer category)
        {
            _unitOfWork.CustomerRepository.Insert(category);
            _unitOfWork.Complete();
            return new JsonResult(category);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.Customer category)
        {
            _unitOfWork.CustomerRepository.Update(category);
            _unitOfWork.Complete();
            return new JsonResult(category);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.CustomerRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}