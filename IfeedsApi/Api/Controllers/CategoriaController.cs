using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
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
        private readonly CategoriaMapper _categoriaMapper;


        public CategoriaController(CategoriaService categoriaService, IMapper mapper, CategoriaMapper categoriaMapper)
        {
            _categoriaService = categoriaService;
            _mapper = mapper;
            _categoriaMapper = categoriaMapper;
        }

        [HttpGet]
        public ActionResult<ICollection<CategoriaModel>> Get()
        {
            var categorias = _categoriaService.Listar();
            return _mapper.Map<List<CategoriaModel>>(categorias);
        }

        [HttpGet("{id}", Name = "GetCategoriaId")]
        public ActionResult<CategoriaModel> Get(int id) 
        {
            var categoria = _categoriaService.BuscarPorId(id);
            if(categoria == null)
            {
                return NotFound();
            }
            var categoriaModel = _categoriaMapper.ToModel(categoria);
            return new OkObjectResult(categoriaModel);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CategoriaModelRequest request)
        {
            var categoria = _mapper.Map<Categoria>(request);
            var categoriaSalva = _categoriaService.Salvar(categoria);
            if(categoriaSalva == null)
            {
                return BadRequest();
            }
            var categoriaModel = _categoriaMapper.ToModel(categoriaSalva);
            return new CreatedAtRouteResult("GetCategoriaId", new {Id = categoriaSalva.Id}, categoriaModel);
        }

         [HttpPut("{id}")]
        public ActionResult<CategoriaModel> Put(int id, [FromBody] CategoriaModelRequest request)
        {
            var categoria = _mapper.Map<Categoria>(request);
            var categoriaAtualizada = _categoriaService.Atualizar(id, categoria);
            
            if(categoriaAtualizada == null)
            {
                return NotFound();
            }
            var categoriaModel = _categoriaMapper.ToModel(categoriaAtualizada);
            return new OkObjectResult(categoriaModel);
        }

         [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(_categoriaService.Deletar(id))
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}