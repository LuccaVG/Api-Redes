using Api_Redes.Domains;

namespace Api_Redes.Interfaces
{
    public interface INomesRepository
    {
        Nomes BuscarPorId(Guid id);
    }
}
