using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data;
using TestingWebPortal.Data.Models;
using TestingWebPortal.DTO;
using TestingWebPortal.Service;

namespace TestingWebPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserReposetory _userReposetory;
        private readonly JwtService _jwt;
        public AuthController(IUserReposetory userReposetory,JwtService jwt)
        {
            _userReposetory = userReposetory;
            _jwt = jwt;
        }
        [HttpPost("registry")]
        public IActionResult Registry(RegistryDTO dto)
        {
            var user = new User
            {
                FullName = dto.FullName,
                Login = dto.Login,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password),
            };
            return Created("User successful created.", _userReposetory.Create(user));
        }
        [HttpPost("login")]
        public IActionResult Login(LoginDTO dto)
        {
            var user = _userReposetory.GetUserByLogin(dto.Login);
            if (user is null)
            {
                return BadRequest("invalid login or password");
            }
            if(!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                return BadRequest("invalid login or password");
            }
            var jwtService = _jwt.Generate(user.Id);
            Response.Cookies.Append("jwt", jwtService, new CookieOptions
            {
                HttpOnly = true
            });
            return Ok(new
            {
                message = "success",

            }

                ); ;
        }
        [HttpGet("User")]
        public IActionResult User()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwt.Verify(jwt);
                var userId = int.Parse(token.Issuer);
                var user = _userReposetory.GetUserById(userId);
                return Ok(user);
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");
            return Ok(new
            {
                message = "success"
            });
        }
    }
}
