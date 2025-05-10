namespace PBL3.DAL.Entities
{   
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bus_Location_History
    {
        [Key]
        public int ID_History { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_bus { get; set; }

        [Required]
        [StringLength(255)]
        public string ID_Station { get; set; }

        public DateTime? arrive_time { get; set; }

        public DateTime? leave_time { get; set; }

        public virtual Bus Bus { get; set; }

        public virtual Station Station { get; set; }
    }
}
