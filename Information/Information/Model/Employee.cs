namespace Information.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            ConnectionBot = new HashSet<ConnectionBot>();
            ListInterviewees = new HashSet<ListInterviewees>();
            RequestConnect = new HashSet<RequestConnect>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        public int PostID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        public byte[] Photo { get; set; }

        [Required]
        [StringLength(50)]
        public string Telephon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectionBot> ConnectionBot { get; set; }

        public virtual Post Post { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListInterviewees> ListInterviewees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestConnect> RequestConnect { get; set; }
    }
}
