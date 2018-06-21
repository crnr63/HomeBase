using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace HomeBase.Models
{//model for the edit page needed to populate a select
    public class adminUserEditViewModel
    {
    public string Username { get; set; }
    public List<SelectListItem> Roles {get; set;}
    //change to string array asap
    public string Email {get; set;}
    public string ID { get; set; }
    

    }
}