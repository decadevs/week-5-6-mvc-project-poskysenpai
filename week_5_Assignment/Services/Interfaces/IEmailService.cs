namespace week_5_Assignment.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendEmail(string subject, string senderName, string senderEmail, string body);
    }
}
