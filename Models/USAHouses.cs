using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HomeBase.Models
{

    public class USAHouses
    { public string ID{get; set;}
    
        public string address {get; set;}
        public decimal cost{get; set;}
        public decimal bathrooms{get; set;}
        public int squarefootage{get; set;}
       public decimal bedrooms{get; set;}
       public string emailID{get; set;} 
       public string  zipcode {get; set;}
    public DateTime insertionDate { get; set; }
        public string type { get; set; }

       public string  state {get; set;}
       public string city { get; set; }
    }

}