using System.Collections.Generic;
using HomeBase.Models;

namespace HomeBase.Models
{
public class DZQOTDModelViewbyParticipant
{
    public ParticipantQOTD ParticipantQOTD { get; set; }
    public IEnumerable<QOTDAnswer> QOTDpAnswers { get; set; }
}
}