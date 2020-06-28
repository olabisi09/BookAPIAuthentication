using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Entities
{
    public class ApplicationRole : IdentityRole
    {
        
        public string RoleName { get; set; }
        
    }
}
