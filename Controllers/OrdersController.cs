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
    public class OrdersController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public OrdersController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var order = _unitOfWork.OrderRepository.GetAll();
            return new JsonResult(order);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = _unitOfWork.OrderRepository.GetById(id);
            return new JsonResult(order);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.Order order)
        {
            _unitOfWork.OrderRepository.Insert(order);
            _unitOfWork.Complete();
            return new JsonResult(order);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.Order order)
        {
            _unitOfWork.OrderRepository.Update(order);
            _unitOfWork.Complete();
            return new JsonResult(order);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.OrderRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}