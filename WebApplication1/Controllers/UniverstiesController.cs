using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniverstiesController : ControllerBase
    {
        IUniversityService _universityService;

        public UniverstiesController(IUniversityService universityService)
        {
            _universityService = universityService;
        }

       [HttpGet("getall")]
       public IActionResult Getall()
        {
            var result = _universityService.GetAll();
            if (result.Success)
            {
                Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyuniversityıd")]
        public IActionResult GetbyUnviersty(int id)
        {
            var result = _universityService.GetByUniversityId(id);
            if (result.Success)
            {
                Ok(result);

            }
            return BadRequest(result);
        }


        [HttpPost ("add")]
        public IActionResult Add(University university)
        {
            var result = _universityService.Add(university);
            if (result.Success)
            {
                Ok(result);
            }
           return  BadRequest(result); 
        }

        [HttpPost("uodate")]
        public IActionResult Update(University university)
        {
            var result = _universityService.Update(university);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(University university)
        {
            var result = _universityService.Delete(university);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }



    }
}
