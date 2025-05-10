namespace PBL3.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        [Key]
        public int ID_ticket { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_Schedule { get; set; }

        [Required]
        [StringLength(255)]
        public string ID_seat { get; set; }

        public int price { get; set; }

        public DateTime booking_date { get; set; }

        [Required]
        [StringLength(255)]
        public string ID_Station_start { get; set; }

        [Required]
        [StringLength(255)]
        public string ID_Station_end { get; set; }

        public virtual Schedule Schedule { get; set; }

        public virtual SEAT SEAT { get; set; }

        public virtual Station Station { get; set; }

        public virtual Station Station1 { get; set; }
    }
}
