using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace HomeBase.Models
{
    public class adminViewModel
    {
    public string Username { get; set; }
    public string Email { get; set; }
    //change to string array asap
    public string RolesList { get; set; }

    public string ID { get; set; }


    }
}