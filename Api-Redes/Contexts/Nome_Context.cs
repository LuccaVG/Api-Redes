using Api_Redes.Domains;
using Microsoft.EntityFrameworkCore;

namespace Api_Redes.Contexts
{
    public class Nome_Context : DbContext
    {
        public DbSet <Nomes> Nomes { get; internal set; }
    }
}
