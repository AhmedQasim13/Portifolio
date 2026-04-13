using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace QasimPortifolio.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(150)]
        public string? FullName { get; set; }

        public string? ProfileImageUrl { get; set; }

        // Navigation
        public ICollection<Project>? Projects { get; set; }
    }
}
