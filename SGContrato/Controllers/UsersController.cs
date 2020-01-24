using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using SGContrato.Models;
using Microsoft.AspNetCore.Authentication;

namespace SGContrato.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private MyDBContext _context;

        public UsersController(MyDBContext context)
        {
            _context = context;
        }


        [AllowAnonymous]
        [HttpGet("authenticate")]
        public async Task<IActionResult> AuthenticateAsync()
        {
            string returnUrl = "https://localhost:5001/contratos";
            var props = new AuthenticationProperties { RedirectUri = returnUrl };
            await HttpContext.ChallengeAsync("CAS", props);

            HttpContext.User.ToString();
            
            //como llamar a cas para que haga la autenticacion

            if (HttpContext.User == null)
                return NotFound();
            return Ok(HttpContext.User);
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            User users = null;
            return Ok(users);
        }
    }
}

//using WebApi.Services;
