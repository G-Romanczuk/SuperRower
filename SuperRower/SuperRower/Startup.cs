using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperRowerDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SuperRower
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
            services.AddIdentity<IdentityUser, IdentityRole>()
                   .AddEntityFrameworkStores<SuperRowerDbContext>();
            services.AddDbContext<SuperRowerDbContext>(options=>options.UseSqlServer("Server=.;Database=SuperRowerDB;Trusted_Connection=True;"));
            services.AddControllersWithViews();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICrudRepository<Customer>, CustomerRepository>();
            services.AddScoped<IRowerPriceRepository, RowerPriceRepository>();
            services.AddScoped<ICrudRepository<RowerPrice>, RowerPriceRepository>();
            services.AddScoped<IRowerRentRepository, RowerRentRepository>();
            services.AddScoped<ICrudRepository<RowerRent>, RowerRentRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ICrudRepository<Transaction>, TransactionRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            var database = serviceProvider.GetService<SuperRowerDbContext>();
            database.Database.Migrate();

            
        }
    }
}
