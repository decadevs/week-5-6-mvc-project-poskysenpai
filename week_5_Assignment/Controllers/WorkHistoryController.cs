using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using week_5_Assignment.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using week_5_Assignment.Data;
using week_5_Assignment.Models.Entities;

namespace week_5_Assignment.Controllers
{
    public class WorkHistoryController : Controller
    {
        private readonly MyDbContext _ctx;
        public WorkHistoryController(MyDbContext context)
        {
            _ctx= context;
        }

        [HttpGet]
        public IActionResult Index(string? id)
        { 
            List<WorkPortriat> workPortriats = new List<WorkPortriat>();    
            var jobs = _ctx.Jobs;

            if(jobs != null && jobs.Any())
            {
                workPortriats = jobs.Select(x => new WorkPortriat
                { 
                 Id = x.Id, 
                 Company = x.Company,
                 JobTitle = x.JobTitle,
                 JobDescription = x.JobDescription,
                 StartDate = x.StartDate,
                 EndDate = x.EndDate,
                }).ToList();
            }
           

            var viewModel = new WorkHistoryViewModel
            {
                WorkPortriats = workPortriats.OrderByDescending(x => x.Id).ToList(),    
            };
            return View(viewModel);
        }
        [HttpGet]
        public IActionResult ViewDetail(string id)
        {
            WorkPortriat workPortriats = new WorkPortriat();
            var jobs = _ctx.Jobs;

            if (jobs == null)
            {
                ViewBag.ErrMsg = $"The job with id: {id} was not found";
                return View();
            }
                var job = jobs.FirstOrDefault(x => x.Id == id);
                workPortriats = new WorkPortriat
                {
                    Id = job.Id,
                    Company = job.Company,
                    JobTitle = job.JobTitle,
                    JobDescription = job.JobDescription,
                    StartDate = job.StartDate,
                    EndDate = job.EndDate,
                };
            return View(workPortriats);
            }
               

            


           
        [HttpGet]
        public IActionResult AddNew() 
        {
            return View();
         }

        [HttpPost]
        public IActionResult AddNew(AddJobViewModel model)
        {
            if (ModelState.IsValid)
            {
                Job newWork = new Job
                {
                    Id = Guid.NewGuid().ToString(),
                    Company = model.Company,
                    JobTitle = model.JobTitle,
                    JobDescription = model.JobDescription,
                    EndDate = model.EndDate,
                    StartDate = model.StartDate,
                };

                _ctx.Add(newWork);
                _ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
           

        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            var jobs = _ctx.Jobs;
            if (jobs != null && jobs.Any(x => x.Id == id))
            {
                var job = jobs.FirstOrDefault(x => x.Id == id);
                _ctx.Remove(job);
                _ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var jobs = _ctx.Jobs;
            var job = jobs.First(x => x.Id == id);
            EditJobViewModel model = new EditJobViewModel
            {
                Company =         job.Company,
                JobTitle = job.JobTitle,
                JobDescription = job.JobDescription,
                EndDate = job.EndDate,
                StartDate = job.StartDate
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(string id, EditJobViewModel model)
        {
            if(ModelState.IsValid)
            {
                var jobs = _ctx.Jobs;
                if (jobs != null && jobs.Any(x => x.Id == id))
                {
                  var job = jobs.First(x=>x.Id == id);

                    job.Company = model.Company;
                    job.JobTitle = model.JobTitle;
                    job.JobDescription = model.JobDescription;
                    job.EndDate = model.EndDate;    
                    job.StartDate = model.StartDate;


                    _ctx.Update(job);
                    _ctx.SaveChanges();

                    return RedirectToAction("index");
                }
                ModelState.AddModelError("Id mismatch!", $"Dog with id:{id}");
            }
            return View(model);
        }
    
    }
}
