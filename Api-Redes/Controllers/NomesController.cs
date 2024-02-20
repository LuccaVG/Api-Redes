using Api_Redes.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Redes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NomesController : ControllerBase
    {
        NomesRepository n = new NomesRepository();
    }
}
