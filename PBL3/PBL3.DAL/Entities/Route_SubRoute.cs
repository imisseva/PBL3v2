namespace PBL3.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using PBL3.DAL.Entities;

    public partial class Route_SubRoute
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string ID_route_parent { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string ID_route_child { get; set; }

        public int StopOrder { get; set; }

        public virtual Route Route { get; set; }

        public virtual Route Route1 { get; set; }
    }
}
