using System.ComponentModel.DataAnnotations;

namespace QasimPortifolio.Models
{
    public class About
    {
        public int Id { get; set; }

        [Required]
        public string Bio { get; set; }

        [Url]
        public string? CVUrl { get; set; }

        [Url]
        public string? LinkedInUrl { get; set; }

        [Url]
        public string? GitHubUrl { get; set; }
    }
}
