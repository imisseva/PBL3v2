namespace PBL3.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Schedule")]
    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            Schedule_Stop = new HashSet<Schedule_Stop>();
            Tickets = new HashSet<Ticket>();
        }

        [Key]
        [StringLength(50)]
        public string ID_Schedule { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_bus { get; set; }

        public DateTime start_time { get; set; }

        public DateTime end_time { get; set; }

        public decimal distance { get; set; }

        public virtual Bus Bus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule_Stop> Schedule_Stop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
