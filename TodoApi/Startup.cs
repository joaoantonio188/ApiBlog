using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
using TodoApi.DataAccessObject;
using Swashbuckle.AspNetCore.Swagger;
using TodoApi.Implementação;
using BusinessLayer.Interface;

namespace TodoApi
{
    
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var connection = @"Server=(localdb)\mssqllocaldb;Database=TodoAPI;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<TodoContext>(options => options.UseSqlServer(connection));

            services.AddTransient<IBlogDao, BlogDao>();
            services.AddTransient<IBlogBll, BlogBll>();

        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
