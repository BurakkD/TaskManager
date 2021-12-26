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
    public class WeeklysController : ControllerBase
    {
        IWeeklyService _weeklyService;
        public WeeklysController(IWeeklyService weeklyService)
        {
            _weeklyService = weeklyService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _weeklyService.GetAll();
            return Ok(result);
        }
        
        [HttpPost("add")]
        public IActionResult Add(Weekly weekly)
        {
            _weeklyService.Add(weekly);
            return Ok("İşlem Başarılı");
        }

        [HttpPost("delete")]
        public IActionResult Delete(Weekly weekly)
        {
            _weeklyService.Delete(weekly);
            return Ok("İşlem Başarılı");
        }

        [HttpPost("update")]
        public IActionResult Update(Weekly weekly)
        {
            _weeklyService.Update(weekly);
            return Ok("İşlem Başarılı");
        }
    }
}
