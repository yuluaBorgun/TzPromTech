namespace Information.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ListInterviewees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ListInterviewees()
        {
            Answer = new HashSet<Answer>();
        }

        public int ID { get; set; }

        public int LaunchingQuestionnaireID { get; set; }

        public int EmployeeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual LaunchingQuestionnaire LaunchingQuestionnaire { get; set; }
    }
}
