namespace Information.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConnectionBot")]
    public partial class ConnectionBot
    {
        public int ID { get; set; }

        public int EmployeeID { get; set; }

        [Required]
        public string JsonConnect { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
