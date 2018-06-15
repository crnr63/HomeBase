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
    public class QOTDController : Controller
    {
        private readonly QOTDContext _context;

        public QOTDController(QOTDContext context)
        {
            _context = context;
        }

        // GET: QOTD
        public async Task<IActionResult> Index()
        {
            return View(await _context.QOTD.ToListAsync());
        }

        // GET: QOTD/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qOTD = await _context.QOTD
                .SingleOrDefaultAsync(m => m.ID == id);
            if (qOTD == null)
            {
                return NotFound();
            }

            return View(qOTD);
        }

        // GET: QOTD/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QOTD/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Question,QuestionAuthor,QuestionDate,Theme")] QOTD qOTD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qOTD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(qOTD);
        }

        // GET: QOTD/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qOTD = await _context.QOTD.SingleOrDefaultAsync(m => m.ID == id);
            if (qOTD == null)
            {
                return NotFound();
            }
            return View(qOTD);
        }

        // POST: QOTD/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Question,QuestionAuthor,QuestionDate,Theme")] QOTD qOTD)
        {
            if (id != qOTD.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qOTD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QOTDExists(qOTD.ID))
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
            return View(qOTD);
        }

        // GET: QOTD/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qOTD = await _context.QOTD
                .SingleOrDefaultAsync(m => m.ID == id);
            if (qOTD == null)
            {
                return NotFound();
            }

            return View(qOTD);
        }

        // POST: QOTD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qOTD = await _context.QOTD.SingleOrDefaultAsync(m => m.ID == id);
            _context.QOTD.Remove(qOTD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QOTDExists(int id)
        {
            return _context.QOTD.Any(e => e.ID == id);
        }
    }
}
