using System.ComponentModel.DataAnnotations;
namespace QasimPortifolio.Models
{
    public class Experience
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        [Required, MaxLength(150)]
        public string Company { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        public bool IsCurrent { get; set; } = false;
    }
}

