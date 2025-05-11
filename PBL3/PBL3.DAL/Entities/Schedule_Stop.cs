namespace PBL3.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Schedule_Stop
    {
        [Key]
        public int ID_Stop { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_Schedule { get; set; }

        [Required]
        [StringLength(255)]
        public string IDStation_stop { get; set; }

        public TimeSpan Stop_time { get; set; }

        public int Stop_order { get; set; }

        public virtual Schedule Schedule { get; set; }

        public virtual Station Station { get; set; }
    }
}
