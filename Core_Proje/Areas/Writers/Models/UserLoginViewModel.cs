using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writers.Models
{
    public class UserLoginViewModel
    {
        [Display(Name="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı adını giriniz...!")]
        public string Username { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifrenizi giriniz...!")]
        public string Password { get; set; }
    }
}
