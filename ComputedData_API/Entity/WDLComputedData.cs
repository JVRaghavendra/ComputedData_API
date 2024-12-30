using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComputedData_API.Entity
{
    [Table("SEA_WDLComputedData")]
    public class WDLComputedData
    {
        [Key]
        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string SkillID { get; set; }

        [Required]
        public DateTimeOffset StartDate { get; set; }

        [Required]
        public DateTimeOffset EndDate { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal UsagePercentage { get; set; }

        [Required]
        [StringLength(100)]
        public string SourceSystem { get; set; }

        [Required]
        [StringLength(100)]
        public string CourseID { get; set; }

        [Required]
        [StringLength(200)]
        public string CourseName { get; set; }

        [Required]
        public DateTimeOffset CreatedDateTime { get; set; }

        [Required]
        public DateTimeOffset? ProcessedDateTime { get; set; } 

        [Required]
        public bool IsProcessed { get; set; }
    }
}
