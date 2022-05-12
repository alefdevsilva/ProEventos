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
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       public IEnumerable<Evento> evento = new Evento[]
                            {
            new Evento()
                        {
              EventoId = 1,
              Tema = "Angular 12 e .NET 5",
              local = "São Paulo",
              Lote = "12 Lotes",
              QtdePessoas = 250,
              DataEvento = DateTime.Now.AddDays(2).ToString(),
              ImagemURL = "Foto.png"
            },
             new Evento()
                        {
              EventoId = 2,
              Tema = ".NET CORE",
              local = "Rio de Janeiro",
              Lote = "15 Lotes",
              QtdePessoas = 150,
              DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
              ImagemURL = "Foto.png"
            }
          };
        public EventoController(){
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return evento;
          
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
          return evento.Where(evento => evento.EventoId == id);
          
        }

        [HttpPost]
        public string Post()
        {
          return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
          return $"Exemplo de Put com id: {id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
          return $"Exemplo de DElete com id: {id}";
        }
    }
}
