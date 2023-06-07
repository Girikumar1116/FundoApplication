using BusinessLayer.Interface;
using CommonLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundoNoteApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController :ControllerBase
    {
        private readonly IUserBL userBL;
        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
            
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(UserRegistration userRegistration) 
        {
            try
            {
                var result = userBL.Register(userRegistration);
                if (result!=null)
                {
                    return this.Ok(new {success=true,message="user registration success",data=result});
                }
                else
                {
                    return this.BadRequest(new { success = false, message = "user registration unsuccess" });
                }
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(UserLogin login)
        {
            try
            {
                var result = userBL.Login(login);
                if (result!=null)
                {
                    return this.Ok(new { success = true, msg = "successfully login", data = result });
                }
                else
                {
                    return this.BadRequest(new { success = false, msg = "check ur password " });
                }
            }
            catch(System.Exception) { throw; }
        }
    }
}
