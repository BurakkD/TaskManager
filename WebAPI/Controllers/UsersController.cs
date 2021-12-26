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
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            return Ok("İşlem Başarılı");
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            _userService.Update(user);
            return Ok("İşlem Başarılı");
        }

        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            _userService.Delete(user);
            return Ok("İşlem Başarılı");
        }

    }
}
