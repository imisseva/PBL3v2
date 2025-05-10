namespace PBL3.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEAT")]
    public partial class SEAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEAT()
        {
            Tickets = new HashSet<Ticket>();
        }

        [Key]
        [StringLength(255)]
        public string ID_seat { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_bus { get; set; }

        public int seat_number { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }

        public virtual Bus Bus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
