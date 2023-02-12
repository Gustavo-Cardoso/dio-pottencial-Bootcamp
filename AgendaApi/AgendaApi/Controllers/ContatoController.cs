using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaApi.Models;
using AgendaApi.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
    }
}