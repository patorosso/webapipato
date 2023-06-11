using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre debe estar.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "El campo libre de gluten debe estar.")]
        public required bool IsGlutenFree { get; set; }
    }
}
