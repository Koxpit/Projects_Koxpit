using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarsStore.ViewModels
{
    public class RegisterModel
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        [MinLength(5)]
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [MinLength(5)]
        [Required(ErrorMessage = "Не указана фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Почта")]
        [MinLength(10)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [Display(Name = "Логин")]
        [MinLength(5)]
        [Required(ErrorMessage = "Не указан логин")]
        public string Login { get; set; }

        [Display(Name = "Пароль")]
        [MinLength(4)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }
    }
}
