using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model);

        Task<Evento> UpdateEventos(int eventoId, Evento model);

        Task<bool> DeleteEventos(int eventoId);


        Task<Evento[]> GetAllEventosByTemaAsync(string tema,bool includePalestrante = false);

        Task<Evento[]> GetAllEventosAsync(bool includePalestrante = false);

        Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrante = false);


    }
}