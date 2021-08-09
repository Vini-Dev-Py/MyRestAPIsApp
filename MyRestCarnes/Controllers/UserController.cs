using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyRestCarnes.Business;
using MyRestCarnes.Data.VO;
using System;

namespace MyRestCarnes.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : ControllerBase
    {
        private IUserBusiness _userBusiness;

        public UserController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            return Ok(_userBusiness.FindAll());
        }

        [HttpGet("{username}")]
        public IActionResult GetUser(string username) 
        {
            var user = _userBusiness.FindByUsername(username);
            if (user == null) return NotFound();

            user.Password = "Authorized";

            return Ok(user);
        }
    }
}