using System.Collections.Generic;
using HomeBase.Models;

namespace HomeBase.Models
{
public class DZQOTDModelView
{
    public QOTD QOTD { get; set; }
    public IEnumerable<QOTDAnswerViewModel> QOTDAnswers { get; set; }
}
}