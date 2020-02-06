using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop.Main;
using Shop.Main.Interfaces;
using Shop.Main.MockData;
using Shop.Main.Repository;

namespace Shop
{
    public class Startup
    {
        private IConfigurationRoot _dbConf;
        public Startup(IHostingEnvironment ENV)
        {
            _dbConf = new ConfigurationBuilder().SetBasePath(ENV.ContentRootPath).AddJsonFile("settings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DBContent>(options => options.UseSqlServer(_dbConf.GetConnectionString("DefaultConnection")));

            services.AddTransient<ICategoryPhone, CategoryPhoneRepository>();
            services.AddTransient<IPhone, PhoneRepository>();
            services.AddTransient<ICPU, CPURepository>();
            services.AddTransient<ICategoryCPU, CategoryCPURepository>();
            services.AddTransient<IGPU, GPURepository>();
            services.AddTransient<ICategoryGPU, CategoryGPURepository>();


            services.AddTransient<IMB, MBRepository>();
            services.AddTransient<ICategoryMB, CategoryMBRepository>();
            services.AddTransient<IRAM, RAMRepository>();
            services.AddTransient<ICategoryRAM, CategoryRAMRepository>();
            services.AddTransient<ISSD, SSDRepository>();
            services.AddTransient<ICategorySSD, CategorySSDRepository>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();


            using (var scope = app.ApplicationServices.CreateScope())
            {
                DBContent content = scope.ServiceProvider.GetRequiredService<DBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
