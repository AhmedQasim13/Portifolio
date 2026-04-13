using System.ComponentModel.DataAnnotations;

namespace QasimPortifolio.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string MessageContent { get; set; }

        public DateTime SentAt { get; set; } = DateTime.Now;
    }
}

