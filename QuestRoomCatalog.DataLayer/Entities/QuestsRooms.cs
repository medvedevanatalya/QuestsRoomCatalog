namespace QuestRoomCatalog.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QuestsRooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestsRooms()
        {
            QuestsLogos = new HashSet<QuestsLogos>();
            Rating = new HashSet<Rating>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string NameQuestsRooms { get; set; }

        [Required]
        public string DecriptionQuestsRooms { get; set; }

        public int TimeForQuest { get; set; }

        public int MaxGamer { get; set; }

        public int MinGamer { get; set; }

        public int FearsLevel { get; set; }

        public int ComplexitysLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestsLogos> QuestsLogos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Rating { get; set; }
    }
}
