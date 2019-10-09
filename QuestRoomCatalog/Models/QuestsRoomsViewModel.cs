using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestRoomCatalog.Models
{
    public class QuestsRoomsViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле Название комнаты обязательно к заполнению")]
        [StringLength(250)]
        [Display(Name = "Название комнаты")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле Описание комнаты обязательно к заполнению")]
        [StringLength(500)]
        [Display(Name = "Описание комнаты")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле Время прохождения обязательно к заполнению")]
        [Range(30, 90, ErrorMessage = "Недопустимое Время прохождения")]
        [Display(Name = "Время прохождения, мин.")]
        public int TimeForQuest { get; set; }

        [Required(ErrorMessage = "Поле Максимальное кол-во игроков обязательно к заполнению")]
        [Range(4, 10, ErrorMessage = "Недопустимое максимальное кол-во игроков")]
        [Display(Name = "Максимальное кол-во игроков")]
        public int MaxGamer { get; set; }

        [Required(ErrorMessage = "Поле Минимальное кол-во игроков обязательно к заполнению")]
        [Range(4, 10, ErrorMessage = "Недопустимое минимальное кол-во игроков")]
        [Display(Name = "Минимальное кол-во игроков")]
        public int MinGamer { get; set; }

        [Required(ErrorMessage = "Поле Минимальный возраст игроков обязательно к заполнению")]
        [Range(14, 100, ErrorMessage = "Недопустимый минимальный возраст")]
        [Display(Name = "Минимальный возраст игроков")]
        public int MinAgeGamer { get; set; }

        [Required(ErrorMessage = "Поле Уровень страха обязательно к заполнению")]
        [Range(1, 5, ErrorMessage = "Недопустимый уровень страха")]
        [Display(Name = "Уровень страха")]
        public int FearLevel { get; set; }

        [Required(ErrorMessage = "Поле Уровень сложности обязательно к заполнению")]
        [Range(1, 5, ErrorMessage = "Недопустимый уровень сложности")]
        [Display(Name = "Уровень сложности")]
        public int ComplexityLevel { get; set; }
    }
}