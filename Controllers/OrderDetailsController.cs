﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UnitOfWorkDeneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public OrderDetailsController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var orderDetail = _unitOfWork.OrderDetailRepository.GetAll();
            return new JsonResult(orderDetail);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var orderDetail = _unitOfWork.OrderDetailRepository.GetById(id);
            return new JsonResult(orderDetail);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.OrderDetail orderDetail)
        {
            _unitOfWork.OrderDetailRepository.Insert(orderDetail);
            _unitOfWork.Complete();
            return new JsonResult(orderDetail);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.OrderDetail orderDetail)
        {
            _unitOfWork.OrderDetailRepository.Update(orderDetail);
            _unitOfWork.Complete();
            return new JsonResult(orderDetail);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.OrderDetailRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}