using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AuthSystemDotnet.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "NavChar(100)")]
    public string FirstName {get; set;}

    [PersonalData]
    [Column(TypeName = "NavChar(100)")]
    public string LastName { get; set; }
}

