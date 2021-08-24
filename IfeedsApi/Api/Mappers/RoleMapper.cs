using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Mappers
{
    public class RoleMapper
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RoleMapper(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public RoleModel ToModel(Role role)
        {
            var roleModel = _mapper.Map<RoleModel>(role);

            return roleModel;
        }

        public List<RoleModel> ToCollection(List<Role> role)
        {
            List<RoleModel> avaliacoesModel = new List<RoleModel>();
            role.ForEach(a =>
            {
                avaliacoesModel.Add(ToModel(a));
            });
            return avaliacoesModel;
        }
    }
}