using Api_Redes.Contexts;
using Api_Redes.Domains;
using Api_Redes.Interfaces;
using System.Linq;

namespace Api_Redes.Repositories
{
    public class NomesRepository : INomesRepository
    {
        private readonly Nome_Context _context;

        public NomesRepository() 
        { 
            _context = new Nome_Context();
        }

        public Nomes BuscarPorId(Guid id)
        {
            try
            {
                return _context.Nomes
                .Select(n => new Nomes
                {
                    IdNomes = n.IdNomes,
                }).FirstOrDefault(n => n.IdNomes == id!);


            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
