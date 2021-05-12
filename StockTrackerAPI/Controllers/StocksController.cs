using Microsoft.AspNetCore.Mvc;
using StockTrackerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StocksController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetStocks() 
        {
            return new JsonResult(StockDataStore.Current.Stocks);
           
        }
    }
}
