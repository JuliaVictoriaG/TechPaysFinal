using System.ComponentModel.DataAnnotations;

namespace TechPays.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Digite o login")]
        [Key]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o e-mail")]
        public string Email { get; set; }
    }
}
