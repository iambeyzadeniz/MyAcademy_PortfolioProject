using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage ="Kullanýcý adý  boþ geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Þifre boþ geçilemez")]

        public string Password { get; set; }
    }
}
