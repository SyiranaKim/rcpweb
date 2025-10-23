using System.ComponentModel.DataAnnotations;

namespace RPCMWEB.Models
{
    public class StaffNews
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string StaffName { get; set; }

        [Required]
        [StringLength(100)]
        public required string Position { get; set; }

        [Required]
        public required string Department { get; set; }

        public DateTime JoinDate { get; set; }

        public string? Bio { get; set; }

        public required string ProfilePicturePath { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}