using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UsersRestAPI.Model.Context;
using UsersRestAPI.Business ;
using UsersRestAPI.Business.Implementations;
using UsersRestAPI.Repository;
using UsersRestAPI.Repository.Implementations;
using Microsoft.Extensions.Logging;
using UsersRestAPI.Repository.Generic;

namespace UsersRestAPI
{
    public class Startup
    {
        private readonly Microsoft.Extensions.Logging.ILogger _logger;
        public IConfiguration _configuration { get; }
        public IHostingEnvironment _environment { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment environment, ILogger<Startup> logger)
        {
            _configuration = configuration;
            _environment = environment;
            _logger = logger;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = _configuration["MySqlConnection:MySqlConnectioString"];
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connectionString));

            services.AddMvc();

            services.AddScoped<IRoleBusiness, RoleBusinessImpl>();
            services.AddScoped<IRoleRepository, RoleRepositoryImpl>();
            services.AddScoped<IPermissionBusiness, PermissionBusinessImpl>();
            services.AddScoped<IPermissionRepository, PermissionRepositoryImpl>();
            services.AddScoped<IUserBusiness, UserBusinessImpl>();
            services.AddScoped<IUserRepository, UserRepositoryImpl>();

            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
