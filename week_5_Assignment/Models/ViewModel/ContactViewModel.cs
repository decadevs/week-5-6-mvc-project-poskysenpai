using System.ComponentModel.DataAnnotations;

namespace week_5_Assignment.Models.ViewModel
{
    public class ContactViewModel
    {
        [Required]

        public string SenderEmail { get; set; }

        [Required]
        
        public string Subject{ get; set; }

        [Required]
        
        public string Message { get; set; }    
    }
}
