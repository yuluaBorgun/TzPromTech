namespace Information.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Answer")]
    public partial class Answer
    {
        public int ID { get; set; }

        public int ListIntervieweesID { get; set; }

        public int LaunchingQuestionnaireID { get; set; }

        public int QuestionsID { get; set; }

        [Column("Answer")]
        [Required]
        public string Answer1 { get; set; }

        public DateTime DateTimeAnswer { get; set; }

        public virtual LaunchingQuestionnaire LaunchingQuestionnaire { get; set; }

        public virtual ListInterviewees ListInterviewees { get; set; }

        public virtual Questions Questions { get; set; }
    }
}
