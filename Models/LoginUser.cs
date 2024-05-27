using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Email required")]
        [EmailAddress(ErrorMessage = "Enter a valid Email")]
        public string EmailLogin { get; set; }

		[Required(ErrorMessage = "Password required")]
		public string PasswordLogin { get; set; }

        //public LoginUser(string emailLogin, string passwordLogin)
        //{
        //    EmailLogin = emailLogin;
        //    PasswordLogin = passwordLogin;
        //}
    }
}
