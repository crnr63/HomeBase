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
              List<QOTD> Questions = await _QOTDcontext.QOTD.ToListAsync();
              List<QOTDAnswer> Answers = await _QOTDcontext.QOTDAnswer.ToListAsync();
              
              Dictionary<int,List<QOTDAnswer>> AnswersDictionary= new Dictionary<int, List<QOTDAnswer>>();

              foreach(QOTDAnswer answer in Answers){
                    if (AnswersDictionary.ContainsKey(answer.QuestionID))
                    {
                       AnswersDictionary[answer.QuestionID].Add(answer);
                       AnswersDictionary[answer.QuestionID].ForEach(i => Console.Write("{0}\t", i.Answer));
                    }
                    else
                    {
                        AnswersDictionary[answer.QuestionID] = new List<QOTDAnswer> { answer };
                    }

                
              }
              ICollection<DZQOTDModelView> rigormortis = new  List <DZQOTDModelView>();
            foreach(QOTD Question in Questions){
  if (AnswersDictionary.ContainsKey(Question.ID))
                    {
                rigormortis.Add( new  DZQOTDModelView{ QOTD=Question, QOTDAnswers= AnswersDictionary[Question.ID]});
                    }
                    else
                    {
                rigormortis.Add( new  DZQOTDModelView{ QOTD=Question, QOTDAnswers=new List<QOTDAnswer>() });
                    }
                       
              

            }
            ViewData["Message"] = "Your contsct page.";

            return View(rigormortis);

        }  

  
     public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}