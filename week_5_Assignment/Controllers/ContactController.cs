using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using week_5_Assignment.Data;
using week_5_Assignment.Models.ViewModel;
using week_5_Assignment.Services.Interfaces;

namespace week_5_Assignment.Controllers
{
    public class ContactController : Controller
    {
        private readonly IEmailService _emailService;
        public ContactController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpGet]
        public IActionResult ContactPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ContactPage(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //  ModelState.Clear();

                await _emailService.SendEmail("Contact Email", model.Subject, model.SenderEmail, model.Message);
                ViewData["SuccessMessage"] = "Your message has been sent successfully!";

                return RedirectToAction("Index", "Home");

            }

            return View(model);
        }

    }
}
