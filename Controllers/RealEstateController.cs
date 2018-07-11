using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeBase.Models;
using Microsoft.AspNetCore.Authorization;

namespace HomeBase.Controllers
{[Authorize]
    public class RealEstateController : Controller
    {
        private readonly QOTDContext _context;

        public RealEstateController(QOTDContext context)
        {
            _context = context;
        }

        // GET: Participant
        public async Task<IActionResult> Index()
        {
            return View(await _context.USAHouses.ToListAsync());
        }

        // GET: Participant/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participantQOTD = await _context.ParticipantQOTD
                .SingleOrDefaultAsync(m => m.ID == id);
            if (participantQOTD == null)
            {
                return NotFound();
            }

            return View(participantQOTD);
        }

        // GET: Participant/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Participant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,GivenName,FamilyName,DateCreated,Creator")] ParticipantQOTD participantQOTD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(participantQOTD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(participantQOTD);
        }

        // GET: Participant/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participantQOTD = await _context.ParticipantQOTD.SingleOrDefaultAsync(m => m.ID == id);
            if (participantQOTD == null)
            {
                return NotFound();
            }
            return View(participantQOTD);
        }

        // POST: Participant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,GivenName,FamilyName,DateCreated,Creator")] ParticipantQOTD participantQOTD)
        {
            if (id != participantQOTD.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(participantQOTD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
               //     if (!ParticipantQOTDExists(participantQOTD.ID))
              //      {
             //           return NotFound();
             //       }
            //        else
            //        {
           //             throw;
            //        }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(participantQOTD);
        }

        // GET: Participant/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participantQOTD = await _context.ParticipantQOTD
                .SingleOrDefaultAsync(m => m.ID == id);
            if (participantQOTD == null)
            {
                return NotFound();
            }

            return View(participantQOTD);
        }

        // POST: Participant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var participantQOTD = await _context.ParticipantQOTD.SingleOrDefaultAsync(m => m.ID == id);
            _context.ParticipantQOTD.Remove(participantQOTD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

  
    }
}
