using System.ComponentModel.DataAnnotations;

namespace week_5_Assignment.Models.Entities
{
    public class Job
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Company { get; set; } = "";

        [Required]

        public string JobTitle { get; set; } = "";

        [Required]

        public string JobDescription { get; set; } = " ";

        [Required]

        public DateOnly StartDate { get; set; }

        [Required]

        public DateOnly EndDate { get; set; }
    }
}
