using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento()
                {
                EventoId =1,
                Tema = "Angular 11 e .Net 5",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.ToString()
                },
                new Evento()
                {
                EventoId =1,
                Tema = "Angular 11 e .Net 5",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.ToString()
                }
            };


        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
    }
}
