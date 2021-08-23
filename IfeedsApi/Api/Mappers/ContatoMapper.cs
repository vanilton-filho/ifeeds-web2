using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Mappers
{
    public class ContatoMapper
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ContatoMapper(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ContatoModel ToModel(Contato contato)
        {
            var contatoModel = _mapper.Map<ContatoModel>(contato);
            return contatoModel;
        }

        public List<ContatoModel> ToCollection(List<Contato> contato)
        {
            List<ContatoModel> contatoModel = new List<ContatoModel>();
            contato.ForEach(a =>
            {
                contatoModel.Add(ToModel(a));
            });
            return contatoModel;
        }
    }
}