using System.ComponentModel.DataAnnotations;

namespace ComputedData_API.Model
{
    public class WDLComputedDataModel
    {
        public long ID { get; set; }      
        public string EmployeeID { get; set; }
        public string SkillID { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public decimal UsagePercentage { get; set; }
        public string SourceSystem { get; set; }
        public string CourseID { get; set; }
        public string CourseName { get; set; }
    }
}
