using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TechJobs6Persistent.Data;
using TechJobs6Persistent.Models;
using TechJobs6Persistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs6Persistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;
        public EmployerController (JobDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            List<Employer> employer = context.Employers.ToList();
            return View(employer);
        }
        [HttpGet]
        public IActionResult Create()
        {
            AddEmployerViewModel addEmployerView = new AddEmployerViewModel();
            return View(addEmployerView);
        }

        [HttpPost]
        public IActionResult ProcessCreateEmployerForm(AddEmployerViewModel addEmployerView)
        {
            if(ModelState.IsValid)
            {
                Employer employer = new Employer
                {
                    Name = addEmployerView.Name,
                    Location = addEmployerView.Location
                };
                context.Employers.Add(employer);
                context.SaveChanges();
                return Redirect("/Employer");
            }
            return View(addEmployerView);
        }

        public IActionResult About(int id)

        {
            Employer employer= context.Employers.Find(id);
            return View(employer);
           
        }

    }
}

