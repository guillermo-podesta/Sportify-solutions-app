using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Sportify_Back.Models
{
    public class ApplicationUser : IdentityUser
    {
    public string Name { get; set; }
    public string LastName { get; set; }
    public string DNI { get; set; }
    public string? DocumentName { get; set; }
    public byte[]? DocumentContent { get; set; }

    
    }
}