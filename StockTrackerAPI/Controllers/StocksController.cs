﻿using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<StocksController> logger;

        public StocksController(ILogger<StocksController> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public IActionResult GetStocks()
        {
            return Ok(StockDataStore.Current.Stocks);

        }

        [HttpGet("{id}", Name = "GetStock")]
        public IActionResult GetStock(long id)
        {
            try
            {
                var stock = StockDataStore.Current.Stocks.FirstOrDefault(s => s.Id == id);
                if (stock == null)
                {
                    logger.LogInformation($"Stock with id: {id} was not found.");
                    return NotFound();
                }

                return Ok(stock);
            }
            catch (Exception ex)
            {
                logger.LogCritical($"Exception while getting stock with id: {id}.", ex);
                return StatusCode(500, "A problem has occured while handling your request");
            }


        }

        [HttpPost]
        public IActionResult CreateStock(StockCreationDto stock)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // InMemory Only 
            var nextID = StockDataStore.Current.Stocks.Count();

            var newStock = new StockDto()
            {
                Id = ++nextID,
                AlphaCode = stock.AlphaCode,
                Name = stock.Name,
                Price = stock.Price
            };

            StockDataStore.Current.Stocks.Add(newStock);

            return CreatedAtRoute("GetStock", new { id = newStock.Id }, newStock);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStock(long id, StockUpdateDto stock)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // InMemory Only
            var updatingStock = StockDataStore.Current.Stocks.FirstOrDefault(s => s.Id == id);

            if (updatingStock == null)
            {
                return NotFound();
            }

            updatingStock.AlphaCode = stock.AlphaCode;
            updatingStock.Name = stock.Name;
            updatingStock.Price = stock.Price;

            return NoContent();

        }

        /** JSON Patch Body
         *  Example     [
                            {
                                "value": "Updated - NY Mellon",
                                "path": "/name",
                                "op": "replace"
                             },
                        ]
         **/
        [HttpPatch("{id}")]
        public IActionResult PartialUpdateStock(long id, JsonPatchDocument<StockUpdateDto> patchDocument)
        {

            // InMemory Only
            var updatingStock = StockDataStore.Current.Stocks.FirstOrDefault(s => s.Id == id);

            if (updatingStock == null)
            {
                return NotFound();
            }

            var stockToPatch =
                 new StockUpdateDto()
                 {
                     AlphaCode = updatingStock.AlphaCode,
                     Name = updatingStock.Name,
                     Price = updatingStock.Price
                 };

            patchDocument.ApplyTo(stockToPatch, ModelState); //Must have Microsoft.Asp.Net.MVC.NewtonsoftJson installed

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Checks to make sure that required fields can
            // not be removed
            if (!TryValidateModel(stockToPatch))
            {
                return BadRequest(ModelState);
            }

            updatingStock.AlphaCode = stockToPatch.AlphaCode;
            updatingStock.Name = stockToPatch.Name;
            updatingStock.Price = stockToPatch.Price;

            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStock(long id)
        {
            // InMemory Only
            var stock = StockDataStore.Current.Stocks.FirstOrDefault(s => s.Id == id);

            if (stock == null)
            {
                return NotFound();
            }

            StockDataStore.Current.Stocks.Remove(stock);

            return NoContent();
        }
    }
}
