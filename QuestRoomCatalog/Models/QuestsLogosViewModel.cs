namespace QuestRoomCatalog
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class QuestsLogosViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Квест комната")]
        public int QuestRoomId { get; set; }

        //[Required]
        [Display(Name = "Изображение")]
        public byte[] Image { get; set; }

        public bool IsLogo { get; set; }

        public QuestsRoomsViewModel QuestsRooms { get; set; }
    }
}
