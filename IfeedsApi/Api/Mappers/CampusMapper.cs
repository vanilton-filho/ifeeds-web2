using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Mappers
{
    public class CampusMapper
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CampusMapper(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CampusModel ToModel(Campus campus)
        {
            var campusModel = _mapper.Map<CampusModel>(campus);
            return campusModel;
        }

        public List<CampusModel> ToCollection(List<Campus> campus)
        {
            List<CampusModel> avaliacoesModel = new List<CampusModel>();
            campus.ForEach(a =>
            {
                avaliacoesModel.Add(ToModel(a));
            });
            return avaliacoesModel;
        }

    }
}