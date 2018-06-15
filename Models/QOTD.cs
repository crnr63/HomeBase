using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeBase.Models
{
    public class QOTD
    {
        public int ID { get; set; }
        [StringLength(500, MinimumLength = 3)]
        [Required]
        public string Question { get; set; }        
       
        public string QuestionAuthor{ get; set; }        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "QuestionDate")]
        [DataType(DataType.Date)]
        public DateTime QuestionDate { get; set; }
    
        [StringLength(500)]
        
        public string  Theme{ get; set; }
  

    }
}