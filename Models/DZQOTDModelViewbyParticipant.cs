using System.Collections.Generic;
using HomeBase.Models;

namespace HomeBase.Models
{   
    //the other QOTD models were auto generated through scaffolding, this is the model for the 
    // QOTD Recap page in the DeputyZone controller, specifically the partial rending in a bootstrp tab for 
    //the questions organized by respondant and not by question.
public class DZQOTDModelViewbyParticipant
{
    public ParticipantQOTD ParticipantQOTD { get; set; }
    public IEnumerable<QOTDAnswer> QOTDpAnswers { get; set; }
}
}