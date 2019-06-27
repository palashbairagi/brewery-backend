using System;
using System.Collections.Generic;
using brewerybackend.Models;
using brewerybackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace brewerybackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BreweriesController : ControllerBase
    {
        private readonly BreweryService _breweryService;

        public BreweriesController(BreweryService breweryService)
        {
            _breweryService = breweryService;
        }

        [HttpGet]
        public ActionResult<List<Brewery>> Get()
        {
            return _breweryService.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Brewery> Get(long id)
        {
            var brewery = _breweryService.Get(id);

            if (brewery == null)
            {
                return NotFound();
            }

            return brewery;
        }
    }
}
