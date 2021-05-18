using Microsoft.AspNetCore.Mvc;
using StockTrackerAPI.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/testdatabase")]
    public class testController : ControllerBase
    {
        private readonly StockInfoContext stock;

        public testController(StockInfoContext stock)
        {
            this.stock = stock;
        }

        public IActionResult TestDatabase() 
        {
            return Ok();
        }
    }
}
