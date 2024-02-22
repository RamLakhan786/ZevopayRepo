﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zevopay.Data.Entity
{
    public class ApplicationUser :IdentityUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? MemberId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
