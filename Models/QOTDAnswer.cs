using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HomeBase.Models
{
    public class QOTDAnswer
    {
        public int ID { get; set; }
        [StringLength(500, MinimumLength = 3)]
        [Required]
        public string Question { get; set; }        
        public int QuestionID { get; set; }        

        public string Author { get; set; }  
        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "QuestionDate")]
        [DataType(DataType.Date)]
        public DateTime QuestionDate { get; set; }
    

 
        public string Answer{ get; set; }
  

    }
}