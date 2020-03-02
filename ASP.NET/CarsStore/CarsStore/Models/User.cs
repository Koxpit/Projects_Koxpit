using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarsStore.Models
{
    public class User
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        [MinLength(5)]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [MinLength(5)]
        public string Surname { get; set; }

        [Display(Name = "Почта")]
        [MinLength(10)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Логин")]
        [MinLength(5)]
        public string Login { get; set; }

        [Display(Name = "Пароль")]
        [MinLength(4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
