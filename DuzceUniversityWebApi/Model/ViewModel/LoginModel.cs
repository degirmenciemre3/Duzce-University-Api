using System.ComponentModel.DataAnnotations;

namespace DuzceUniversityWebApi.Model.ViewModel
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}
