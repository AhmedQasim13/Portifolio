using System.ComponentModel.DataAnnotations;

namespace QasimPortifolio.Models
{
    public class Skill
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Range(0, 100)]
        public int Level { get; set; } // percentage (e.g. 80%)

        public string? Icon { get; set; } // optional (fontawesome or image)
    }
}
