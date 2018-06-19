using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HomeBase.Data;
using HomeBase.Models;
using HomeBase.Services;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using HomeBase.Controllers;

namespace HomeBase
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public async Task SeedUser(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();  

            if (userManager.FindByNameAsync("jlibok@github.com").Result == null)
                {
                    ApplicationUser user = new ApplicationUser { 
                        UserName = "jlibok@github.com", 
                        Email = "jlibok@github.com" 
                    };
                    
                    var result = await userManager.CreateAsync(user, "Tour4Hire");
           
                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user,"PotentialEmployer").Wait();
                    }
                }
        }  
        private async Task CreateUserRoles(IServiceProvider serviceProvider)  
        {  
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();  
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();  
            IdentityResult roleResult;  
            //Adding Addmin Role  
            //List<IdentityRole> roleChecks = await RoleManager.Roles.ToListAsync();  
            var roleCheckpreapp = await RoleManager.RoleExistsAsync("preApproval");  
            var deputycheck = await RoleManager.RoleExistsAsync("député");  
            var roleCheckpe = await RoleManager.RoleExistsAsync("PotentialEmployer");  
            var roleCheck = await RoleManager.RoleExistsAsync("Admin");  
            if (!roleCheck)  
            {  
                //create the roles and seed them to the database  
                roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));  
            }  
            if (!deputycheck)  
            {  
                //create the roles and seed them to the database  
                roleResult = await RoleManager.CreateAsync(new IdentityRole(("Député")));  
            }  
            if (!roleCheckpreapp)  
            {  
                //create the roles and seed them to the database  
                roleResult = await RoleManager.CreateAsync(new IdentityRole("PreApproval"));  
            }  
            if (!roleCheckpe)  
            {  
                //create the roles and seed them to the database  
                roleResult = await RoleManager.CreateAsync(new IdentityRole("PotentialEmployer"));  
            }  
 
        }  
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {  

                        // Use SQL Database if in Azure, otherwise, use SQLite
            if(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production"){
                services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("MyDbConnection")));
                              services.AddDbContext<QOTDContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("MyDbConnection")));
            }
            else{
              services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
                
            services.AddDbContext<QOTDContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
                            
            }
             

            // Automatically perform database migration
            services.BuildServiceProvider().GetService<ApplicationDbContext>().Database.Migrate();
            services.BuildServiceProvider().GetService<QOTDContext>().Database.Migrate();

                        
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();


            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 6;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                // If the LoginPath isn't set, ASP.NET Core defaults 
                // the path to /Account/Login.
                options.LoginPath = "/Account/Login";
                // If the AccessDeniedPath isn't set, ASP.NET Core defaults 
                // the path to /Account/AccessDenied.
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
                // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Home/Error/");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            
            CreateUserRoles(services).Wait();
            SeedUser(services).Wait();
        }
    }
}
