using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiAndODataIssue
{
    public sealed class User
    {
        [Key]
        public Guid UserId { get; set; }

        public string Email { get; set; } = null!;

        public string? Name { get; set; }
    }
}
