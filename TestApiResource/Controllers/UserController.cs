using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiResource.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {

        }
        //[HttpGet]
        //public async Task<IActionResult> GetUsers()
        //{
        //    return 
        //}
    }
}
