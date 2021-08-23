using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Mappers
{
    public class CategoriaMapper
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CategoriaMapper(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CategoriaModel ToModel(Categoria categoria)
        {
            var categoriaModel = _mapper.Map<CategoriaModel>(categoria);
            return categoriaModel;
        }

        public List<CategoriaModel> ToCollection(List<Categoria> categoria)
        {
            List<CategoriaModel> categoriasModel = new List<CategoriaModel>();
            categoria.ForEach(a =>
            {
                categoriasModel.Add(ToModel(a));
            });
            return categoriasModel;
        }
    }
}