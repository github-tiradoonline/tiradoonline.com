namespace tiradoonline.DataAccess.InterviewQuestionsAnswers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Questions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Questions()
        {
            Answers = new HashSet<Answers>();
        }

        [Key]
        public int QuestionID { get; set; }

        public int SubjectID { get; set; }

        [Required]
        public string Question { get; set; }

        public DateTime create_dt { get; set; }

        
        public virtual ICollection<Answers> Answers { get; set; }

        public virtual Subjects Subjects { get; set; }
    }
}
