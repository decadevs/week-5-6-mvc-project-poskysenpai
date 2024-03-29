namespace week_5_Assignment.Models.ViewModel
{
    public class WorkPortriat
    {
       
        public string? Id{ get; set; }
        public string? Company { get; set; }

        public string? JobTitle { get; set; }

        public string? JobDescription { get; set;}

        public   DateOnly StartDate {  get; set; }

        public DateOnly EndDate { get; set; }

    }
}
