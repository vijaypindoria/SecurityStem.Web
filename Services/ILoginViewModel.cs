using System.ComponentModel.DataAnnotations;

namespace SecurityStem.Web.Services
{
    public class ILoginViewModel
    {

        public string LogIn { get; set; }

       
        public string Password { get; set; }
        public int Challenge { get; set; } = 0;
      
    }
}
