using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Information.Model
{
    public partial class InformationModel : DbContext
    {
        public InformationModel()
            : base("name=DataConnect")
        {
        }

        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<ConnectionBot> ConnectionBot { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<LaunchingQuestionnaire> LaunchingQuestionnaire { get; set; }
        public virtual DbSet<ListInterviewees> ListInterviewees { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<RequestConnect> RequestConnect { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Department1)
                .WithOptional(e => e.Department2)
                .HasForeignKey(e => e.ParentDepartment);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Post)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ConnectionBot)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ListInterviewees)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.RequestConnect)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaunchingQuestionnaire>()
                .HasMany(e => e.Answer)
                .WithRequired(e => e.LaunchingQuestionnaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaunchingQuestionnaire>()
                .HasMany(e => e.ListInterviewees)
                .WithRequired(e => e.LaunchingQuestionnaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ListInterviewees>()
                .HasMany(e => e.Answer)
                .WithRequired(e => e.ListInterviewees)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Questions>()
                .HasMany(e => e.Answer)
                .WithRequired(e => e.Questions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RequestConnect>()
                .Property(e => e.Key)
                .IsFixedLength();

            modelBuilder.Entity<Survey>()
                .Property(e => e.TitleSurvery)
                .IsFixedLength();

            modelBuilder.Entity<Survey>()
                .HasMany(e => e.LaunchingQuestionnaire)
                .WithRequired(e => e.Survey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Survey>()
                .HasMany(e => e.Questions)
                .WithRequired(e => e.Survey)
                .HasForeignKey(e => e.SurveryID)
                .WillCascadeOnDelete(false);
        }
    }
}
