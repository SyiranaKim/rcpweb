using System.ComponentModel.DataAnnotations;

namespace RPCMWEB.Models
{
    public class HSSEStatistic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string FilePath { get; set; } = string.Empty;

        public DateTime UploadDate { get; set; } = DateTime.Now;

        public string UploadedBy { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}