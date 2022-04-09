using System.ComponentModel.DataAnnotations;

namespace JsonBasedLocalization.Api.Dtos
{
    public class CreateTestDto
    {
        [Required(ErrorMessage = "required")]
        public string Name { get; set; }
    }
}