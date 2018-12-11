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

namespace UsersRestAPI
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
            var connection = Configuration["MySqlConnection:MySqlConnectioString"];
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection));

            services.AddMvc();

            services.AddScoped<IRoleBusiness, RoleBusinessImpl>();
            services.AddScoped<IRoleRepository, RoleRepositoryImpl>();
            services.AddScoped<IPermissionBusiness, PermissionBusinessImpl>();
            services.AddScoped<IPermissionRepository, PermissionRepositoryImpl>();
            services.AddScoped<IUserBusiness, UserBusinessImpl>();
            services.AddScoped<IUserRepository, UserRepositoryImpl>();
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
