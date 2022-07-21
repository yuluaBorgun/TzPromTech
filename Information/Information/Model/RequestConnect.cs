namespace Information.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestConnect")]
    public partial class RequestConnect
    {
        public int ID { get; set; }

        public int EmployeeID { get; set; }

        [Required]
        [StringLength(10)]
        public string Key { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDisconnections { get; set; }

        public bool Active { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
