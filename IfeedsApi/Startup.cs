using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IfeedsApi.Api.Config;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Core.Auth;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Services;
using IfeedsApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace IfeedsApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "IfeedsApi",
                    Version = "v1",
                    Description = "API para feedbacks do Instituto Federal de Sergipe"
                });
                // c.EnableAnnotations();
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });


            // Configurando banco de dados MySQL
            string mySqlConnection = Configuration.GetConnectionString("rafaConnection");
            services.AddDbContextPool<ApplicationDbContext>(options =>
                options.UseMySql(mySqlConnection,
                MySqlServerVersion.AutoDetect(mySqlConnection)));

            // Configuração do AutoMapper
            var mappingProfile = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingProfile.CreateMapper();
            services.AddSingleton(mapper); // registro do tipo singleton

            // NewtonsoftJson config
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            // JWT config
            var key = Encoding.ASCII.GetBytes(JwtSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };

                x.Events = new JwtBearerEvents();
                x.Events.OnMessageReceived = context =>
                {

                    if (context.Request.Cookies.ContainsKey("X-Access-Token"))
                    {
                        context.Token = context.Request.Cookies["X-Access-Token"];
                    }

                    return Task.CompletedTask;
                };
            })
            .AddCookie(options =>
                {
                    options.Cookie.SameSite = SameSiteMode.Strict;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    options.Cookie.IsEssential = true;
                });

            // Add services
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

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseCors(options => options
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders()
            );

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "IfeedsApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
