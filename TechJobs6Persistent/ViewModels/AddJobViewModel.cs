
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel    
    {
        public int? EmployerId { get; set; }

        [Required(ErrorMessage = "Job name is required")]
        [StringLength(50, ErrorMessage = "name too long,must be between1-50 characters!")]

        public string Name { get; set; }
        public List<SelectListItem>? employers { get; set; }

        public AddJobViewModel(List<Employer> theEmployers)
        {
            employers = new List<SelectListItem>();

            foreach (var employer in theEmployers)
            {
                employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }
        public AddJobViewModel() 
        { 
        }    

    }
}
