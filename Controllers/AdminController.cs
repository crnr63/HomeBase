using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeBase.Models;

using System.Security.Claims;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using HomeBase.Models.AccountViewModels;
using HomeBase.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using HomeBase.Data;

namespace HomeBase.Controllers
{
[Authorize(Roles = "Admin,preApproval")]

 public class AdminController : Controller
    {
   
      private readonly ApplicationDbContext _context;

        public AdminController( ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {  
            var users = await _context.Users.Select(x => x).ToListAsync();

            var Rolesz=
            from ro in _context.Roles
            join usr in _context.UserRoles on ro.Id equals usr.RoleId
            select new { RoleName = ro.NormalizedName, useridrolestb=usr.UserId };


            Dictionary<string,adminViewModel> trip = new Dictionary<string,adminViewModel>();
        
            foreach ( var us in users){
                trip.Add(us.Id,new adminViewModel{ID=us.Id, Username=us.UserName, Email= us.Email, RolesList= "" });
            }
        
            Console.WriteLine("Key = {0}, Value = {1}", trip["0440d88d-cbfe-459a-ba75-9e3f20c8af51"].Username,trip["0440d88d-cbfe-459a-ba75-9e3f20c8af51"].ID);
        
            foreach( var role in Rolesz){
                trip[role.useridrolestb].RolesList += (role.RoleName+ " , ") ;
            }
        
            ICollection<adminViewModel> finalprod = new List<adminViewModel>();
        
            foreach(KeyValuePair<string,adminViewModel> ad in trip){
                finalprod.Add(ad.Value);
            }
        
            Debug.Print(finalprod.Count.ToString());
        
        return View(finalprod);
        }

        public IActionResult NonAdmin()
        {
        return View();
        }
    }


}