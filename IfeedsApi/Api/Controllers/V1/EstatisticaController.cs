using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Domain.Services;
using IfeedsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers.V1
{
    [ApiController]
    [Route("/v1/api/estatisticas")]
    public class EstatisticaController : ControllerBase
    {

        private readonly UsuarioService _usuarioService;
        private readonly EstatisticaMapper _estatisticaMapper;

        public EstatisticaController(UsuarioService usuarioService, EstatisticaMapper estatisticaMapper)
        {
            _usuarioService = usuarioService;
            _estatisticaMapper = estatisticaMapper;
        }

        [HttpGet("{usuarioId}")]
        public ActionResult<EstatisticaModel> GetEstatisticas(int usuarioId)
        {
            var usuario = _usuarioService.BuscarAdminPorId(usuarioId);

            if (usuario == null)
            {
                return NotFound();
            }

            var estatisticaModel = _estatisticaMapper.ToModel(usuarioId);

            return new OkObjectResult(estatisticaModel);
        }
    }
}