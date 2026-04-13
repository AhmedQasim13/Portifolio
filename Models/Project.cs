namespace QasimPortifolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; } // stored path

        public string GitHubUrl { get; set; }
        public string LiveDemoUrl { get; set; }

        public DateTime CreatedAt { get; set; }

        // 🔗 RELATIONSHIP
        // 🔗 FK → Identity User (string)
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        // 🔗 Many-to-Many
        public ICollection<ProjectTechnology>? ProjectTechnologies { get; set; }

    }
}
