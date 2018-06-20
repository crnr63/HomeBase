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
using Microsoft.AspNetCore.Http;

namespace HomeBase.Controllers
{
[Authorize(Roles = "Admin")]

 public class AdminController : Controller
    {
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<ApplicationUser> _userManager;

    private readonly ApplicationDbContext _context;
    public AdminController(
           ApplicationDbContext ApplicationDbContext,
           RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager
           ){
            _context = ApplicationDbContext;
            _roleManager= roleManager;
            _userManager = userManager;

            }

        public async Task<IActionResult> Index()
        {  
            var users = await _context.Users.Select(x => x).ToListAsync();

           var Rolesz=
                        (from ro in _context.Roles
                        join usr in _context.UserRoles on ro.Id equals usr.RoleId
                        select  new { RoleName = ro.NormalizedName, useridrolestb=usr.UserId }).Distinct();


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
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Rolesz=
                        (from ro in _context.Roles
                         select  new { RoleName = ro.Name});
            List<SelectListItem> RolesList= new List<SelectListItem>();
            foreach ( var item in Rolesz){
            RolesList.Add(new SelectListItem{ Value = item.RoleName, Text = item.RoleName });
            }

            var CurrentUser = await _context.Users.SingleOrDefaultAsync(m => m.Id== id );
            if (CurrentUser== null)
            {
                return NotFound();
            }
            adminUserEditViewModel EditViewModel= new adminUserEditViewModel()
            {
            Email=CurrentUser.Email,
            Username=CurrentUser.UserName,
            ID=CurrentUser.Id,
            Roles=RolesList
            };
            return View(EditViewModel);
        }

        // POST: QOTD/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.U
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Email,Username,Roles")] adminUserEditViewModel adminUserEdit,IFormCollection form)
        {

            if (id != adminUserEdit.ID)
            {
                return NotFound();
            }
;
            var CurrentUser = await _context.Users.SingleOrDefaultAsync(m => m.Id== id );
  
              
            if (adminUserEdit != null && ModelState.IsValid)
            {
                try
                { //optimize
                 var yes = await _context.UserRoles.Where(x=> x.UserId == id ).ToListAsync();
                   foreach (var roleEntry in yes){
                        Debug.Print(roleEntry.RoleId);
                      var ff= _context.UserRoles.Remove(roleEntry);
                    }

                   foreach (var roles in form["Roles"]){
                    await _userManager.AddToRoleAsync(CurrentUser, roles);   
              
               }
                  await _context.SaveChangesAsync();
        
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(adminUserEdit.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(adminUserEdit);
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
   


    }


}