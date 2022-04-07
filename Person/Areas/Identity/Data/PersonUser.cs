using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Person.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the PersonUser class
    public class PersonUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(150)")]
        public string PermanentAddress { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(150)")]
        public string Education { get; set; }
    }
}
