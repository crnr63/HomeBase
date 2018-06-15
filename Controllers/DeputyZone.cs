using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeBase.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeBase.Controllers
{
    public class DeputyZoneController : Controller
    {        private readonly QOTDContext _QOTDcontext;

        public DeputyZoneController(
            QOTDContext QOTDcontext){
            _QOTDcontext = QOTDcontext;

            }
        public IActionResult Index()
        {
            return View();
        }
         public async Task<IActionResult> QOTD()
        {
            ViewData["Message"] = "Your contsct page.";
            return View(await _QOTDcontext.QOTD.ToListAsync());

        }  

  
     public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}