namespace Information.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LaunchingQuestionnaire")]
    public partial class LaunchingQuestionnaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LaunchingQuestionnaire()
        {
            Answer = new HashSet<Answer>();
            ListInterviewees = new HashSet<ListInterviewees>();
        }

        public int ID { get; set; }

        public int SurveyID { get; set; }

        public DateTime DateTimeLaunch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answer { get; set; }

        public virtual Survey Survey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListInterviewees> ListInterviewees { get; set; }
    }
}
