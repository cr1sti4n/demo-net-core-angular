using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestDemo.Models;
using TestDemo.Models.Response;

namespace TestDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly PollContext _context;

        public LoginController(PollContext context)
        {
            _context = context;
        }


        [HttpPost("[action]")]
        public MyResponse Login([FromBody]Login model)
        {
            MyResponse oR = new MyResponse();
            try
            {
                User user = _context.Users.FirstOrDefault(x => x.Email == model.Email);

                if (user == null)
                {
                    oR.Success = 0;
                    oR.Message = "Usuario o Password incorrecrtos";
                    return oR;
                }

                if (user.Password != model.Password)
                {
                    oR.Success = 0;
                    oR.Message = "Usuario o Password incorrecrtos";
                    return oR;

                }

                oR.Success = 1;
                oR.Message = "Success";
                oR.Data = user;

                return oR;

            }
            catch (Exception ex)
            {
                oR.Success = 0;
                oR.Message = ex.Message;
                return oR;
            }


        }
    }
}