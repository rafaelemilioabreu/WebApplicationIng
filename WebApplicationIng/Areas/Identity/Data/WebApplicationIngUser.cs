using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplicationIng.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WebApplicationIngUser class
    public class WebApplicationIngUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string cedula { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]

        public string nombre { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]

        public string apellido { get; set; }
    }
}
