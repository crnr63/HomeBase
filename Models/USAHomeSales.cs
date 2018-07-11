using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HomeBase.Models
{

    public class USAHomeSales
    { 

             public int ID{get; set;}

        public string parsedhomeID {get; set;}
           public string snapshottype{ get; set; }

        public string listingprice {get; set;}
        public decimal finalsalesprice {get; set;}
       public string notes {get; set;}     
       public DateTime snapshotdate { get; set; }
    public DateTime insertionDate { get; set; }
    }

}