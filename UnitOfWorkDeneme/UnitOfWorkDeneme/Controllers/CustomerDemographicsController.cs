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
    public class CustomerDemographicsController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public CustomerDemographicsController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var customerDemographic = _unitOfWork.CustomerDemographicRepository.GetAll();
            return new JsonResult(customerDemographic);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customerDemographic = _unitOfWork.CustomerDemographicRepository.GetById(id);
            return new JsonResult(customerDemographic);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.CustomerDemographic customerDemographic)
        {
            _unitOfWork.CustomerDemographicRepository.Insert(customerDemographic);
            _unitOfWork.Complete();
            return new JsonResult(customerDemographic);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.CustomerDemographic customerDemographic)
        {
            _unitOfWork.CustomerDemographicRepository.Update(customerDemographic);
            _unitOfWork.Complete();
            return new JsonResult(customerDemographic);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.CustomerDemographicRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}