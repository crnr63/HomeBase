using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace HomeBase.Models
{
    public class QOTDAnswerViewModel
    {
        public int ID { get; set; }
        [StringLength(500, MinimumLength = 3)]
        [Required]
        public string Question { get; set; }        
        public List<SelectListItem> Authors;
        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "QuestionDate")]
        [DataType(DataType.Date)]
        public DateTime QuestionDate { get; set; }
        public int QuestionID { get; set; }


 
        public string Answer{ get; set; }
  

    }
}