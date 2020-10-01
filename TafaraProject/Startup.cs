
using EmployeesRecord.Core.Service;
using EmployeesRecord.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
            services.Configure<Employeedbset>(Configuration.GetSection(nameof(Employeedbset)));
            IServiceCollection serviceCollection = services.AddSingleton((System.Func<System.IServiceProvider, EmployeesRecord.Infrastructure.IEmployeeRepository>)(sp => sp.GetRequiredService<IOptions<Employeedbset>>().Value));

            services.AddSingleton<EmployeeService>();
           // services.AddSingleton<QualificationService>();

            services.AddTransient<IEmployeeRepository, Employeedbset>();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
             new Microsoft.OpenApi.Models.OpenApiInfo
             {
                 Title = "HR Employees365 API",
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
                Options.SwaggerEndpoint("/swagger/v1/swagger.json", "HR Employees365 API");
            });

        }
    }
}
