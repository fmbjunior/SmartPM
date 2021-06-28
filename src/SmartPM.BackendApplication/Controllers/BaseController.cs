using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartPM.BackendApplication.Models;
using SmartPM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPM.BackendApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TController> : ControllerBase
    {
        protected IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErroRequestResult
                {
                    Erro = true,
                    Message = ex.Message
                });
            }
        }
    }
}
