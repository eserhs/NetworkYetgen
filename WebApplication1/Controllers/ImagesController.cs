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
    public class ImagesController : ControllerBase
    {
        IImageService _imageService;
        public ImagesController(IImageService carImageService)
        {
            _imageService = carImageService;
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile file, [FromForm] Image image)
        {
            var result = _imageService.Add(file, image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Image image)
        {
            var carDeleteImage = _imageService.GetByImageId(image.Id).Data;
            var result = _imageService.Delete(carDeleteImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile file, [FromForm] Image image)
        {
            var result = _imageService.Update(file, image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _imageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyPersonıd")]
        public IActionResult GetByPersonId(int Id)
        {
            var result = _imageService.GetByPersonId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        [HttpGet("getbyimageid")]
        public IActionResult GetByImageId(int imageId)
        {
            var result = _imageService.GetByImageId(imageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
