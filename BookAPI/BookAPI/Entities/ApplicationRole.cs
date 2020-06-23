﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Entities
{
    public class ApplicationRole : IdentityRole
    {
        [Required]
        public string RoleName { get; set; }

    }
}
