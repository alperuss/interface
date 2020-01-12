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
    public class ShippersController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public ShippersController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var shipper = _unitOfWork.ShipperRepository.GetAll();
            return new JsonResult(shipper);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var shipper = _unitOfWork.ShipperRepository.GetById(id);
            return new JsonResult(shipper);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.Shipper shipper)
        {
            _unitOfWork.ShipperRepository.Insert(shipper);
            _unitOfWork.Complete();
            return new JsonResult(shipper);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.Shipper shipper)
        {
            _unitOfWork.ShipperRepository.Update(shipper);
            _unitOfWork.Complete();
            return new JsonResult(shipper);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.ShipperRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}