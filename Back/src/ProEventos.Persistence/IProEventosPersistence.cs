using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        //Geral
        void Add<T>(T entity) where T: class;

        void Update<T>(T entity) where T: class;

        void Delete<T>(T entity) where T: class;

        void DeleteRange<T>(T[] entityArray) where T: class;


        Task<bool> SavesChangesAsync();


        //Events

        Task<Evento[]> GetAllEventosByTemaAsync(string tema,bool includePalestrante);

        Task<Evento[]> GetAllEventosAsync(bool includePalestrante);

        Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrante);

        //Palestrantes
        Task<Evento[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos);

        Task<Evento[]> GetAllPalestrantesAsync(bool includeEventos);

        Task<Evento> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos);




        



    }
}