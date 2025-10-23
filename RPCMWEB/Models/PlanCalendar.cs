using System.ComponentModel.DataAnnotations;

namespace RPCMWEB.Models
{
    public class PlanCalendar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public required string EventTitle { get; set; }

        public string? EventDescription { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public required string CreatedBy { get; set; }

        public bool IsPublic { get; set; } = true;

        public required string EventType { get; set; } // "Company", "Personal"
    }
}