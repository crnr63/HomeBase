using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace HomeBase.Controllers
{
    [Authorize(Roles = "Député,Admin,potentialEmployers")]
    public class DeputyZoneController : Controller
    {        
        private readonly QOTDContext _QOTDcontext;

        public DeputyZoneController(
            QOTDContext QOTDcontext){
            _QOTDcontext = QOTDcontext;

            }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> QOTD()
        {// need each question QOTD TABLE and then organize all the  responses QOTDAnswer Table  Ato that question
            List<QOTD> Questions = await _QOTDcontext.QOTD.ToListAsync();
            List<QOTDAnswer> Answers = await _QOTDcontext.QOTDAnswer.ToListAsync();
            List<ParticipantQOTD> Participants = await _QOTDcontext.ParticipantQOTD.OrderBy(x => x.GivenName).ToListAsync();
            
            //answers and participants organized by ID of Answer Author
            Dictionary<int,List<QOTDAnswerViewModel>> AnswersDictionary= new Dictionary<int, List<QOTDAnswerViewModel>>();
            Dictionary<int,ParticipantQOTD> ParticDictionary= new Dictionary<int, ParticipantQOTD>();
              //all participants by ID
            foreach(ParticipantQOTD partic in Participants){
                if ( ParticDictionary.ContainsKey(partic.ID))
                    {
                        
                        ParticDictionary[partic.ID]=partic;
                        
                    }
                else
                    {
                        
                        ParticDictionary[partic.ID]= partic;
                        
                    }

                
            }
              //all answers by author ID
            foreach(QOTDAnswer answer in Answers){

                int g;
                // add behavior if tryparse ==false 
                Int32.TryParse(answer.Author,out g);
                string fullName=ParticDictionary[g].GivenName + " "+ ParticDictionary[g].FamilyName;
                 
                QOTDAnswerViewModel newModel=new QOTDAnswerViewModel
                        {
                            Author= fullName, 
                            Question= answer.Question,
                            QuestionDate=answer.QuestionDate,
                            QuestionID=answer.QuestionID,
                            ID=answer.ID,
                            Answer=answer.Answer
                            };
                                      
                if (AnswersDictionary.ContainsKey(answer.QuestionID))
                    { 
                       AnswersDictionary[answer.QuestionID].Add(newModel);
                    }
                else
                    {
                        AnswersDictionary[answer.QuestionID] = new List<QOTDAnswerViewModel> {newModel };
                    }

                
            }
              
            ICollection<DZQOTDModelView> rigormortis = new  List <DZQOTDModelView>();
            //add empty if question entries have not been entered yet.
            foreach(QOTD Question in Questions){
                if (AnswersDictionary.ContainsKey(Question.ID))
                    {
                        rigormortis.Add( new  DZQOTDModelView{ QOTD=Question, QOTDAnswers= AnswersDictionary[Question.ID]});
                    }
                else
                    {
                        rigormortis.Add( new  DZQOTDModelView{ QOTD=Question, QOTDAnswers=new List<QOTDAnswerViewModel>() });
                    }
                       
              

            }
            Dictionary<int,List<QOTDAnswer>> AnswersDictionary2= new Dictionary<int, List<QOTDAnswer>>();

            foreach(QOTDAnswer answerr in Answers){
                // same field is a string in one field and int in another 
                // FIX!! 
                int g;
                Int32.TryParse(answerr.Author,out g);
                   
                if (AnswersDictionary2.ContainsKey(g))
                    {
                        AnswersDictionary2[g].Add(answerr);
                        AnswersDictionary2[g].ForEach(i => Console.Write("{0}\t", i.Answer));
                    }
                else
                    {
                        AnswersDictionary2[g] = new List<QOTDAnswer> { answerr };
                    }
            }
            ICollection<DZQOTDModelViewbyParticipant> rigormortis2 = new  List <DZQOTDModelViewbyParticipant>();
            
            foreach(ParticipantQOTD participant in Participants){
                if (AnswersDictionary2.ContainsKey(participant.ID))
                    {
                         rigormortis2.Add( new  DZQOTDModelViewbyParticipant{ ParticipantQOTD=participant, QOTDpAnswers= AnswersDictionary2[participant.ID]});
                    }
                else
                    {
                         rigormortis2.Add( new  DZQOTDModelViewbyParticipant{ ParticipantQOTD=participant, QOTDpAnswers=new List<QOTDAnswer>() });
                    }
                       
              

            }
            //return data for the partially rendered view 
            ViewData["subheader"] = rigormortis2;

            return View(rigormortis);

        }  
        public IActionResult OurBNB()
        {
            return View();
        }  
        public IActionResult RePrices()
        {
            return View();
        }   
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}