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
    public class EmployeesController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public EmployeesController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var employee = _unitOfWork.EmployeeRepository.GetAll();
            return new JsonResult(employee);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = _unitOfWork.EmployeeRepository.GetById(id);
            return new JsonResult(employee);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.Employee employee)
        {
            _unitOfWork.EmployeeRepository.Insert(employee);
            _unitOfWork.Complete();
            return new JsonResult(employee);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);
            _unitOfWork.Complete();
            return new JsonResult(employee);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.EmployeeRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}