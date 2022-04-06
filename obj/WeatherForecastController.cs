using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurgerController : ControllerBase
    {

        [HttpGet]
        public List<Burger> Get()
        {
          
        }
    }
}
