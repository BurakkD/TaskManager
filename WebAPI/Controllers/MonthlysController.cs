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
    public class MonthlysController : ControllerBase
    {
        IMonthlyService _monthlyService;
        public MonthlysController(IMonthlyService monthylService)
        {
            _monthlyService = monthylService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Monthly monthly)
        {
            _monthlyService.Add(monthly);
            return Ok("İşlem Başarılı");
        }

        [HttpPost("add")]
        public IActionResult Add(Monthly monthly)
        {
            _monthlyService.Add(monthly);
            return Ok("İşlem Başarılı");
        }


        [HttpGet("delete")]
        public IActionResult Delete(Monthly monthly)
        {
            _monthlyService.Delete(monthly);
            return Ok("İşlem Başarılı");
        }


        [HttpGet("update")]
        public IActionResult Update(Monthly monthly)
        {
            _monthlyService.Update(monthly);
            return Ok("İşlem Başarılı");
        }
    }
}
