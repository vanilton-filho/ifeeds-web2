using IfeedsApi.Api.Mappers;
using IfeedsApi.Domain.Services;
using IfeedsApi.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IfeedsApi.Core.Configs
{
    public class ServicesRegisterConfig
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<AvaliacaoMapper, AvaliacaoMapper>();
            services.AddTransient<AvaliacaoService, AvaliacaoService>();
            services.AddTransient<UsuarioMapper, UsuarioMapper>();
            services.AddTransient<UsuarioService, UsuarioService>();
            services.AddTransient<CategoriaService, CategoriaService>();
            services.AddTransient<FeedbackMapper, FeedbackMapper>();
            services.AddTransient<FeedbackService, FeedbackService>();
            services.AddTransient<RespostaFeedbackMapper, RespostaFeedbackMapper>();
            services.AddTransient<RespostaFeedbackService, RespostaFeedbackService>();
            services.AddTransient<EstatisticaMapper, EstatisticaMapper>();
            services.AddTransient<EstatisticaService, EstatisticaService>();
            services.AddTransient<CampusMapper, CampusMapper>();
            services.AddTransient<CampusService, CampusService>();
            services.AddTransient<CategoriaMapper, CategoriaMapper>();
            services.AddTransient<ContatoService, ContatoService>();
            services.AddTransient<ContatoMapper, ContatoMapper>();
            services.AddTransient<RoleService, RoleService>();
            services.AddTransient<RoleMapper, RoleMapper>();
        }
    }
}