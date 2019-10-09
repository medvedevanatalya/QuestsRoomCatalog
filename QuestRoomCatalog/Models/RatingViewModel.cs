using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestRoomCatalog.Models
{
    public class RatingViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Квест комната")]
        public int QuestRoomId { get; set; }

        [Range(1, 100, ErrorMessage = "Недопустимое значение Рейтинга")]
        [Display(Name = "Рейтинг")]
        public int RatingLevel { get; set; }

        public virtual QuestsRoomsViewModel QuestsRooms { get; set; }
    }
}