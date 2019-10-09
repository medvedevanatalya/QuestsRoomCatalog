using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestRoomCatalog.Models
{
    public class RolesViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле Роль обязательно к заполнению")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть не меньше 3-х и не должна превышать 50 символов")]
        [Display(Name = "Роль")]
        public string RoleName { get; set; }
    }
}