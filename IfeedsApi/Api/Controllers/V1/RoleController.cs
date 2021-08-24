using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Domain.Models;
using IfeedsApi.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers.V1
{
    [ApiController]
    [Route("/v1/api/roles")]
    public class RoleController : ControllerBase
    {
        private readonly RoleMapper _roleMapper;

        private readonly RoleService _roleService;

        private readonly IMapper _mapper;

        public RoleController(RoleMapper roleMapper, RoleService roleService, IMapper mapper)
        {
            _roleMapper = roleMapper;
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<RoleModel>> Get()
        {
            var role = _roleService.Listar();
            var roleModel = _roleMapper.ToCollection(role);
            return new OkObjectResult(roleModel);
        }

        [HttpGet("{id}", Name = "GetRoleId")]
        public ActionResult<RoleModel> Get(int id)
        {
            var role = _roleService.BuscarPorId(id);
            if (role == null)
            {
                return NotFound();
            }
            var roleModel = _roleMapper.ToModel(role);
            return new OkObjectResult(roleModel);
        }

        [HttpPost]
        public ActionResult Post([FromBody] RoleModelRequest request)
        {
            var role = _mapper.Map<Role>(request);
            var roleSalvo = _roleService.Salvar(role);
            if (roleSalvo == null)
            {
                return BadRequest();
            }
            var roleModel = _roleMapper.ToModel(roleSalvo);
            return new CreatedAtRouteResult("GetRoleId", new { roleSalvo.Id }, roleModel);
        }

        [HttpPut("{id}")]
        public ActionResult<RoleModel> Put(int id, [FromBody] RoleModelRequest request)
        {
            var role = _mapper.Map<Role>(request);
            var roleAtualizado = _roleService.Atualizar(id, role);

            if (roleAtualizado == null)
            {
                return NotFound();
            }
            var roleModel = _roleMapper.ToModel(roleAtualizado);
            return new OkObjectResult(roleModel);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_roleService.Deletar(id))
            {
                return NoContent();
            }
            return NotFound();
        }

    }
}