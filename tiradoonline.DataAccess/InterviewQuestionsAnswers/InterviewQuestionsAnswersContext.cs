using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

using tiradoonline.DataAccess.InterviewQuestionsAnswers.Models;

namespace tiradoonline.DataAccess.InterviewQuestionsAnswers
{

    public partial class InterviewQuestionsAnswersContext : DbContext
    {
        public InterviewQuestionsAnswersContext()
            : base("name=InterviewQuestionsAnswersContext")
        {
        }

        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answers>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<Questions>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<Questions>()
                .HasMany(e => e.Answers)
                .WithRequired(e => e.Questions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subjects>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<Subjects>()
                .HasMany(e => e.Questions)
                .WithRequired(e => e.Subjects)
                .WillCascadeOnDelete(false);
        }
    }
}
