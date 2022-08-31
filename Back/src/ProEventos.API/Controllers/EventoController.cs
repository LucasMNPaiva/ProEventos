using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {

        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id){

            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
        [HttpPut("{id}")]

        public Evento Put(int id){
            return null;
        }

        [HttpDelete("{id}")]
        public void Delete(int id){
            _context.Eventos.Remove(_context.Eventos.FirstOrDefault(ev => ev.EventoId == id));
        }
    }
}
