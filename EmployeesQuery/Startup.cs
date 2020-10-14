using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesQuery.QueryService;
using EmployeesRecord.Infrastructure;
using EmployeesRecord.Infrastructure.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace TafaraProject
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
            services.AddControllers();
            services.Configure<Dbcontext>(Configuration.GetSection(nameof(Dbcontext)));
            IServiceCollection serviceCollection = services.AddSingleton((System.Func<System.IServiceProvider, EmployeesRecord.Infrastructure.Entities.Dbcontext>)(sp => sp.GetRequiredService<IOptions<Dbcontext>>().Value));
            services.AddTransient<EmployeeQueryService>();
            // services.AddTransient<IQualificationRepository, Employeedbset>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IQualificationRepository, QualificationRepository>();
            services.AddTransient<IHRInformationRepository, HRInformationRepository>();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
             new Microsoft.OpenApi.Models.OpenApiInfo
             {
                 Title = "HR Employees365 Query API",
                 Description = "Managing Employees",
                 Version = "v1",
             });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(Options =>
            {
                Options.SwaggerEndpoint("/swagger/v1/swagger.json", "HR Employees365 Query API");
            });
        }
    }
}
