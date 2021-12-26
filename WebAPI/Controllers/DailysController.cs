using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailysController : ControllerBase
    {

        IDailyService _dailyService;
        public DailysController(IDailyService dailyService)
        {
            _dailyService = dailyService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _dailyService.GetAll();
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Daily daily)
        {
             _dailyService.Add(daily);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Daily daily)
        {
            _dailyService.Delete(daily);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(Daily daily)
        {
            _dailyService.Update(daily);
            return Ok();
        }
    }
}
