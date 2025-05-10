namespace PBL3.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Route")]
    public partial class Route
    {
        [Key]
        [StringLength(255)]
        public string ID_route { get; set; }

        [Required]
        [StringLength(255)]
        public string ID_Station_start { get; set; }

        [Required]
        [StringLength(255)]
        public string ID_Station_end { get; set; }

        public decimal distance { get; set; }

        public TimeSpan time { get; set; }

        public virtual Station Station { get; set; }

        public virtual Station Station1 { get; set; }
    }
}
