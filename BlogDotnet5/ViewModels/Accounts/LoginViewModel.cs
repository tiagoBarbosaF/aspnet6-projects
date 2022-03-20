using System.ComponentModel.DataAnnotations;

namespace BlogDotnet5.ViewModels.Accounts
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
    
        [Required(ErrorMessage = "Informe uma senha")]
        public string Password { get; set; }
    }   
}