namespace PBL3.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using PBL3.DAL.Entities;

    [Table("Staff")]
    public partial class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_account { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(255)]
        public string ID_station { get; set; }

        [StringLength(12)]
        public string CCCD { get; set; }

        [StringLength(255)]
        public string home_address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(255)]
        public string NoiSinh { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }

        public virtual Account Account { get; set; }

        public virtual Station Station { get; set; }
    }
}
