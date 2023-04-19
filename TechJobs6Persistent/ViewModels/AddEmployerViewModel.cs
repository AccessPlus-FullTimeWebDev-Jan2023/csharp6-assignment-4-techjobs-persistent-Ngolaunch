

using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required( ErrorMessage ="Lazy bum, is typing a name so difficult?")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="must contain a location!")]
        public string? Location { get; set; }
    }
}
