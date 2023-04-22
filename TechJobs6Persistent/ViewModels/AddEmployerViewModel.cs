

using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required( ErrorMessage ="Lazy bum, is typing a name so difficult?")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="location is required!")]
        public string? Location { get; set; }
    }
   
}
