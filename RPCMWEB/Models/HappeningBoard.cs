using System.ComponentModel.DataAnnotations;

namespace RPCMWEB.Models
{
    public class HappeningBoard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime EventDate { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string CreatedBy { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}