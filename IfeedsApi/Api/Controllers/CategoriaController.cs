using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using IfeedsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/categorias")]
    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaService _categoriaService;
        private readonly IMapper _mapper;

        public CategoriaController(CategoriaService categoriaService, IMapper mapper)
        {
            _categoriaService = categoriaService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<CategoriaModel>> Get()
        {
            var categorias = _categoriaService.Listar();
            return _mapper.Map<List<CategoriaModel>>(categorias);
        }
    }
}