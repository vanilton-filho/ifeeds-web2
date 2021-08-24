using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;
using IfeedsApi.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers.V1
{
    [ApiController]
    [Route("/v1/api/campus")]
    public class CampusController : ControllerBase
    {
        private readonly CampusMapper _campusMapper;
        private readonly CampusService _campusService;
        private readonly IMapper _mapper;


        public CampusController(CampusMapper campusMapper, CampusService campusService, IMapper mapper)
        {
            _campusMapper = campusMapper;
            _campusService = campusService;
            _mapper = mapper;

        }

        [HttpGet]
        public ActionResult<ICollection<CampusModel>> Get()
        {
            var campus = _campusService.Listar();
            var campusModel = _campusMapper.ToCollection(campus);
            return new OkObjectResult(campusModel);
        }

        [HttpGet("{id}", Name = "GetCampusId")]
        public ActionResult<CampusModel> Get(int id)
        {
            var campus = _campusService.BuscarPorId(id);
            if (campus == null)
            {
                return NotFound();
            }
            var campusModel = _campusMapper.ToModel(campus);
            return new OkObjectResult(campusModel);
        }


        [HttpPost]
        public ActionResult Post([FromBody] CampusModelRequest request)
        {
            var campus = _mapper.Map<Campus>(request);
            var campusSalvo = _campusService.Salvar(campus);
            if (campusSalvo == null)
            {
                return BadRequest();
            }
            var campusModel = _campusMapper.ToModel(campusSalvo);
            return new CreatedAtRouteResult("GetCampusId", new { campusSalvo.Id }, campusModel);
        }


        [HttpPut("{id}")]
        public ActionResult<CampusModel> Put(int id, [FromBody] CampusModelRequest request)
        {
            var campus = _mapper.Map<Campus>(request);
            var campusAtualizado = _campusService.Atualizar(id, campus);

            if (campusAtualizado == null)
            {
                return NotFound();
            }
            var campusModel = _campusMapper.ToModel(campusAtualizado);
            return new OkObjectResult(campusModel);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_campusService.Deletar(id))
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}