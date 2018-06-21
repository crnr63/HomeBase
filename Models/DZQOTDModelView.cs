using System.Collections.Generic;
using HomeBase.Models;

namespace HomeBase.Models
{
    //the other QOTD models were auto generated through scaffolding, this is the model for the 
    // QOTD Recap page in the DeputyZone controller
    public class DZQOTDModelView
{
    public QOTD QOTD { get; set; }
    public IEnumerable<QOTDAnswerViewModel> QOTDAnswers { get; set; }
}
}