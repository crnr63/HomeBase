using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeBase.Models
{
    public class ParticipantQOTD
    {
        public int ID { get; set; }
        [StringLength(300, MinimumLength = 3)]
        [Required]
        public string GivenName { get; set; }        
       
        public string FamilyName{ get; set; }        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "QuestionDate")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        [Required]
        [StringLength(500)]
        public string Creator { get; set; }
  

    }
}