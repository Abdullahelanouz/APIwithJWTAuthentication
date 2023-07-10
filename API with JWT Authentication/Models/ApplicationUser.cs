﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace API_with_JWT_Authentication.Models
{
    public class ApplicationUser :IdentityUser
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public int LastName { get; set; }
    }
}