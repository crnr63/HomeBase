using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class ApplicationUserListViewModel
{
    [Display(Name = "User Email Address")]
    public string UserEmail { get; set; }

    public  List<IdentityUserRole<string>> Roles { get; set; }
}