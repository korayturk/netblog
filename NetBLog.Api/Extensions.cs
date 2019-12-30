using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NetBLog.Api.Cache;
using NetBLog.Data;
using NetBLog.Repository.Implementation;
using NetBLog.Repository.Interfaces;
using NetBLog.Service.Configuration;
using NetBLog.Service.Implementation;
using NetBLog.Service.Interfaces;
using Serilog;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Collections.Generic;
using System.Text;

namespace NetBLog.Api
{
    public static class Extensions
    {
        public static void LoadDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var options = new DbContextOptionsBuilder();
            options.UseSqlServer(configuration.GetConnectionString(nameof(NetBLogDbContext)));
            services.AddScoped<DbContext>(x => new NetBLogDbContext(options.Options));


            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));

            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            services.AddScoped(typeof(IBlogService), typeof(BlogService));
            services.AddScoped(typeof(IUserService), typeof(UserService));
            services.AddScoped(typeof(ICommentService), typeof(CommentService));

            services.AddAutoMapper(typeof(AutoMapperConfiguration));

            services.AddSingleton<ILogger>(new LoggerConfiguration()
                .WriteTo.MongoDB(configuration.GetSection("MongoDbConnection:Url").Value,
                collectionName: configuration.GetSection("MongoDbConnection:ActivityLogCollectionName").Value)
                .CreateLogger());

            if (configuration.GetSection("CacheSettings:CacheWith")?.Value == "Redis")
            {
                services.AddSingleton(typeof(ICacheManager), typeof(RedisCache));

                services.AddDistributedRedisCache(cacheOptions =>
                {
                    cacheOptions.Configuration = configuration.GetSection("CacheSettings:RedisConfiguration").Value;
                    cacheOptions.InstanceName = configuration.GetSection("CacheSettings:RedisInstanceName").Value;
                });
            }
            else
            {
                //in-memory
                services.AddSingleton(typeof(ICacheManager), typeof(MemoryCache));
                services.AddMemoryCache();
            }
        }

        public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var securityKey = configuration.GetSection("AppSettings:Secret").Value;
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = configuration.GetSection("AppSettings:Issuer").Value,
                    ValidateAudience = true,
                    ValidAudience = configuration.GetSection("AppSettings:Audience").Value,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = symmetricSecurityKey
                });
        }

        public static void AddSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            var swaggerInfo = configuration.GetSection("SwaggerSettings:Info").Get<Info>();
            var apiKeyScheme = configuration.GetSection("SwaggerSettings:ApiKeyScheme").Get<ApiKeyScheme>();

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", swaggerInfo);
                x.AddSecurityDefinition("Bearer", apiKeyScheme);

                var security = new Dictionary<string, IEnumerable<string>>
                {
                    {"Bearer", new string[] { }},
                };

                x.AddSecurityRequirement(security);
            });
        }

        public static void UseSwaggerWithUI(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseSwagger().UseSwaggerUI(x =>
            {
                x.DocumentTitle = configuration.GetSection("SwaggerSettings:DocumentTitle").Value;
                x.SwaggerEndpoint(configuration.GetSection("SwaggerSettings:Endpoint:Url").Value,
                    configuration.GetSection("SwaggerSettings:Endpoint:Name").Value);
                x.DocExpansion(DocExpansion.None);
            });
        }

        public static ICacheManager GetCacheManager(this FilterContext context)
        {
            return (ICacheManager)context.HttpContext.RequestServices.GetService(typeof(ICacheManager));
        }
    }
}
