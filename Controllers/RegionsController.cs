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
    public class RegionsController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public RegionsController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var region = _unitOfWork.RegionRepository.GetAll();
            return new JsonResult(region);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var region = _unitOfWork.RegionRepository.GetById(id);
            return new JsonResult(region);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.Region region)
        {
            _unitOfWork.RegionRepository.Insert(region);
            _unitOfWork.Complete();
            return new JsonResult(region);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.Region region)
        {
            _unitOfWork.RegionRepository.Update(region);
            _unitOfWork.Complete();
            return new JsonResult(region);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.RegionRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}