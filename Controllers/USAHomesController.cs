using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeBase.Models;

namespace HomeBase.Controllers
{
    public class USAHomesController : Controller
    {
        private readonly QOTDContext _context;

        public USAHomesController(QOTDContext context)
        {
            _context = context;
        }

        // GET: USAHomes
        public async Task<IActionResult> Index()
        {
            return View(await _context.USAHouses.ToListAsync());
        }

        // GET: USAHomes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uSAHouses = await _context.USAHouses
                .SingleOrDefaultAsync(m => m.ID == id);
            if (uSAHouses == null)
            {
                return NotFound();
            }

            return View(uSAHouses);
        }

        // GET: USAHomes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: USAHomes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,address,cost,bathrooms,squarefootage,bedrooms,emailID,zipcode,insertionDate,type,state,city")] USAHouses uSAHouses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uSAHouses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uSAHouses);
        }

        // GET: USAHomes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uSAHouses = await _context.USAHouses.SingleOrDefaultAsync(m => m.ID == id);
            if (uSAHouses == null)
            {
                return NotFound();
            }
            return View(uSAHouses);
        }

        // POST: USAHomes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,address,cost,bathrooms,squarefootage,bedrooms,emailID,zipcode,insertionDate,type,state,city")] USAHouses uSAHouses)
        {
            if (id != uSAHouses.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uSAHouses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!USAHousesExists(uSAHouses.ID))
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
            return View(uSAHouses);
        }

        // GET: USAHomes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uSAHouses = await _context.USAHouses
                .SingleOrDefaultAsync(m => m.ID == id);
            if (uSAHouses == null)
            {
                return NotFound();
            }

            return View(uSAHouses);
        }

        // POST: USAHomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var uSAHouses = await _context.USAHouses.SingleOrDefaultAsync(m => m.ID == id);
            _context.USAHouses.Remove(uSAHouses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool USAHousesExists(string id)
        {
            return _context.USAHouses.Any(e => e.ID == id);
        }
    }
}
