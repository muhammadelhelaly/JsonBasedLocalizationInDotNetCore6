using System.ComponentModel.DataAnnotations;

namespace JsonBasedLocalization.Web.ViewModels
{
    public class CreateTestViewModel
    {
        [Display(Name = "name"), Required(ErrorMessage = "required")]
        public string Name { get; set; }
    }
}