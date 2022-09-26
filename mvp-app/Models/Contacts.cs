using System.ComponentModel.DataAnnotations;

namespace mvp_app.Models
{
    public class Contacts
    {
        [Display(Name ="Имя")]
        [Required(ErrorMessage ="Write Name")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Write SureName")]
        public string SureName { get; set; }

        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Write Age")]
        public int Age { get; set; }

        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Write Mail")]
        public string Email { get; set; }

        [Display(Name = "Сообщение")]
        [Required(ErrorMessage = "Write Message")]
        public string Message { get; set; }



    }
}
