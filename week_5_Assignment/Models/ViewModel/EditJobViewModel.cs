using System.ComponentModel.DataAnnotations;

namespace week_5_Assignment.Models.ViewModel
{
    public class EditJobViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "MaxLen is 20 , MinLen is 3")]
        public string? Company { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "MaxLen is 10 , MinLen is 3")]

        public string? JobTitle { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "MaxLen is 200  , MinLen is 20")         ]

        public string? JobDescription { get; set; }

        public DateOnly StartDate { get;  set; }

        public DateOnly EndDate { get; set; }
    }
}
