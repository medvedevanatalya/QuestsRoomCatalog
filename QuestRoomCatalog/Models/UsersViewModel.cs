using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestRoomCatalog.Models
{
    public class UsersViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле Имя пользователя обязательно к заполнению")]
        [StringLength(250)]
        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; }

        [Display(Name = "Роль")]
        public int RoleId { get; set; }

        public virtual RolesViewModel Roles { get; set; }
    }
}