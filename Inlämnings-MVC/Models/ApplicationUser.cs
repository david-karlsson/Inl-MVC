using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace Inlämnings_MVC.Models
{
    public class ApplicationUser:IdentityUser
    {


        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

    }
}
