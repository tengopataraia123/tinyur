using Mapster;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortener.Services.Abstractions;
using UrlShortener.Services.Models;
using UrlShortener.ViewModels;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrlShortenerController : Controller
    {

        private readonly IUrlsService _service;

        public UrlShortenerController(IUrlsService service)
        {
            _service = service;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var url = await _service.GetAsync(id);
            string redirectUrl = url.DestinationUrl;
            return Redirect (redirectUrl);
        }

        [HttpPost("/")]
        public async Task<IActionResult> Post([FromForm]Url url)
        {
            url.Id = await _service.AddAsync(url.Adapt<Domain.Url>());
            return View("Result", url);
        }
    }
}
