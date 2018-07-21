namespace Exam.Api
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Exam.Domain.Repository.Common;
    using Exam.Infrastructure.Repository.Common;
    using Microsoft.EntityFrameworkCore;
    using AutoMapper;
    using Exam.Domain.Repository.Students;
    using Exam.Application.Service.Students;
    using Exam.Infrastructure.Repository.Students;
    using Exam.Domain.Service.Students;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("MySqlConnection")));

            services.AddScoped<IStudentApplicationService, StudentApplicationService>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentDomainService, StudentDomainService>();

            services.AddScoped<IStudentMaestriaApplicationService, StudentMaestriaApplicationService>();
            services.AddScoped<IStudentMaestriaRepository, StudentMaestriaRepository>();
            services.AddScoped<IStudentMaestriaDomainService, StudentMaestriaDomainService>();

            services.AddScoped<IStudentPreGradoApplicationService, StudentPreGradoApplicationService>();
            services.AddScoped<IStudentPreGradoRepository, StudentPreGradoRepository>();
            services.AddScoped<IStudentPreGradoDomainService, StudentPreGradoDomainService>();

            services.AddScoped<IStudentDoctoradoApplicationService, StudentDoctoradoApplicationService>();
            services.AddScoped<IStudentDoctoradoRepository, StudentDoctoradoRepository>();
            services.AddScoped<IStudentDoctoradoDomainService, StudentDoctoradoDomainService>();


            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<DbInitializer>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowFromAll",
                    builder => builder
                        .AllowAnyMethod()
                        .AllowAnyOrigin()
                        .AllowCredentials()
                        .AllowAnyHeader());
            });

            services.AddAutoMapper();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DbInitializer seeder)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

             var options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("index.html");
            app.UseCors("AllowFromAll").
                UseMvc()
            .UseDefaultFiles(options)
            .UseStaticFiles();

            seeder.Seed().Wait();
        }
    }
}
