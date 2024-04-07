using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public ActionResult Add(CreateBrandRequest createBrandRequest)
        {

            CreatedBrandResponse createdBrandResponse = _brandService.Add(createBrandRequest);
            //return Created("", createdBrandResponse);
            return Ok(createdBrandResponse); //200
        }
    }
}
