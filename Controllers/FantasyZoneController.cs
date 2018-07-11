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
    public class FantasyZoneController : Controller
    {
        private readonly FantasyZoneContext _context;

        public FantasyZoneController(FantasyZoneContext context)
        {
            _context = context;
        }

        // GET: FantasyZone
        public async Task<IActionResult> Index()
        {
            return View(await _context.FantasyWeekGames.ToListAsync());
        }

        // GET: FantasyZone
        public async Task<IActionResult> calc()
        {
            return View(await _context.FantasyWeekGames.ToListAsync());
        }

        // GET: FantasyZone/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fantasyWeekGames = await _context.FantasyWeekGames
                .SingleOrDefaultAsync(m => m.ID == id);
            if (fantasyWeekGames == null)
            {
                return NotFound();
            }

            return View(fantasyWeekGames);
        }

        // GET: FantasyZone/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FantasyZone/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,WeekNumber,ATL_Games,BOS_Games,BKN_Games,CHA_Games,CHI_Games,CLE_Games,DAL_Games,DEN_Games,Det_Games,GSW_Games,HOU_Games,IND_Games,LAC_Games,LAL_Games,MEM_Games,MIA_Games,MIL_Games,MIN_Games,NOP_Games,NYK_Games,OKC_Games,ORL_Games,PHI_Games,PHO_Games,POR_Games,SAC_Games,SAS_Games,TOR_Games,UTA_Games,WAS_Games")] FantasyWeekGames fantasyWeekGames)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fantasyWeekGames);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fantasyWeekGames);
        }

        // GET: FantasyZone/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fantasyWeekGames = await _context.FantasyWeekGames.SingleOrDefaultAsync(m => m.ID == id);
            if (fantasyWeekGames == null)
            {
                return NotFound();
            }
            return View(fantasyWeekGames);
        }

        // POST: FantasyZone/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,WeekNumber,ATL_Games,BOS_Games,BKN_Games,CHA_Games,CHI_Games,CLE_Games,DAL_Games,DEN_Games,Det_Games,GSW_Games,HOU_Games,IND_Games,LAC_Games,LAL_Games,MEM_Games,MIA_Games,MIL_Games,MIN_Games,NOP_Games,NYK_Games,OKC_Games,ORL_Games,PHI_Games,PHO_Games,POR_Games,SAC_Games,SAS_Games,TOR_Games,UTA_Games,WAS_Games")] FantasyWeekGames fantasyWeekGames)
        {
            if (id != fantasyWeekGames.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fantasyWeekGames);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FantasyWeekGamesExists(fantasyWeekGames.ID))
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
            return View(fantasyWeekGames);
        }

        // GET: FantasyZone/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fantasyWeekGames = await _context.FantasyWeekGames
                .SingleOrDefaultAsync(m => m.ID == id);
            if (fantasyWeekGames == null)
            {
                return NotFound();
            }

            return View(fantasyWeekGames);
        }

        // POST: FantasyZone/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fantasyWeekGames = await _context.FantasyWeekGames.SingleOrDefaultAsync(m => m.ID == id);
            _context.FantasyWeekGames.Remove(fantasyWeekGames);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FantasyWeekGamesExists(int id)
        {
            return _context.FantasyWeekGames.Any(e => e.ID == id);
        }
    }
}
