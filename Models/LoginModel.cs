using System.ComponentModel.DataAnnotations;

namespace TechPays.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login")]
        [Key]
        public string login { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string senha { get; set; }
    
       
    }
}
