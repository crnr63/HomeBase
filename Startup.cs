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
      public static void SeedUsers(UserManager<IdentityUser> userManager)
{
    if (userManager.FindByNameAsync
("user1").Result == null)
    {
        IdentityUser user = new IdentityUser();
        user.UserName = "user1";
        user.Email = "user1@localhost";
       

        IdentityResult result = userManager.CreateAsync(user, "password_goes_here").Result;

        if (result.Succeeded)
        {
            userManager.AddToRoleAsync(user,"NormalUser").Wait();
        }
    }


    if (userManager.FindByNameAsync("user2").Result == null)
    {
        IdentityUser user = new IdentityUser();
        user.UserName = "hireKhalil";
        user.Email = "user2@localhost";


        IdentityResult result = userManager.CreateAsync(user, "password_goes_here").Result;

        if (result.Succeeded)
        {
            userManager.AddToRoleAsync(user,
                                "Administrator").Wait();
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
 //Assign Admin role to the main User here we have given our newly loregistered login id for Admin management  
            ApplicationUser user = await UserManager.FindByEmailAsync("KhalilJolibois@gmail.com"); 
            List<ApplicationUser> allUsers = await UserManager.Users.ToListAsync();
            foreach (ApplicationUser b in allUsers){
              if (!await UserManager.IsInRoleAsync(b, "Admin"))
            {
                await UserManager.AddToRoleAsync(user, "preApproval");   
             }
               

            }
//if (!RoleManager.RoleExistsAsync("NormalUser").Result)
    //{
      //  IdentityRole role = new IdentityRole();
      //  role.Name = "NormalUser";
      //  role.Description = "Perform normal operations.";
     //   IdentityResult roleResult = RoleManager.
   //     CreateAsync(role).Result;
 //   }

         //   var User = new ApplicationUser();   
           // Debug.Print(User.ToString());
            await UserManager.AddToRoleAsync(user, "Admin");   
  
        }  
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
          services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
    services.AddDbContext<QOTDContext>(options =>
               options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
                     
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        //          services.AddAuthorization(options =>
   // {
   //     options.AddPolicy("AtLeast21", policy =>
   //         policy.Requirements.Add(new MinimumAgeRequirement(21)));
   // });
    //    services.AddSingleton<IAuthorizationHandler,  PermissionHandler>();

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
        }
    }
}
