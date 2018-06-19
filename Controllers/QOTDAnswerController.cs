using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeBase.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace HomeBase.Controllers
{
    public class QOTDAnswerController : Controller
    {
        private readonly QOTDContext _context;
        static public List<SelectListItem> Add(List<AuthorListElement>  x, int y)
        { 
         
            List<SelectListItem> intermed = new List<SelectListItem>();
            foreach ( var item in x){
            intermed.Add(new SelectListItem{ Value = item.ID.ToString(), Text = item.FullName });
            }
        return intermed;
        } //END   Add
        public QOTDAnswerController(QOTDContext context)
        {
            _context = context;
        }

        // GET: QOTDAnswer
        public async Task<IActionResult> Index()
        {
            return View(await _context.QOTDAnswer.ToListAsync());
        }

        // GET: QOTDAnswer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qOTDAnswer = await _context.QOTDAnswer
                .SingleOrDefaultAsync(m => m.ID == id);
            if (qOTDAnswer == null)
            {
                return NotFound();
            }

            return View(qOTDAnswer);
        }

        // GET: QOTDAnswer/Create
        public class AuthorListElement
        {
            public string FullName { get; set; }
            public int ID  { get; set; }
        }  
        public async Task<IActionResult> Create([FromRoute] int id)
        {
            // REVIEW
            QOTD QuestionQuery = _context.QOTD.Where(x=> x.ID==id).Select(x => x).FirstOrDefault();
            List<AuthorListElement> AuthorQuery = await _context.ParticipantQOTD.Select(x=> new AuthorListElement { FullName= x.GivenName+" "+ x.FamilyName, ID=x.ID}).OrderBy(x=> x.FullName).Distinct().ToListAsync();
            var QOTDAnswerVM = new QOTDAnswerCreateEditViewModel();
            Add(AuthorQuery,4);

            QOTDAnswerVM.Authors= Add(AuthorQuery,4);
            QOTDAnswerVM.Question = QuestionQuery.Question;
            QOTDAnswerVM.QuestionDate = QuestionQuery.QuestionDate;
            QOTDAnswerVM.QuestionID = id;
            
        return View(QOTDAnswerVM);
        }


        // POST: QOTDAnswer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Question,QuestionID,Authors,QuestionDate,Answer")] QOTDAnswerCreateEditViewModel QOTDAnswerVM,IFormCollection form)
        {   Debug.Print(QOTDAnswerVM.QuestionID.ToString());

          //chane to entry for each author
            Debug.Print("##################################################################################################");
            Debug.Print("##################################################################################################");
            string AuthorIds="";
            foreach( string item in form["Authors"]){
            string ite= item;
            AuthorIds +=ite+",,";            
            }
            QOTDAnswer qOTDAnswer = new QOTDAnswer();
            qOTDAnswer.Question=QOTDAnswerVM.Question;
            qOTDAnswer.QuestionID=QOTDAnswerVM.QuestionID;

            qOTDAnswer.Answer=QOTDAnswerVM.Answer;
            qOTDAnswer.QuestionDate=QOTDAnswerVM.QuestionDate;
            qOTDAnswer.Author = AuthorIds;
                        Debug.Print(qOTDAnswer.Author);

            if (ModelState.IsValid)
            {
                _context.Add(qOTDAnswer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(qOTDAnswer);
        }

        // GET: QOTDAnswer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qOTDAnswer = await _context.QOTDAnswer.SingleOrDefaultAsync(m => m.ID == id);
            List<AuthorListElement> AuthorQuery = await _context.ParticipantQOTD.Select(x=> new AuthorListElement { FullName= x.GivenName+" "+ x.FamilyName, ID=x.ID}).OrderBy(x=> x.FullName).Distinct().ToListAsync();
            var QOTDAnswerVM = new QOTDAnswerCreateEditViewModel();
            QOTDAnswerVM.Answer= qOTDAnswer.Answer;
            QOTDAnswerVM.Authors= Add(AuthorQuery,4);
            QOTDAnswerVM.Question = qOTDAnswer.Question;
            QOTDAnswerVM.QuestionDate = qOTDAnswer.QuestionDate;
            QOTDAnswerVM.QuestionID = id ?? default(int);
            if (qOTDAnswer == null)
            {
                return NotFound();
            }
            return View(QOTDAnswerVM);
        }

        // POST: QOTDAnswer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Question,Author,QuestionAuthor,QuestionDate,Genre,Price,Theme")] QOTDAnswer qOTDAnswer)
        {
            if (id != qOTDAnswer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qOTDAnswer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QOTDAnswerExists(qOTDAnswer.ID))
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
            return View(qOTDAnswer);
        }

        // GET: QOTDAnswer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qOTDAnswer = await _context.QOTDAnswer
                .SingleOrDefaultAsync(m => m.ID == id);
            if (qOTDAnswer == null)
            {
                return NotFound();
            }

            return View(qOTDAnswer);
        }

        // POST: QOTDAnswer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qOTDAnswer = await _context.QOTDAnswer.SingleOrDefaultAsync(m => m.ID == id);
            _context.QOTDAnswer.Remove(qOTDAnswer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QOTDAnswerExists(int id)
        {
            return _context.QOTDAnswer.Any(e => e.ID == id);
        }
    }
}
