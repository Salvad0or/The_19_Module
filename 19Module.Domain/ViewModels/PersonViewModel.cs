using System.ComponentModel.DataAnnotations;


namespace _19Module.Domain.ViewModels
{
    public class PersonViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Некорректное имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана фамилия")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Некорректная фамилия")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Не указано отчество")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Некорректное отчество")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Не указан телефон")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Некорректный телефон")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Не указан адрес")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Некорректо указан адрес")]
        public string Adress { get; set; }
    }
}
