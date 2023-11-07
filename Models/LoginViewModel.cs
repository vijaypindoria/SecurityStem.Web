using SecurityStem.Web.Services;
using System.ComponentModel.DataAnnotations;

namespace SecurityStem.Web.Models
{
    public class LoginViewModel:ILoginViewModel
    {
        public int Challenge { get; set; } = 0;
        [Required(ErrorMessage ="A Value for Login is required")]
        public string LogIn { get; set; }

        [Required(ErrorMessage ="A value for Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

     



    }
}
