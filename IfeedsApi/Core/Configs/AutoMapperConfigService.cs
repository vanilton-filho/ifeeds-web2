using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace IfeedsApi.Core.Configs
{
    public class AutoMapperConfigService
    {
        public static void Configure(IServiceCollection services)
        {
            var mappingProfile = new MapperConfiguration(mc =>
            {
                mc.AddMaps("IfeedsApi");
            });

            IMapper mapper = mappingProfile.CreateMapper();
            services.AddSingleton(mapper); // registro do tipo singleton

            // NewtonsoftJson config
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
        }
    }
}